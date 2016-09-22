using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using SharpBot.Botting;
using SharpBot.Input;
using Type = SharpBot.Botting.Type;

namespace SharpBot.Interface
{
    public partial class NewCommand : Form
    {
        private MainWindow mainWindow;
        public VirtualKeyCode currentKey;

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
            Command retCommand = null;
            int delay;
            if (!IsNumeric(txtDelayUntilNextCommand.Text) && txtDelayUntilNextCommand.Text != "Random")
                MessageBox.Show("Invalid delay until next command.");
            if (txtDelayUntilNextCommand.Text == "Random")
                delay = new Random().Next(10, 200);
            else
                 delay = int.Parse(txtDelayUntilNextCommand.Text);

            if (cmb_commandType.SelectedIndex == 0)
            {
                retCommand = GetMouseCommand();
            }

            if (retCommand != null) retCommand.Delay = delay;

            int index = mainWindow.listScriptsCommands.Items.Count;

            
            ListViewItem item = new ListViewItem(index.ToString());
            item.SubItems.Add(retCommand.CommandType.ToString());
            item.SubItems.Add("New command");
            item.SubItems.Add(retCommand.Delay.ToString());
            item.SubItems.Add(retCommand.Executed.ToString());
            item.Tag = retCommand;

            mainWindow.listScriptsCommands.Items.Add(item);
        }

        private Command GetMouseCommand()
        {
            MouseCommand command = new MouseCommand();

            command.CommandType = Type.Mouse;
            
            MouseClickType clickType = MouseClickType.LeftClick;
            switch (cmb_mouseCommandType.SelectedIndex)
            {
                case 0:
                    clickType = MouseClickType.Move;
                    break;
                case 1:
                    clickType = MouseClickType.RightClick;
                    break;
                case 2:
                    clickType = MouseClickType.LeftClick;
                    break;
                case 3:
                    clickType = MouseClickType.MiddleClick;
                    break;
            }
            command.ClickType = clickType;

            command.PixelMoveAntiScript = chkPixelMoveAntiScript.Checked;

            if (clickType == MouseClickType.Move)
            {
                if (!IsNumeric(txtMouseX.Text) || !IsNumeric(txtMouseY.Text))
                {
                    MessageBox.Show("Invalid mouse x/y coords.");
                    return null;
                }
                command.MouseX = int.Parse(txtMouseX.Text);
                command.MouseY = int.Parse(txtMouseY.Text);       

                return command;
            }

            MouseDelayType delayType = MouseDelayType.None;
            switch (cmb_DelayType.SelectedIndex)
            {
                case 0:
                    delayType = MouseDelayType.None;
                    break;
                case 1:
                    delayType = MouseDelayType.Predefined;
                    break;
                case 2:
                    delayType = MouseDelayType.Random;
                    break;
                case 3:
                    delayType = MouseDelayType.Partial;
                    break;
            }
            command.DelayType = delayType;


    
            switch (cmb_DelayType.SelectedIndex)
            {
                case 1:
                    if (!IsNumeric(txtDelayTime.Text))
                    {
                        MessageBox.Show("Invalid delay time!");
                        return null;
                    }
                    command.DelayTime = int.Parse(txtDelayTime.Text);
                    break;
                case 2:
                    if (!IsNumeric(txtRandomDelayMin.Text) || !IsNumeric(txtRandomDelayMax.Text))
                    {
                        MessageBox.Show("Invalid delay min/max time!");
                        return null;
                    }
                    command.DelayMin = int.Parse(txtRandomDelayMin.Text);
                    command.DelayMax = int.Parse(txtRandomDelayMax.Text);
                    break;
            }

            return command;
        }

        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
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
            VirtualKeyCode _checkedKey = IsAnyKeyDown();
            if (_checkedKey != VirtualKeyCode.NONAME)
            {
                currentKey = _checkedKey;
                txtKeyboardInputKey.Text = currentKey.ToString();
            }
        }

        private static readonly VirtualKeyCode[] UNALLOWED_KEYS =
        {
            VirtualKeyCode.LBUTTON,
            VirtualKeyCode.RBUTTON,
            VirtualKeyCode.MBUTTON,
            VirtualKeyCode.XBUTTON1,
            VirtualKeyCode.XBUTTON2,
            VirtualKeyCode.F9
        };



        public static VirtualKeyCode IsAnyKeyDown()
        {
            foreach (VirtualKeyCode key in Enum.GetValues(typeof(VirtualKeyCode)))
            {
                if (InputSimulator.IsKeyDown(key) && !UNALLOWED_KEYS.Any(p => p == key))
                    return key;
            }
            return VirtualKeyCode.NONAME;
        }
    }
}
