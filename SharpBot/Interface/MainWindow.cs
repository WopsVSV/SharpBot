using System;
using System.Drawing;
using System.Windows.Forms;
using SharpBot.Botting;
using SharpBot.Utility;

namespace SharpBot.Interface
{
    public partial class MainWindow : Form
    {
        private MouseWatcher mouseWatcherForm;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(520,300);
            this.Icon = Properties.Resources.SharpBotIcon;
            mouseWatcherForm = new MouseWatcher();
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
            NewCommand newCommandWindow = new NewCommand(this);
            newCommandWindow.Show();
        }

        private void toolStripMenuItemOpenMouseWatcher_Click(object sender, EventArgs e)
        {
            mouseWatcherForm.Show();
            mouseWatcherForm.Opacity = 1.0;
        }

        private void dsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listScriptsCommands.Items)
            {
                Command comm = item.Tag as Command;
                if (comm != null)
                {
                    comm.Execute();
                    item.SubItems[4].Text = "True";
                    int sleepTime = int.Parse(item.SubItems[3].Text);
                    System.Threading.Thread.Sleep(sleepTime);
                }
            }
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
    }
}
