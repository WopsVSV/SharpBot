using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpBot.Input;

namespace SharpBot.Interface
{
    public partial class NewCommand : Form
    {
        private MainWindow mainWindow;
        private Keys currentKey = Keys.None;

        public NewCommand(MainWindow _mainWindow)
        {
            mainWindow = _mainWindow;
            InitializeComponent();
        }

        private void NewCommand_Load(object sender, EventArgs e)
        {
            cmb_commandType.SelectedIndex = 0;
            cmb_mouseCommandType.SelectedIndex = 1;
            cmb_DelayType.SelectedIndex = 0;
            cmb_DetectionType.SelectedIndex = 0;
            cmb_InputType.SelectedIndex = 0;

            pnlMouseMoveType.Location = new Point(3, 51);

            pnlKeyboardCommand.Location = new Point(25, 62);
            pnlWindowCommand.Location = new Point(25, 62);
            Size = new Size(284, 385);
        }

        private void cmb_commandType_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control p in Controls)
            {
                if (p is Panel)
                    p.Visible = false;
            }

            switch (cmb_commandType.SelectedIndex)
            {
                case 0:
                    pnlMouseCommand.Visible = true;
                    break;
                case 1:
                    pnlKeyboardCommand.Visible = true;
                    break;
                default:
                    pnlWindowCommand.Visible = true;
                    break;
            }
        }

        private void cmb_DelayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_DelayType.SelectedIndex == 0)
            {
                txtDelayTime.Enabled = false;
                txtRandomDelayMin.Enabled = false;
                txtRandomDelayMax.Enabled = false;
            }
            else if (cmb_DelayType.SelectedIndex == 1)
            {
                txtDelayTime.Enabled = true;
                txtRandomDelayMin.Enabled = false;
                txtRandomDelayMax.Enabled = false;
            }
            else if (cmb_DelayType.SelectedIndex == 2)
            {
                txtDelayTime.Enabled = false;
                txtRandomDelayMin.Enabled = true;
                txtRandomDelayMax.Enabled = true;
            }
            else if (cmb_DelayType.SelectedIndex == 3)
            {
                txtDelayTime.Enabled = false;
                txtRandomDelayMin.Enabled = false;
                txtRandomDelayMax.Enabled = false;
            }
        }

        private void cmb_mouseCommandType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_mouseCommandType.SelectedIndex == 0)
            {
                pnlMouseMoveType.Visible = true;
                pnlMouseClickType.Visible = false;
            }
            else
            {
                pnlMouseMoveType.Visible = false;
                pnlMouseClickType.Visible = true;
            }
        }

        private void btnCreateCommand_Click(object sender, EventArgs e)
        {

        }

        private void cmb_detectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_DetectionType.SelectedIndex == 0)
            {
                txtProcessName.Enabled = true;
                txtProcessID.Enabled = false;
                txtWindowName.Enabled = false;
            }
            else if (cmb_DetectionType.SelectedIndex == 1)
            {
                txtProcessName.Enabled = false;
                txtProcessID.Enabled = true;
                txtWindowName.Enabled = false;
            }
            else
            {
                txtProcessName.Enabled = false;
                txtProcessID.Enabled = false;
                txtWindowName.Enabled = true;
            }
        }

        private void cmb_InputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_InputType.SelectedIndex == 0)
            {
                txtKeyboardInputText.Enabled = true;
                txtKeyboardInputKey.Enabled = false;
                tmrHandleKey.Stop();
            }
            else if (cmb_InputType.SelectedIndex == 1)
            {
                txtKeyboardInputText.Enabled = false;
                txtKeyboardInputKey.Enabled = true;
                tmrHandleKey.Start();
            }
        }

        private void tmrHandleKey_Tick(object sender, EventArgs e)
        {
            Keys checkedKey = IsAnyKeyDown();
            if (checkedKey != Keys.None)
            {
                currentKey = checkedKey;
                txtKeyboardInputKey.Text = currentKey.ToString();
            }
        }

        private static Keys[] UNALLOWED_KEYS =
        {
            Keys.LButton,
            Keys.RButton,
            Keys.MButton,
            Keys.XButton1,
            Keys.XButton2,
            Keys.F9
        };


        public static Keys IsAnyKeyDown()
        {
            foreach (Keys key in Enum.GetValues(typeof (Keys)))
            {
                if (Keyboard.IsKeyDown(key) && !UNALLOWED_KEYS.Any(p => p == key))
                    return key;
            }
            return Keys.None;
        }
    }
}
