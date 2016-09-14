using System;
using System.Drawing;
using System.Windows.Forms;

namespace SharpBot.Interface
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.SharpBotIcon;
        }

        private void listScriptsCommands_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            ColumnHeader ch = listScriptsCommands.Columns[e.ColumnIndex];
            HorizontalAlignment colHal = ch.TextAlign;
            HorizontalAlignment headHal = colHal;

            headHal = HorizontalAlignment.Center;

            SizeF size = e.Graphics.MeasureString(ch.Text, e.Font);

            float x =
                headHal == HorizontalAlignment.Center ? (e.Bounds.Width - size.Width) / 2f :
                headHal == HorizontalAlignment.Right ? (e.Bounds.Width - size.Width) : 0f;

            e.DrawBackground();

            using (SolidBrush brush = new SolidBrush(e.ForeColor))
                e.Graphics.DrawString(ch.Text, e.Font, brush,
                                      e.Bounds.X + x, 5f, StringFormat.GenericDefault);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) {
            Program.EntryForm.Close();
        }

        private void listScriptsCommands_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.listScriptsCommands.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
