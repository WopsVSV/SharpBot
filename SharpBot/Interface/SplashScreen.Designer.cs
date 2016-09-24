namespace SharpBot.Interface
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pnlBackgroundImage = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlBackgroundImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackgroundImage
            // 
            this.pnlBackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBackgroundImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackgroundImage.Controls.Add(this.lblStatus);
            this.pnlBackgroundImage.Controls.Add(this.pbLogo);
            this.pnlBackgroundImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.pnlBackgroundImage.Name = "pnlBackgroundImage";
            this.pnlBackgroundImage.Size = new System.Drawing.Size(673, 198);
            this.pnlBackgroundImage.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(226, 125);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 26);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Empty";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(7, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(661, 186);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // tmrLoad
            // 
            this.tmrLoad.Enabled = true;
            this.tmrLoad.Interval = 250;
            this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(673, 198);
            this.Controls.Add(this.pnlBackgroundImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpBot";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.pnlBackgroundImage.ResumeLayout(false);
            this.pnlBackgroundImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackgroundImage;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

