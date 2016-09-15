namespace SharpBot.Interface
{
    partial class NewCommand
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
            this.cmb_commandType = new System.Windows.Forms.ComboBox();
            this.deco_1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_commandType
            // 
            this.cmb_commandType.FormattingEnabled = true;
            this.cmb_commandType.Items.AddRange(new object[] {
            "Mouse",
            "Keyboard",
            "Window"});
            this.cmb_commandType.Location = new System.Drawing.Point(126, 25);
            this.cmb_commandType.Name = "cmb_commandType";
            this.cmb_commandType.Size = new System.Drawing.Size(121, 21);
            this.cmb_commandType.TabIndex = 0;
            // 
            // deco_1
            // 
            this.deco_1.AutoSize = true;
            this.deco_1.Location = new System.Drawing.Point(22, 28);
            this.deco_1.Name = "deco_1";
            this.deco_1.Size = new System.Drawing.Size(84, 13);
            this.deco_1.TabIndex = 1;
            this.deco_1.Text = "Command Type:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(25, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 230);
            this.panel1.TabIndex = 2;
            // 
            // btnCreateCommand
            // 
            this.btnCreateCommand.Location = new System.Drawing.Point(25, 298);
            this.btnCreateCommand.Name = "btnCreateCommand";
            this.btnCreateCommand.Size = new System.Drawing.Size(81, 27);
            this.btnCreateCommand.TabIndex = 3;
            this.btnCreateCommand.Text = "Create";
            this.btnCreateCommand.UseVisualStyleBackColor = true;
            // 
            // NewCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 333);
            this.Controls.Add(this.btnCreateCommand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deco_1);
            this.Controls.Add(this.cmb_commandType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCommand";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Command";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_commandType;
        private System.Windows.Forms.Label deco_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateCommand;
    }
}