using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpBot.Utility
{
    public static class WindowMethods
    {
        #region API 

        private const int SW_SHOWNORMAL = 1;

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern bool ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetForegroundWindow(IntPtr hwnd);

        #endregion

        public static bool SetForegroundByName(string name)
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

        public static bool SetForegroundByProcessID(int id)
        {
            Process p = Process.GetProcessById(id);

            try
            {
                ShowWindow(p.MainWindowHandle, SW_SHOWNORMAL);
                SetForegroundWindow(p.MainWindowHandle);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool SetForegroundByWindowTitle(string name)
        {
            IntPtr hWnd = IntPtr.Zero;
            foreach (Process pList in Process.GetProcesses())
            {
                if (pList.MainWindowTitle.Contains(name))
                {
                    hWnd = pList.MainWindowHandle;
                }
            }
            if (hWnd == IntPtr.Zero)
                return false;
            uint id;
            int pid;
            GetWindowThreadProcessId(hWnd,out id);
            pid = (int) id;
            
            return SetForegroundByProcessID(pid);
        }

    }
}
