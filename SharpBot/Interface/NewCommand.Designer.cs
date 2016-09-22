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
            this.components = new System.ComponentModel.Container();
            this.cmb_commandType = new System.Windows.Forms.ComboBox();
            this.deco_1 = new System.Windows.Forms.Label();
            this.pnlMouseCommand = new System.Windows.Forms.Panel();
            this.pnlMouseMoveType = new System.Windows.Forms.Panel();
            this.btnImportFromWatcher = new System.Windows.Forms.Button();
            this.txtMouseY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMouseX = new System.Windows.Forms.TextBox();
            this.pnlMouseClickType = new System.Windows.Forms.Panel();
            this.txtRandomDelayMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRandomDelayMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelayTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_DelayType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_mouseCommandType = new System.Windows.Forms.ComboBox();
            this.btnCreateCommand = new System.Windows.Forms.Button();
            this.pnlKeyboardCommand = new System.Windows.Forms.Panel();
            this.txtKeyboardInputKey = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKeyboardInputText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_InputType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlWindowCommand = new System.Windows.Forms.Panel();
            this.txtWindowName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProcessID = new System.Windows.Forms.TextBox();
            this.cmb_DetectionType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProcessName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDelayUntilNextCommand = new System.Windows.Forms.TextBox();
            this.tmrHandleKey = new System.Windows.Forms.Timer(this.components);
            this.pnlMouseCommand.SuspendLayout();
            this.pnlMouseMoveType.SuspendLayout();
            this.pnlMouseClickType.SuspendLayout();
            this.pnlKeyboardCommand.SuspendLayout();
            this.pnlWindowCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_commandType
            // 
            this.cmb_commandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_commandType.FormattingEnabled = true;
            this.cmb_commandType.Items.AddRange(new object[] {
            "Mouse",
            "Keyboard",
            "Window"});
            this.cmb_commandType.Location = new System.Drawing.Point(112, 25);
            this.cmb_commandType.Name = "cmb_commandType";
            this.cmb_commandType.Size = new System.Drawing.Size(135, 21);
            this.cmb_commandType.TabIndex = 0;
            this.cmb_commandType.SelectedIndexChanged += new System.EventHandler(this.cmb_commandType_SelectedIndexChanged);
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
            // pnlMouseCommand
            // 
            this.pnlMouseCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMouseCommand.Controls.Add(this.pnlMouseMoveType);
            this.pnlMouseCommand.Controls.Add(this.pnlMouseClickType);
            this.pnlMouseCommand.Controls.Add(this.label1);
            this.pnlMouseCommand.Controls.Add(this.cmb_mouseCommandType);
            this.pnlMouseCommand.Location = new System.Drawing.Point(25, 62);
            this.pnlMouseCommand.Name = "pnlMouseCommand";
            this.pnlMouseCommand.Size = new System.Drawing.Size(222, 230);
            this.pnlMouseCommand.TabIndex = 2;
            // 
            // pnlMouseMoveType
            // 
            this.pnlMouseMoveType.Controls.Add(this.btnImportFromWatcher);
            this.pnlMouseMoveType.Controls.Add(this.txtMouseY);
            this.pnlMouseMoveType.Controls.Add(this.label8);
            this.pnlMouseMoveType.Controls.Add(this.label7);
            this.pnlMouseMoveType.Controls.Add(this.txtMouseX);
            this.pnlMouseMoveType.Location = new System.Drawing.Point(3, 219);
            this.pnlMouseMoveType.Name = "pnlMouseMoveType";
            this.pnlMouseMoveType.Size = new System.Drawing.Size(213, 172);
            this.pnlMouseMoveType.TabIndex = 14;
            // 
            // btnImportFromWatcher
            // 
            this.btnImportFromWatcher.Location = new System.Drawing.Point(21, 69);
            this.btnImportFromWatcher.Name = "btnImportFromWatcher";
            this.btnImportFromWatcher.Size = new System.Drawing.Size(176, 26);
            this.btnImportFromWatcher.TabIndex = 15;
            this.btnImportFromWatcher.Text = "Import from Mouse Watcher";
            this.btnImportFromWatcher.UseVisualStyleBackColor = true;
            // 
            // txtMouseY
            // 
            this.txtMouseY.Location = new System.Drawing.Point(88, 43);
            this.txtMouseY.Name = "txtMouseY";
            this.txtMouseY.Size = new System.Drawing.Size(110, 20);
            this.txtMouseY.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mouse X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mouse Y:";
            // 
            // txtMouseX
            // 
            this.txtMouseX.Location = new System.Drawing.Point(88, 17);
            this.txtMouseX.Name = "txtMouseX";
            this.txtMouseX.Size = new System.Drawing.Size(109, 20);
            this.txtMouseX.TabIndex = 14;
            // 
            // pnlMouseClickType
            // 
            this.pnlMouseClickType.Controls.Add(this.txtRandomDelayMax);
            this.pnlMouseClickType.Controls.Add(this.label5);
            this.pnlMouseClickType.Controls.Add(this.txtRandomDelayMin);
            this.pnlMouseClickType.Controls.Add(this.label4);
            this.pnlMouseClickType.Controls.Add(this.txtDelayTime);
            this.pnlMouseClickType.Controls.Add(this.label3);
            this.pnlMouseClickType.Controls.Add(this.cmb_DelayType);
            this.pnlMouseClickType.Controls.Add(this.label2);
            this.pnlMouseClickType.Location = new System.Drawing.Point(3, 51);
            this.pnlMouseClickType.Name = "pnlMouseClickType";
            this.pnlMouseClickType.Size = new System.Drawing.Size(214, 162);
            this.pnlMouseClickType.TabIndex = 6;
            // 
            // txtRandomDelayMax
            // 
            this.txtRandomDelayMax.Location = new System.Drawing.Point(114, 124);
            this.txtRandomDelayMax.Name = "txtRandomDelayMax";
            this.txtRandomDelayMax.Size = new System.Drawing.Size(89, 20);
            this.txtRandomDelayMax.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Random delay max:";
            // 
            // txtRandomDelayMin
            // 
            this.txtRandomDelayMin.Location = new System.Drawing.Point(113, 98);
            this.txtRandomDelayMin.Name = "txtRandomDelayMin";
            this.txtRandomDelayMin.Size = new System.Drawing.Size(89, 20);
            this.txtRandomDelayMin.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Random delay min:";
            // 
            // txtDelayTime
            // 
            this.txtDelayTime.Location = new System.Drawing.Point(113, 59);
            this.txtDelayTime.Name = "txtDelayTime";
            this.txtDelayTime.Size = new System.Drawing.Size(90, 20);
            this.txtDelayTime.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Delay time (ms):";
            // 
            // cmb_DelayType
            // 
            this.cmb_DelayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DelayType.FormattingEnabled = true;
            this.cmb_DelayType.Items.AddRange(new object[] {
            "None",
            "Predefined",
            "Random",
            "Partial"});
            this.cmb_DelayType.Location = new System.Drawing.Point(90, 18);
            this.cmb_DelayType.Name = "cmb_DelayType";
            this.cmb_DelayType.Size = new System.Drawing.Size(112, 21);
            this.cmb_DelayType.TabIndex = 7;
            this.cmb_DelayType.SelectedIndexChanged += new System.EventHandler(this.cmb_DelayType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Delay type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type:";
            // 
            // cmb_mouseCommandType
            // 
            this.cmb_mouseCommandType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mouseCommandType.FormattingEnabled = true;
            this.cmb_mouseCommandType.Items.AddRange(new object[] {
            "Move",
            "Right Click",
            "Left Click",
            "Middle Click"});
            this.cmb_mouseCommandType.Location = new System.Drawing.Point(70, 24);
            this.cmb_mouseCommandType.Name = "cmb_mouseCommandType";
            this.cmb_mouseCommandType.Size = new System.Drawing.Size(135, 21);
            this.cmb_mouseCommandType.TabIndex = 5;
            this.cmb_mouseCommandType.SelectedIndexChanged += new System.EventHandler(this.cmb_mouseCommandType_SelectedIndexChanged);
            // 
            // btnCreateCommand
            // 
            this.btnCreateCommand.Location = new System.Drawing.Point(25, 298);
            this.btnCreateCommand.Name = "btnCreateCommand";
            this.btnCreateCommand.Size = new System.Drawing.Size(81, 43);
            this.btnCreateCommand.TabIndex = 3;
            this.btnCreateCommand.Text = "Create";
            this.btnCreateCommand.UseVisualStyleBackColor = true;
            this.btnCreateCommand.Click += new System.EventHandler(this.btnCreateCommand_Click);
            // 
            // pnlKeyboardCommand
            // 
            this.pnlKeyboardCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKeyboardCommand.Controls.Add(this.txtKeyboardInputKey);
            this.pnlKeyboardCommand.Controls.Add(this.label15);
            this.pnlKeyboardCommand.Controls.Add(this.txtKeyboardInputText);
            this.pnlKeyboardCommand.Controls.Add(this.label14);
            this.pnlKeyboardCommand.Controls.Add(this.cmb_InputType);
            this.pnlKeyboardCommand.Controls.Add(this.label13);
            this.pnlKeyboardCommand.Location = new System.Drawing.Point(481, 62);
            this.pnlKeyboardCommand.Name = "pnlKeyboardCommand";
            this.pnlKeyboardCommand.Size = new System.Drawing.Size(222, 230);
            this.pnlKeyboardCommand.TabIndex = 3;
            // 
            // txtKeyboardInputKey
            // 
            this.txtKeyboardInputKey.Enabled = false;
            this.txtKeyboardInputKey.Location = new System.Drawing.Point(25, 175);
            this.txtKeyboardInputKey.Name = "txtKeyboardInputKey";
            this.txtKeyboardInputKey.ReadOnly = true;
            this.txtKeyboardInputKey.Size = new System.Drawing.Size(165, 20);
            this.txtKeyboardInputKey.TabIndex = 15;
            this.txtKeyboardInputKey.Text = "Press any key...";
            this.txtKeyboardInputKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Key:";
            // 
            // txtKeyboardInputText
            // 
            this.txtKeyboardInputText.Location = new System.Drawing.Point(25, 91);
            this.txtKeyboardInputText.Multiline = true;
            this.txtKeyboardInputText.Name = "txtKeyboardInputText";
            this.txtKeyboardInputText.Size = new System.Drawing.Size(165, 50);
            this.txtKeyboardInputText.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Text:";
            // 
            // cmb_InputType
            // 
            this.cmb_InputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_InputType.FormattingEnabled = true;
            this.cmb_InputType.Items.AddRange(new object[] {
            "Text",
            "Key"});
            this.cmb_InputType.Location = new System.Drawing.Point(85, 24);
            this.cmb_InputType.Name = "cmb_InputType";
            this.cmb_InputType.Size = new System.Drawing.Size(105, 21);
            this.cmb_InputType.TabIndex = 10;
            this.cmb_InputType.SelectedIndexChanged += new System.EventHandler(this.cmb_InputType_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Input type:";
            // 
            // pnlWindowCommand
            // 
            this.pnlWindowCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWindowCommand.Controls.Add(this.txtWindowName);
            this.pnlWindowCommand.Controls.Add(this.label12);
            this.pnlWindowCommand.Controls.Add(this.txtProcessID);
            this.pnlWindowCommand.Controls.Add(this.cmb_DetectionType);
            this.pnlWindowCommand.Controls.Add(this.label10);
            this.pnlWindowCommand.Controls.Add(this.label9);
            this.pnlWindowCommand.Controls.Add(this.txtProcessName);
            this.pnlWindowCommand.Controls.Add(this.label11);
            this.pnlWindowCommand.Location = new System.Drawing.Point(253, 62);
            this.pnlWindowCommand.Name = "pnlWindowCommand";
            this.pnlWindowCommand.Size = new System.Drawing.Size(222, 230);
            this.pnlWindowCommand.TabIndex = 4;
            // 
            // txtWindowName
            // 
            this.txtWindowName.Location = new System.Drawing.Point(110, 121);
            this.txtWindowName.Name = "txtWindowName";
            this.txtWindowName.Size = new System.Drawing.Size(98, 20);
            this.txtWindowName.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Window name:";
            // 
            // txtProcessID
            // 
            this.txtProcessID.Location = new System.Drawing.Point(110, 95);
            this.txtProcessID.Name = "txtProcessID";
            this.txtProcessID.Size = new System.Drawing.Size(98, 20);
            this.txtProcessID.TabIndex = 16;
            // 
            // cmb_DetectionType
            // 
            this.cmb_DetectionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DetectionType.FormattingEnabled = true;
            this.cmb_DetectionType.Items.AddRange(new object[] {
            "Process name",
            "Process ID",
            "Window name"});
            this.cmb_DetectionType.Location = new System.Drawing.Point(89, 24);
            this.cmb_DetectionType.Name = "cmb_DetectionType";
            this.cmb_DetectionType.Size = new System.Drawing.Size(120, 21);
            this.cmb_DetectionType.TabIndex = 8;
            this.cmb_DetectionType.SelectedIndexChanged += new System.EventHandler(this.cmb_detectionType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Process ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Detection type:";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(109, 69);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Size = new System.Drawing.Size(99, 20);
            this.txtProcessName.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Process name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Delay until next command:";
            // 
            // txtDelayUntilNextCommand
            // 
            this.txtDelayUntilNextCommand.Location = new System.Drawing.Point(131, 321);
            this.txtDelayUntilNextCommand.Name = "txtDelayUntilNextCommand";
            this.txtDelayUntilNextCommand.Size = new System.Drawing.Size(89, 20);
            this.txtDelayUntilNextCommand.TabIndex = 13;
            this.txtDelayUntilNextCommand.Text = "Random";
            this.txtDelayUntilNextCommand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrHandleKey
            // 
            this.tmrHandleKey.Tick += new System.EventHandler(this.tmrHandleKey_Tick);
            // 
            // NewCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 527);
            this.Controls.Add(this.txtDelayUntilNextCommand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlWindowCommand);
            this.Controls.Add(this.pnlKeyboardCommand);
            this.Controls.Add(this.btnCreateCommand);
            this.Controls.Add(this.pnlMouseCommand);
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
            this.Load += new System.EventHandler(this.NewCommand_Load);
            this.pnlMouseCommand.ResumeLayout(false);
            this.pnlMouseCommand.PerformLayout();
            this.pnlMouseMoveType.ResumeLayout(false);
            this.pnlMouseMoveType.PerformLayout();
            this.pnlMouseClickType.ResumeLayout(false);
            this.pnlMouseClickType.PerformLayout();
            this.pnlKeyboardCommand.ResumeLayout(false);
            this.pnlKeyboardCommand.PerformLayout();
            this.pnlWindowCommand.ResumeLayout(false);
            this.pnlWindowCommand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_commandType;
        private System.Windows.Forms.Label deco_1;
        private System.Windows.Forms.Panel pnlMouseCommand;
        private System.Windows.Forms.Button btnCreateCommand;
        private System.Windows.Forms.Panel pnlKeyboardCommand;
        private System.Windows.Forms.Panel pnlWindowCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_mouseCommandType;
        private System.Windows.Forms.Panel pnlMouseClickType;
        private System.Windows.Forms.ComboBox cmb_DelayType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRandomDelayMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRandomDelayMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDelayTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDelayUntilNextCommand;
        private System.Windows.Forms.Panel pnlMouseMoveType;
        private System.Windows.Forms.Button btnImportFromWatcher;
        private System.Windows.Forms.TextBox txtMouseY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMouseX;
        private System.Windows.Forms.TextBox txtWindowName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProcessID;
        private System.Windows.Forms.ComboBox cmb_DetectionType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProcessName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKeyboardInputKey;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtKeyboardInputText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_InputType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer tmrHandleKey;
    }
}