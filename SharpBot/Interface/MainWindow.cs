using System;
using System.Drawing;
using System.Windows.Forms;

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
    }
}
