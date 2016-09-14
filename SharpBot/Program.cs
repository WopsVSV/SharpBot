using System;
using System.Windows.Forms;
using SharpBot.Interface;

namespace SharpBot
{
    static class Program
    {
        public static Form EntryForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EntryForm = new SplashScreen();
            Application.Run(EntryForm);
        }
    }
}
