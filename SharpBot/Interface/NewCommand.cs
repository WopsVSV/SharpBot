using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsInput;
using SharpBot.Botting;
using SharpBot.Input;
using SharpBot.Utility;
using Type = SharpBot.Botting.Type;

namespace SharpBot.Interface
{
    public partial class NewCommand : Form
    {
        private readonly MainWindow mainWindow;
        public VirtualKeyCode currentKey = VirtualKeyCode.NONAME;

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

        private void btnCreateCommand_Click(object sender, EventArgs e)
        {
            Command retCommand = null;

            if (!IsDelayValid())
                return;

            if (cmb_commandType.SelectedIndex == 0)
                retCommand = GetMouseCommand();
            else if (cmb_commandType.SelectedIndex == 1)
                retCommand = GetKeyboardCommand();
            else if (cmb_commandType.SelectedIndex == 2)
                retCommand = GetWindowCommand();

            if (retCommand == null)
                return;

            retCommand.Delay = GetRandomDelay();
            AddItemToList(retCommand);
        }

        private bool IsDelayValid()
        {
            if (!CalculationMethods.IsNumeric(txtDelayUntilNextCommand.Text) &&
                txtDelayUntilNextCommand.Text != "Random")
            {
                MessageBox.Show("Invalid delay until next command.");
                return false;
            }

            return true;
        }

        private int GetRandomDelay()
        {
            int retVal;
            if (txtDelayUntilNextCommand.Text == "Random")
                retVal = new Random().Next(100, 1000);
            else
                retVal = int.Parse(txtDelayUntilNextCommand.Text);

            return retVal;
        }

        private void AddItemToList(Command retCommand)
        {
            int index = mainWindow.listScriptsCommands.Items.Count;

            CommandDescription desc = new CommandDescription(retCommand);

            ListViewItem item = new ListViewItem(index.ToString());
            item.SubItems.Add(retCommand.CommandType.ToString());
            item.SubItems.Add(desc.ToString());
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
                if (!CalculationMethods.IsNumeric(txtMouseX.Text) || !CalculationMethods.IsNumeric(txtMouseY.Text))
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
                    if (!CalculationMethods.IsNumeric(txtDelayTime.Text))
                    {
                        MessageBox.Show("Invalid delay time!");
                        return null;
                    }
                    command.DelayTime = int.Parse(txtDelayTime.Text);
                    break;
                case 2:
                    if (!CalculationMethods.IsNumeric(txtRandomDelayMin.Text) || !CalculationMethods.IsNumeric(txtRandomDelayMax.Text))
                    {
                        MessageBox.Show("Invalid delay min/max time!");
                        return null;
                    }
                    var delayMin = int.Parse(txtRandomDelayMin.Text);
                    var delayMax = int.Parse(txtRandomDelayMax.Text);
                    if (delayMin > delayMax)
                    {
                        MessageBox.Show("Minimum delay bigger than maximum delay!");
                        return null;
                    }
                    command.DelayMin = delayMin;
                    command.DelayMax = delayMax;
                    break;
            }

            return command;
        }

        private Command GetWindowCommand()
        {
            WindowCommand command = new WindowCommand();

            switch (cmb_DetectionType.SelectedIndex)
            {
                case 0:
                    if (txtProcessName.Text.EndsWith(".exe"))
                        txtProcessName.Text = txtProcessName.Text.Replace(".exe", string.Empty);
                    if (IsFieldEmpty(txtProcessName))
                        return null;
                    command.DetectionType = WindowCommand.WindowDetectionType.ProcessName;
                    command.SubmittedValue = txtProcessName.Text;
                    break;
                case 1:
                    if (!CalculationMethods.IsNumeric(txtProcessID.Text) || IsFieldEmpty(txtProcessID)) {
                        MessageBox.Show("Invalid process ID.");
                        return null;
                    }                    
                    command.DetectionType = WindowCommand.WindowDetectionType.ProcessID;
                    command.SubmittedValue = txtProcessID.Text;
                    break;
                case 2:
                    if (IsFieldEmpty(txtWindowName))
                        return null;
                    command.DetectionType = WindowCommand.WindowDetectionType.WindowName;
                    command.SubmittedValue = txtWindowName.Text;
                    break;
            }

            return command;
        }

        private Command GetKeyboardCommand()
        {
            KeyboardCommand command = new KeyboardCommand();

            switch (cmb_InputType.SelectedIndex)
            {
                case 0:
                    if (string.IsNullOrEmpty(txtKeyboardInputText.Text)) {
                        MessageBox.Show("Invalid input text.");
                        return null;
                    }
                    command.KeyboardCommandType = KeyboardCommand.KeyboardCommandT.Text;
                    command.InputText = txtKeyboardInputText.Text;
                    break;
                case 1:
                    if (currentKey == VirtualKeyCode.NONAME) {
                        MessageBox.Show("No key selected.");
                        return null;
                    }
                    command.KeyboardCommandType = KeyboardCommand.KeyboardCommandT.Key;;
                    command.InputKey = currentKey;
                    break;
            }

            return command;
        }

        private bool IsFieldEmpty(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Empty field!");
                return true;
            }
            return false;
        }
        private void tmrHandleKey_Tick(object sender, EventArgs e)
        {
            VirtualKeyCode _checkedKey = Keyboard.IsAnyKeyDown();
            if (_checkedKey != VirtualKeyCode.NONAME)
            {
                currentKey = _checkedKey;
                txtKeyboardInputKey.Text = currentKey.ToString();
            }
        }

        #region IndexChanged Methods
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
        #endregion

    }
}
