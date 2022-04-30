
namespace JtvDevTools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLog = new FastColoredTextBoxNS.FastColoredTextBox();
            this.txtOutput = new FastColoredTextBoxNS.FastColoredTextBox();
            this.txtInput = new FastColoredTextBoxNS.FastColoredTextBox();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListDuplicatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrependAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SQLIn123ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UniqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFlip = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SQLInabcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtLog, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtOutput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInput, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 580);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtLog.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.txtLog.BackBrush = null;
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtLog.CaretColor = System.Drawing.Color.WhiteSmoke;
            this.txtLog.CharHeight = 15;
            this.txtLog.CharWidth = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.txtLog, 2);
            this.txtLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtLog.IsReplaceMode = false;
            this.txtLog.Location = new System.Drawing.Point(3, 486);
            this.txtLog.Name = "txtLog";
            this.txtLog.Paddings = new System.Windows.Forms.Padding(0);
            this.txtLog.ReadOnly = true;
            this.txtLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtLog.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtLog.ServiceColors")));
            this.txtLog.Size = new System.Drawing.Size(1001, 91);
            this.txtLog.TabIndex = 7;
            this.txtLog.Zoom = 100;
            // 
            // txtOutput
            // 
            this.txtOutput.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtOutput.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.txtOutput.BackBrush = null;
            this.txtOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtOutput.CaretColor = System.Drawing.Color.WhiteSmoke;
            this.txtOutput.CharHeight = 15;
            this.txtOutput.CharWidth = 7;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtOutput.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtOutput.IsReplaceMode = false;
            this.txtOutput.Location = new System.Drawing.Point(506, 3);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Paddings = new System.Windows.Forms.Padding(0);
            this.txtOutput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtOutput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtOutput.ServiceColors")));
            this.txtOutput.Size = new System.Drawing.Size(498, 477);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.Zoom = 100;
            // 
            // txtInput
            // 
            this.txtInput.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtInput.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.txtInput.BackBrush = null;
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtInput.CaretColor = System.Drawing.Color.WhiteSmoke;
            this.txtInput.CharHeight = 15;
            this.txtInput.CharWidth = 7;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtInput.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtInput.IsReplaceMode = false;
            this.txtInput.Location = new System.Drawing.Point(3, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Paddings = new System.Windows.Forms.Padding(0);
            this.txtInput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtInput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtInput.ServiceColors")));
            this.txtInput.Size = new System.Drawing.Size(497, 477);
            this.txtInput.TabIndex = 5;
            this.txtInput.Zoom = 100;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1007, 24);
            this.MainMenuStrip.TabIndex = 4;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatJSONToolStripMenuItem,
            this.FormatXMLToolStripMenuItem,
            this.JoinToolStripMenuItem,
            this.ListDuplicatesToolStripMenuItem,
            this.PrependAppendToolStripMenuItem,
            this.RemoveEmptyToolStripMenuItem,
            this.SQLIn123ToolStripMenuItem,
            this.SQLInabcToolStripMenuItem,
            this.TrimToolStripMenuItem,
            this.UniqueToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.textToolStripMenuItem.Text = "Text";
            // 
            // FormatJSONToolStripMenuItem
            // 
            this.FormatJSONToolStripMenuItem.Name = "FormatJSONToolStripMenuItem";
            this.FormatJSONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FormatJSONToolStripMenuItem.Tag = "6";
            this.FormatJSONToolStripMenuItem.Text = "Format JSON";
            this.FormatJSONToolStripMenuItem.Click += new System.EventHandler(this.CommandMenuItem_Click);
            // 
            // FormatXMLToolStripMenuItem
            // 
            this.FormatXMLToolStripMenuItem.Name = "FormatXMLToolStripMenuItem";
            this.FormatXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FormatXMLToolStripMenuItem.Tag = "5";
            this.FormatXMLToolStripMenuItem.Text = "Format XML";
            this.FormatXMLToolStripMenuItem.Click += new System.EventHandler(this.CommandMenuItem_Click);
            // 
            // JoinToolStripMenuItem
            // 
            this.JoinToolStripMenuItem.Name = "JoinToolStripMenuItem";
            this.JoinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.JoinToolStripMenuItem.Text = "Join";
            this.JoinToolStripMenuItem.Click += new System.EventHandler(this.JoinToolStripMenuItem_Click);
            // 
            // ListDuplicatesToolStripMenuItem
            // 
            this.ListDuplicatesToolStripMenuItem.Name = "ListDuplicatesToolStripMenuItem";
            this.ListDuplicatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ListDuplicatesToolStripMenuItem.Tag = "4";
            this.ListDuplicatesToolStripMenuItem.Text = "List Duplicates";
            this.ListDuplicatesToolStripMenuItem.Click += new System.EventHandler(this.CommandMenuItem_Click);
            // 
            // PrependAppendToolStripMenuItem
            // 
            this.PrependAppendToolStripMenuItem.Name = "PrependAppendToolStripMenuItem";
            this.PrependAppendToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PrependAppendToolStripMenuItem.Text = "Prepend && Append";
            this.PrependAppendToolStripMenuItem.Click += new System.EventHandler(this.PrependAppendToolStripMenuItem_Click);
            // 
            // RemoveEmptyToolStripMenuItem
            // 
            this.RemoveEmptyToolStripMenuItem.Name = "RemoveEmptyToolStripMenuItem";
            this.RemoveEmptyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveEmptyToolStripMenuItem.Tag = "3";
            this.RemoveEmptyToolStripMenuItem.Text = "Remove empty";
            this.RemoveEmptyToolStripMenuItem.Click += new System.EventHandler(this.CommandMenuItem_Click);
            // 
            // SQLIn123ToolStripMenuItem
            // 
            this.SQLIn123ToolStripMenuItem.Name = "SQLIn123ToolStripMenuItem";
            this.SQLIn123ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SQLIn123ToolStripMenuItem.Tag = "9";
            this.SQLIn123ToolStripMenuItem.Text = "SQL in (1,2,3)";
            this.SQLIn123ToolStripMenuItem.Click += new System.EventHandler(this.CommandMenuItem_Click);
            // 
            // TrimToolStripMenuItem
            // 
            this.TrimToolStripMenuItem.Name = "TrimToolStripMenuItem";
            this.TrimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TrimToolStripMenuItem.Tag = "1";
            this.TrimToolStripMenuItem.Text = "Trim";
            this.TrimToolStripMenuItem.Click += new System.EventHandler(this.CommandMenuItem_Click);
            // 
            // UniqueToolStripMenuItem
            // 
            this.UniqueToolStripMenuItem.Name = "UniqueToolStripMenuItem";
            this.UniqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UniqueToolStripMenuItem.Tag = "2";
            this.UniqueToolStripMenuItem.Text = "Unique";
            this.UniqueToolStripMenuItem.Click += new System.EventHandler(this.CommandMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFlip);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 35);
            this.panel1.TabIndex = 5;
            // 
            // btnFlip
            // 
            this.btnFlip.Location = new System.Drawing.Point(89, 3);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(75, 29);
            this.btnFlip.TabIndex = 1;
            this.btnFlip.Text = "Flip";
            this.btnFlip.UseVisualStyleBackColor = true;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SQLInabcToolStripMenuItem
            // 
            this.SQLInabcToolStripMenuItem.Name = "SQLInabcToolStripMenuItem";
            this.SQLInabcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SQLInabcToolStripMenuItem.Tag = "10";
            this.SQLInabcToolStripMenuItem.Text = "SQL in (\'a\', \'b\',\'c\')";
            this.SQLInabcToolStripMenuItem.Click += new System.EventHandler(this.CommandMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 639);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenuStrip);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "JtvDevTools";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInput)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FastColoredTextBoxNS.FastColoredTextBox txtInput;
        private FastColoredTextBoxNS.FastColoredTextBox txtLog;
        private FastColoredTextBoxNS.FastColoredTextBox txtOutput;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveEmptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListDuplicatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UniqueToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem FormatXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrependAppendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SQLIn123ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SQLInabcToolStripMenuItem;
    }
}

