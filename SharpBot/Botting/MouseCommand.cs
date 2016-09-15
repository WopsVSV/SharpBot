using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpBot.Botting
{
    public class MouseCommand : Command
    {
        public MouseCommandType mouseCommandType;

        public int DelayBeforeMouseUp;
        public bool RandomDelayBeforeMouseUp;

        public MouseCommand(Type commandType, int delayMS) : base(commandType, delayMS)
        {
            
        }

        public void Execute()
        {
            
        }
    }
}
