using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpBot.Interface
{
    public partial class MouseWatcher : Form, IMessageFilter
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
            Application.AddMessageFilter(this);
            tmrUpdateMouse.Start();
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
        }

        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;
        private bool KeyDepressed = false;

        public bool PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_KEYDOWN:
                    if ((Keys)m.WParam == Keys.F3)
                    {
                        KeyDepressed = true;
                        if(Opacity > 0.9)
                            lstMousePositions.Items.Add(mouseX + " , " + mouseY);
                    }
                    break;

                case WM_KEYUP:
                    if ((Keys)m.WParam == Keys.F3)
                    {
                        KeyDepressed = false;
                    }
                    break;
            }

            return false;
        }

    }
}
