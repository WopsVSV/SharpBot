using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpBot.Botting;

namespace SharpBot.Interface
{
    public class CommandDescription
    {
        private Command command;
        private string description = "Not defined.";

        public CommandDescription(Command command)
        {
            this.command = command;
            Update();
        }

        public void Update()
        {
            if (command is MouseCommand)
            {
                description = GetMouseDescription();
            }
            else if (command is WindowCommand)
            {
                description = GetWindowDescription();
            }
            else if (command is KeyboardCommand)
            {
                description = GetKeyboardDescription();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private string GetMouseDescription()
        {
            var comm = command as MouseCommand;
            var retVal = string.Empty;

            switch (comm.ClickType)
            {
                case MouseClickType.LeftClick:
                    retVal += "L-Click, ";
                    break;
                case MouseClickType.MiddleClick:
                    retVal += "M-Click, ";
                    break;
                case MouseClickType.RightClick:
                    retVal += "R-Click, ";
                    break;
                case MouseClickType.Move:
                    retVal += "Move, ";
                    break;
            }

            if (retVal.Contains("-"))
            {
                if(comm.DelayType == MouseDelayType.None)
                    retVal += String.Format("{0}", comm.DelayType);
                else
                    retVal += String.Format("{0}, ",comm.DelayType);

                switch (comm.DelayType)
                {
                    case MouseDelayType.Predefined:
                        retVal += String.Format("Value: {0}ms", comm.DelayTime);
                        break;
                    case MouseDelayType.Random:
                        retVal += String.Format("Min: {0}ms, Max: {1}ms", comm.DelayMin, comm.DelayMax);
                        break;
                }
                
                return retVal;
            }

            retVal += String.Format("{0}, {1}",comm.MouseX, comm.MouseY);
            return retVal;
        }

        private string GetWindowDescription()
        {
            var comm = command as WindowCommand;
            string retVal = string.Empty;

            switch (comm.DetectionType)
            {
                case WindowCommand.WindowDetectionType.ProcessName:
                    retVal = String.Format("Process name: {0}", comm.SubmittedValue);
                    break;
                case WindowCommand.WindowDetectionType.ProcessID:
                    retVal = String.Format("Process ID: {0}", comm.SubmittedValue);
                    break;
                case WindowCommand.WindowDetectionType.WindowName:
                    retVal = String.Format("Window name: {0}", comm.SubmittedValue);
                    break;
            }

            return retVal;
        }

        private string GetKeyboardDescription()
        {
            var comm = command as KeyboardCommand;
            string retVal = string.Empty;

            switch (comm.KeyboardCommandType)
            {
                case KeyboardCommand.KeyboardCommandT.Text:
                    retVal = String.Format("Text: {0}", comm.InputText);
                    break;
                case KeyboardCommand.KeyboardCommandT.Key:
                    retVal = String.Format("Key: {0}", comm.InputKey);
                    break;
            }

            return retVal;
        }

        public override string ToString()
        {
            return description;
        }
    }
}
