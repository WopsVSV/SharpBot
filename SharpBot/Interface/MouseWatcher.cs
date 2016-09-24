using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpBot.Input;

namespace SharpBot.Interface
{
    public partial class MouseWatcher : Form
    {
        private int mouseX, mouseY;

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys ArrowKeys);

        public MouseWatcher()
        {
            InitializeComponent();
        }

        private void MouseWatcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Opacity = 0.5;
            this.Hide();
        }

        private void MouseWatcher_Load(object sender, EventArgs e)
        {
            tmrUpdateMouse.Start();
        }

        private void lstMousePositions_DoubleClick(object sender, EventArgs e)
        {
            if(lstMousePositions.SelectedItem != null)
                lstMousePositions.Items.Remove(lstMousePositions.SelectedItem);
        }

        private void lstMousePositions_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lstMousePositions_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lstMousePositions.SelectedItem != null)
            {
                Form fc = Application.OpenForms["NewCommand"];

                if (fc == null)
                    return;

                NewCommand f = fc as NewCommand;
                if (f.cmb_commandType.SelectedIndex == 0 && f.cmb_mouseCommandType.SelectedIndex == 0)
                {
                    var sPositions = lstMousePositions.SelectedItem.ToString().Replace(" ", string.Empty).Split(',');

                    if (sPositions.Length != 2)
                        throw new InvalidDataException();

                    f.txtMouseX.Text = sPositions[0];
                    f.txtMouseY.Text = sPositions[1];

                }
            }
        }

        private void tmrUpdateMouse_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0.9)
            {
                mouseX = Cursor.Position.X;
                mouseY = Cursor.Position.Y;
                lblX.Text = mouseX.ToString();
                lblY.Text = mouseY.ToString();
            }
            if(Keyboard.IsKeyDown(Keys.F3))
                if (Opacity > 0.9)
                    lstMousePositions.Items.Add(mouseX + " , " + mouseY);
        }

    }
}
