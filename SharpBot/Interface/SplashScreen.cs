using System;
using System.Windows.Forms;

namespace SharpBot.Interface
{
    public partial class SplashScreen : Form
    {
        private const int SPLASH_TIME = 500; // Time the splash screen will appear for
        private const string STATUS_MESSAGE = "Preparing your environment..."; // The status that will be shown to the user
        private int timeElapsed;
        
        public SplashScreen() {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e) {
            lblStatus.Text = STATUS_MESSAGE;
            tmrLoad.Interval = 100;
            tmrLoad.Start();
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            if (timeElapsed >= SPLASH_TIME) {
                tmrLoad.Stop();
                var mainForm = new MainWindow();
                mainForm.Show();
                this.Hide();
            }

            timeElapsed += tmrLoad.Interval;
        }
    }
}
