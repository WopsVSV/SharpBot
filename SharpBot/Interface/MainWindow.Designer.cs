namespace SharpBot.Interface
{
    partial class MainWindow
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopF9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listScriptsCommands = new System.Windows.Forms.ListView();
            this.ch_index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_actionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ch_Instructions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_delayToNext = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptToolStripMenuItem,
            this.scriptToolStripMenuItem1});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(830, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // scriptToolStripMenuItem
            // 
            this.scriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            this.scriptToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.scriptToolStripMenuItem.Text = "Script Load";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.closeToolStripMenuItem.Text = "Close SharpBot";
            // 
            // scriptToolStripMenuItem1
            // 
            this.scriptToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopF9ToolStripMenuItem});
            this.scriptToolStripMenuItem1.Name = "scriptToolStripMenuItem1";
            this.scriptToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.scriptToolStripMenuItem1.Text = "Script";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.startToolStripMenuItem.Text = "Start (F9)";
            // 
            // stopF9ToolStripMenuItem
            // 
            this.stopF9ToolStripMenuItem.Enabled = false;
            this.stopF9ToolStripMenuItem.Name = "stopF9ToolStripMenuItem";
            this.stopF9ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.stopF9ToolStripMenuItem.Text = "Stop (F9)";
            // 
            // listScriptsCommands
            // 
            this.listScriptsCommands.BackgroundImageTiled = true;
            this.listScriptsCommands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listScriptsCommands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_index,
            this.ch_actionType,
            this.ch_Instructions,
            this.ch_delayToNext});
            this.listScriptsCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScriptsCommands.FullRowSelect = true;
            this.listScriptsCommands.GridLines = true;
            this.listScriptsCommands.Location = new System.Drawing.Point(0, 24);
            this.listScriptsCommands.Name = "listScriptsCommands";
            this.listScriptsCommands.OwnerDraw = true;
            this.listScriptsCommands.Size = new System.Drawing.Size(830, 473);
            this.listScriptsCommands.TabIndex = 1;
            this.listScriptsCommands.UseCompatibleStateImageBehavior = false;
            this.listScriptsCommands.View = System.Windows.Forms.View.Details;
            this.listScriptsCommands.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listScriptsCommands_ColumnWidthChanging);
            this.listScriptsCommands.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listScriptsCommands_DrawColumnHeader);
            // 
            // ch_index
            // 
            this.ch_index.Text = "Index";
            this.ch_index.Width = 55;
            // 
            // ch_actionType
            // 
            this.ch_actionType.Text = "Action Type";
            this.ch_actionType.Width = 96;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ch_Instructions
            // 
            this.ch_Instructions.Text = "Instructions";
            this.ch_Instructions.Width = 174;
            // 
            // ch_delayToNext
            // 
            this.ch_delayToNext.Text = "Delay";
            this.ch_delayToNext.Width = 65;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 497);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listScriptsCommands);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ListView listScriptsCommands;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopF9ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader ch_actionType;
        private System.Windows.Forms.ColumnHeader ch_index;
        private System.Windows.Forms.ColumnHeader ch_Instructions;
        private System.Windows.Forms.ColumnHeader ch_delayToNext;
    }
}