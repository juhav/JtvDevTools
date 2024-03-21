namespace JtvDevTools.RestClient
{
    partial class MainForm
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOOLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.OpenRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.tOOLSToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1139, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewRequestToolStripMenuItem,
            this.OpenRequestToolStripMenuItem,
            this.SaveRequestToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.FileToolStripMenuItem.Text = "FILE";
            // 
            // NewRequestToolStripMenuItem
            // 
            this.NewRequestToolStripMenuItem.Name = "NewRequestToolStripMenuItem";
            this.NewRequestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewRequestToolStripMenuItem.Text = "New Request";
            this.NewRequestToolStripMenuItem.Click += new System.EventHandler(this.NewRequestToolStripMenuItem_Click);
            // 
            // SaveRequestToolStripMenuItem
            // 
            this.SaveRequestToolStripMenuItem.Name = "SaveRequestToolStripMenuItem";
            this.SaveRequestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveRequestToolStripMenuItem.Text = "Save Request";
            this.SaveRequestToolStripMenuItem.Click += new System.EventHandler(this.SaveRequestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // tOOLSToolStripMenuItem
            // 
            this.tOOLSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VariablesToolStripMenuItem});
            this.tOOLSToolStripMenuItem.Name = "tOOLSToolStripMenuItem";
            this.tOOLSToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tOOLSToolStripMenuItem.Text = "TOOLS";
            // 
            // VariablesToolStripMenuItem
            // 
            this.VariablesToolStripMenuItem.Name = "VariablesToolStripMenuItem";
            this.VariablesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.VariablesToolStripMenuItem.Text = "Variables...";
            this.VariablesToolStripMenuItem.Click += new System.EventHandler(this.VariablesToolStripMenuItem_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1139, 773);
            this.MainTabControl.TabIndex = 3;
            // 
            // OpenRequestToolStripMenuItem
            // 
            this.OpenRequestToolStripMenuItem.Name = "OpenRequestToolStripMenuItem";
            this.OpenRequestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenRequestToolStripMenuItem.Text = "Open Request";
            this.OpenRequestToolStripMenuItem.Click += new System.EventHandler(this.OpenRequestToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 797);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JtvRestClient";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ToolStripMenuItem tOOLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VariablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenRequestToolStripMenuItem;
    }
}

