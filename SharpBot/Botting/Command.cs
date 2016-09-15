using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBot.Botting
{
    public class Command
    {
        public Type CommandType;
        public int Delay;

        public enum MouseCommandType
        {
            RightClick,
            LeftClick,
            MiddleClick,
            Move
        }

        public enum Type
        {
            Mouse,
            Keyboard,
            Window
        }

        public Command(Type commandType, int delayMS)
        {
            Delay = delayMS;
            CommandType = commandType;
        }
    }
}
