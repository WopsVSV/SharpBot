namespace SharpBot.Interface
{
    partial class MouseWatcher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMousePositions = new System.Windows.Forms.ListBox();
            this.tmrUpdateMouse = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "X: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.ForeColor = System.Drawing.Color.DarkRed;
            this.lblX.Location = new System.Drawing.Point(84, 11);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 18);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "0";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.ForeColor = System.Drawing.Color.DarkRed;
            this.lblY.Location = new System.Drawing.Point(84, 46);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 18);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Press F3 to save position";
            // 
            // lstMousePositions
            // 
            this.lstMousePositions.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMousePositions.FormattingEnabled = true;
            this.lstMousePositions.ItemHeight = 14;
            this.lstMousePositions.Location = new System.Drawing.Point(16, 142);
            this.lstMousePositions.Name = "lstMousePositions";
            this.lstMousePositions.Size = new System.Drawing.Size(168, 116);
            this.lstMousePositions.TabIndex = 5;
            this.lstMousePositions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstMousePositions_MouseClick);
            this.lstMousePositions.DoubleClick += new System.EventHandler(this.lstMousePositions_DoubleClick);
            this.lstMousePositions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstMousePositions_MouseDown);
            // 
            // tmrUpdateMouse
            // 
            this.tmrUpdateMouse.Interval = 75;
            this.tmrUpdateMouse.Tick += new System.EventHandler(this.tmrUpdateMouse_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Double-click to delete position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Right-click to export position";
            // 
            // MouseWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 267);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstMousePositions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MouseWatcher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Watcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MouseWatcher_FormClosing);
            this.Load += new System.EventHandler(this.MouseWatcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrUpdateMouse;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox lstMousePositions;
        private System.Windows.Forms.Label label5;
    }
}