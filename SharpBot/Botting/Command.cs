using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBot.Botting
{
    public enum MouseDelayType
    {
        None,
        Random,
        Partial,
        Predefined
    }

    public enum MouseClickType
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

    public class Command
    {
        public Type CommandType;
        public int Delay = 50;
        public bool Executed = false;
        public string Result;

        public Command(Type commandType)
        {
            CommandType = commandType;
        }

        public virtual void Execute()
        {
            Executed = true;
        }
    }
}
