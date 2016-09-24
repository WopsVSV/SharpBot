using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpBot.Input;

namespace SharpBot.Botting
{
    public class MouseCommand : Command
    {
        private readonly Random random = new Random();

        public MouseClickType ClickType;
        public MouseDelayType DelayType;
        public Mouse.MouseEventFlags MouseFlag = Mouse.MouseEventFlags.LeftDown;

        public int DelayMin, DelayMax, DelayTime, MouseX, MouseY;
        public bool PixelMoveAntiScript = true;
        
        public MouseCommand() : base(Type.Mouse) { }
  
        public override void Execute()
        {
            // Execute the click if it is not a mouse movement
            if (ClickType == MouseClickType.Move)
            {
                Mouse.MoveMouse(MouseX, MouseY, 0, 0);
                return;
            }

            // Convert ClickType into MouseFlag
            switch (ClickType)
            {
                case MouseClickType.LeftClick:
                    MouseFlag = Mouse.MouseEventFlags.LeftDown;
                    break;
                case MouseClickType.RightClick:
                    MouseFlag = Mouse.MouseEventFlags.RightDown;
                    break;
                case MouseClickType.MiddleClick:
                    MouseFlag = Mouse.MouseEventFlags.MiddleDown;
                    break;
            }

            // If it's not a mouse movement, execute the mouse down event
            Mouse.MouseEvent(MouseFlag);

            // Calculate and efectuate delay
            int delayTime;
            switch (DelayType)
            {
                case MouseDelayType.None:
                    delayTime = 1;
                    break;
                case MouseDelayType.Partial:
                   delayTime = 5 + random.Next(0,5);
                    break;
                case MouseDelayType.Predefined:
                    delayTime = DelayTime;
                    break;
                case MouseDelayType.Random:
                   delayTime = random.Next(DelayMin, DelayMax);
                    break;
                default:
                    delayTime = 1;
                    break;
            }
            System.Threading.Thread.Sleep(delayTime);

            // Execute the mouse up function
            switch (ClickType)
            {
                case MouseClickType.LeftClick:
                    Mouse.MouseEvent(Mouse.MouseEventFlags.LeftUp);
                    break;
                case MouseClickType.MiddleClick:
                    Mouse.MouseEvent(Mouse.MouseEventFlags.MiddleUp);
                    break;
                case MouseClickType.RightClick:
                    Mouse.MouseEvent(Mouse.MouseEventFlags.RightUp);
                    break;
            }

            Result = "Completed succesfully";

            base.Execute();
        }
    }
}
