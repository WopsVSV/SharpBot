﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpBot.Program_Interaction
{
    public static class WindowMethods
    {
        #region API 

        private const int SW_SHOWNORMAL = 1;

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetForegroundWindow(IntPtr hwnd);

        #endregion

        public static bool SetForeground(string name)
        {
            Process[] processes = Process.GetProcessesByName(name);

            foreach (Process p in processes)
            {
                ShowWindow(p.MainWindowHandle, SW_SHOWNORMAL);
                SetForegroundWindow(p.MainWindowHandle);
                return true;
            }

            return false;
        }

    }
}
