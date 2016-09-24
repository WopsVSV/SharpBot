using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpBot.Utility;

namespace SharpBot.Botting
{
    public class WindowCommand : Command
    {
        public enum WindowDetectionType
        {
            ProcessName,
            ProcessID,
            WindowName
        }

        public WindowDetectionType DetectionType = 0;
        public string SubmittedValue;

        public WindowCommand() : base(Type.Window) { }

        public override void Execute()
        {
            switch (DetectionType)
            {
                case WindowDetectionType.ProcessName:
                    Result = WindowMethods.SetForegroundByName(SubmittedValue).ToString();
                    break;
                case WindowDetectionType.ProcessID:
                    int pid = int.Parse(SubmittedValue);
                    Result = WindowMethods.SetForegroundByProcessID(pid).ToString();
                    break;
                case WindowDetectionType.WindowName:
                    Result = WindowMethods.SetForegroundByWindowTitle(SubmittedValue).ToString();
                    break;
                default:
                    break;
            }

            Result = "Window brought to focus.";

            base.Execute();
        }
    }
}
