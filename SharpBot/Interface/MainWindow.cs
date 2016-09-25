using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using SharpBot.Botting;
using SharpBot.Input;
using SharpBot.Utility;

namespace SharpBot.Interface
{
    public partial class MainWindow : Form
    {
        private MouseWatcher mouseWatcherForm;
        private Thread executionThread;

        public MainWindow()
        { 
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(520,300);
            this.Icon = Properties.Resources.SharpBotIcon;
            mouseWatcherForm = new MouseWatcher();

            listScriptsCommands.DragDropFinish += delegate
            {
                RecalculateIndexes();
            };

        }

        #region GUI Methods

        private void listScriptsCommands_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
           InterfaceMethods.DrawColumnHeader_DrawCenteredColumnHeader(sender, e);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            Program.EntryForm.Close();
        }

        private void listScriptsCommands_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
           InterfaceMethods.ColumnWidthChanging_UnresizeableColumHeader(sender, e);
        }

        private void listScriptsCommands_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listScriptsCommands_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
                e.DrawDefault = true;
        }

        #endregion

        private void newCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCommand newCommandWindow = new NewCommand(this, mouseWatcherForm);
            newCommandWindow.Show();
        }

        private void toolStripMenuItemOpenMouseWatcher_Click(object sender, EventArgs e)
        {
            mouseWatcherForm.Show();
            mouseWatcherForm.Opacity = 1.0;
        }


        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listScriptsCommands.Items.Count == 0)
                return;

            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;

            executionThread = new Thread(Execute);
            executionThread.IsBackground = true;

            commands.Clear();
            foreach (ListViewItem item in listScriptsCommands.Items)
            {
                Command comm = item.Tag as Command;
                if (comm != null)
                {
                   commands.Add(comm);
                }
            }

            executionThread.Start();
        }

        private List<Command> commands = new List<Command>();
        private void Execute()
        {
            int index = 0;
            foreach (Command comm in commands)
            {
                comm.Execute();
                Thread.Sleep(comm.Delay);
                this.Invoke((MethodInvoker)delegate
                {
                    listScriptsCommands.Items[index].SubItems[4].Text = "True";
                });
                index++;
            }
            this.Invoke((MethodInvoker)delegate
            {
                startToolStripMenuItem.Enabled = true;
                 stopToolStripMenuItem.Enabled = false;
                foreach (ListViewItem item in listScriptsCommands.Items)
                {
                    item.SubItems[4].Text = "False";
                }
            });
            executionThread.Abort();
        }

        
        private void deleteCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listScriptsCommands.SelectedItems.Count == 1 && listScriptsCommands.SelectedItems[0] != null)
            {
                listScriptsCommands.Items.Remove(listScriptsCommands.SelectedItems[0]);
                RecalculateIndexes();
            }
        }

        private void RecalculateIndexes()
        {
            int index = 0;
            foreach (ListViewItem item in listScriptsCommands.Items)
            {
                item.SubItems[0].Text = index.ToString();
                index++;
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            executionThread.Abort();
            startToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = false;

            foreach (ListViewItem item in listScriptsCommands.Items)
            {
                item.SubItems[4].Text = "False";
            }
        }

        #region UI Calling

        private delegate void SetControlPropertyThreadSafeDelegate(
    Control control,
    string propertyName,
    object propertyValue);

        public static void SetControlPropertyThreadSafe(
            Control control,
            string propertyName,
            object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }


        #endregion

        private int cooldown = 0;
        private void tmrKeyHandling_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Keys.F9) && cooldown == 0)
            {
                if(startToolStripMenuItem.Enabled)
                    startToolStripMenuItem.PerformClick();
                else
                    stopToolStripMenuItem.PerformClick();
                cooldown = 300;
            }
            if(cooldown > 0)
                 cooldown -= tmrKeyHandling.Interval;
        }


    }
}
