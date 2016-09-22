using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace SharpBot.Botting
{
    public class KeyboardCommand : Command
    {
        public enum KeyboardCommandT
        {
            Key,
            Text
        }

        public KeyboardCommandT KeyboardCommandType;
        public VirtualKeyCode InputKey = VirtualKeyCode.NONAME;
        public string InputText;

        public KeyboardCommand() : base(Type.Keyboard) { }

        public override void Execute()
        {
            switch (KeyboardCommandType)
            {
                case KeyboardCommandT.Text:
                    InputSimulator.SimulateTextEntry(InputText);
                    break;
                case KeyboardCommandT.Key:
                    InputSimulator.SimulateKeyPress(InputKey);
                    break;
            }

            Result = "Input simulated.";
            base.Execute();
        }
    }
}
