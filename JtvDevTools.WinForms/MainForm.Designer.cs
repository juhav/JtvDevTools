
namespace JtvDevTools.WinForms
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
            this.txtEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.txtLog = new FastColoredTextBoxNS.FastColoredTextBox();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListDuplicatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrependAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SQLIn123ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SQLInabcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UniqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLog)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtEditor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLog, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.18127F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.81872F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1175, 713);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtEditor
            // 
            this.txtEditor.AutoCompleteBracketsList = new char[] {
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
            this.txtEditor.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.txtEditor.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.txtEditor.BackBrush = null;
            this.txtEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtEditor.CaretColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditor.CharHeight = 15;
            this.txtEditor.CharWidth = 7;
            this.txtEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEditor.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtEditor.IsReplaceMode = false;
            this.txtEditor.Location = new System.Drawing.Point(4, 3);
            this.txtEditor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.txtEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtEditor.ServiceColors")));
            this.txtEditor.Size = new System.Drawing.Size(1168, 608);
            this.txtEditor.TabIndex = 5;
            this.txtEditor.Zoom = 100;
            this.txtEditor.Enter += new System.EventHandler(this.txtEditor_Enter);
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
            this.txtLog.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.txtLog.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.txtLog.BackBrush = null;
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtLog.CaretColor = System.Drawing.Color.WhiteSmoke;
            this.txtLog.CharHeight = 15;
            this.txtLog.CharWidth = 7;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLog.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtLog.IsReplaceMode = false;
            this.txtLog.Location = new System.Drawing.Point(4, 617);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLog.Name = "txtLog";
            this.txtLog.Paddings = new System.Windows.Forms.Padding(0);
            this.txtLog.ReadOnly = true;
            this.txtLog.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtLog.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtLog.ServiceColors")));
            this.txtLog.Size = new System.Drawing.Size(1168, 93);
            this.txtLog.TabIndex = 7;
            this.txtLog.Zoom = 100;
            this.txtLog.Enter += new System.EventHandler(this.txtLog_Enter);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMainMenuItem,
            this.EditToolStripMainMenuItem,
            this.ViewToolStripMainMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MainMenuStrip.Size = new System.Drawing.Size(1175, 24);
            this.MainMenuStrip.TabIndex = 4;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMainMenuItem
            // 
            this.FileToolStripMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem});
            this.FileToolStripMainMenuItem.Name = "FileToolStripMainMenuItem";
            this.FileToolStripMainMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMainMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // EditToolStripMainMenuItem
            // 
            this.EditToolStripMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.EditToolStripMainMenuItem.Name = "EditToolStripMainMenuItem";
            this.EditToolStripMainMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMainMenuItem.Text = "Edit";
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
            // SQLInabcToolStripMenuItem
            // 
            this.SQLInabcToolStripMenuItem.Name = "SQLInabcToolStripMenuItem";
            this.SQLInabcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SQLInabcToolStripMenuItem.Tag = "10";
            this.SQLInabcToolStripMenuItem.Text = "SQL in (\'a\', \'b\',\'c\')";
            this.SQLInabcToolStripMenuItem.Click += new System.EventHandler(this.CommandMenuItem_Click);
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
            // ViewToolStripMainMenuItem
            // 
            this.ViewToolStripMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogToolStripMenuItem});
            this.ViewToolStripMainMenuItem.Name = "ViewToolStripMainMenuItem";
            this.ViewToolStripMainMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewToolStripMainMenuItem.Text = "View";
            // 
            // LogToolStripMenuItem
            // 
            this.LogToolStripMenuItem.Checked = true;
            this.LogToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LogToolStripMenuItem.Name = "LogToolStripMenuItem";
            this.LogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LogToolStripMenuItem.Text = "Log";
            this.LogToolStripMenuItem.Click += new System.EventHandler(this.LogToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 737);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MainMenuStrip);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "JtvDevTools";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLog)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FastColoredTextBoxNS.FastColoredTextBox txtEditor;
        private FastColoredTextBoxNS.FastColoredTextBox txtLog;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveEmptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListDuplicatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UniqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrependAppendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SQLIn123ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SQLInabcToolStripMenuItem;
        private ToolStripMenuItem FileToolStripMainMenuItem;
        private ToolStripMenuItem NewToolStripMenuItem;
        private ToolStripMenuItem ViewToolStripMainMenuItem;
        private ToolStripMenuItem LogToolStripMenuItem;
    }
}

