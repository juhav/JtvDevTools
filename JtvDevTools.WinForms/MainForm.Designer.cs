
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            txtEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            txtLog = new FastColoredTextBoxNS.FastColoredTextBox();
            MainMenuStrip = new MenuStrip();
            FileToolStripMainMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMainMenuItem = new ToolStripMenuItem();
            FormatJSONToolStripMenuItem = new ToolStripMenuItem();
            FormatXMLToolStripMenuItem = new ToolStripMenuItem();
            JoinToolStripMenuItem = new ToolStripMenuItem();
            ListDuplicatesToolStripMenuItem = new ToolStripMenuItem();
            PrependAppendToolStripMenuItem = new ToolStripMenuItem();
            RemoveEmptyToolStripMenuItem = new ToolStripMenuItem();
            SQLIn123ToolStripMenuItem = new ToolStripMenuItem();
            SQLInabcToolStripMenuItem = new ToolStripMenuItem();
            TrimToolStripMenuItem = new ToolStripMenuItem();
            UniqueToolStripMenuItem = new ToolStripMenuItem();
            ViewToolStripMainMenuItem = new ToolStripMenuItem();
            LogToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEditor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLog).BeginInit();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(txtEditor, 0, 0);
            tableLayoutPanel1.Controls.Add(txtLog, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.18127F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.81872F));
            tableLayoutPanel1.Size = new Size(1175, 713);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // txtEditor
            // 
            txtEditor.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
            txtEditor.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            txtEditor.AutoScrollMinSize = new Size(25, 15);
            txtEditor.BackBrush = null;
            txtEditor.BackColor = Color.FromArgb(20, 20, 20);
            txtEditor.CaretColor = Color.WhiteSmoke;
            txtEditor.CharHeight = 15;
            txtEditor.CharWidth = 7;
            txtEditor.Cursor = Cursors.IBeam;
            txtEditor.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            txtEditor.Dock = DockStyle.Fill;
            txtEditor.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEditor.ForeColor = Color.Gainsboro;
            txtEditor.IsReplaceMode = false;
            txtEditor.Location = new Point(4, 3);
            txtEditor.Margin = new Padding(4, 3, 4, 3);
            txtEditor.Name = "txtEditor";
            txtEditor.Paddings = new Padding(0);
            txtEditor.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            txtEditor.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("txtEditor.ServiceColors");
            txtEditor.Size = new Size(1168, 608);
            txtEditor.TabIndex = 5;
            txtEditor.Zoom = 100;
            txtEditor.Enter += txtEditor_Enter;
            // 
            // txtLog
            // 
            txtLog.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
            txtLog.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            txtLog.AutoScrollMinSize = new Size(25, 15);
            txtLog.BackBrush = null;
            txtLog.BackColor = Color.FromArgb(20, 20, 20);
            txtLog.CaretColor = Color.WhiteSmoke;
            txtLog.CharHeight = 15;
            txtLog.CharWidth = 7;
            txtLog.Cursor = Cursors.IBeam;
            txtLog.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            txtLog.Dock = DockStyle.Fill;
            txtLog.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLog.ForeColor = Color.Gainsboro;
            txtLog.IsReplaceMode = false;
            txtLog.Location = new Point(4, 617);
            txtLog.Margin = new Padding(4, 3, 4, 3);
            txtLog.Name = "txtLog";
            txtLog.Paddings = new Padding(0);
            txtLog.ReadOnly = true;
            txtLog.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            txtLog.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("txtLog.ServiceColors");
            txtLog.Size = new Size(1168, 93);
            txtLog.TabIndex = 7;
            txtLog.Zoom = 100;
            txtLog.Enter += txtLog_Enter;
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMainMenuItem, EditToolStripMainMenuItem, ViewToolStripMainMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Padding = new Padding(7, 2, 0, 2);
            MainMenuStrip.Size = new Size(1175, 24);
            MainMenuStrip.TabIndex = 4;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMainMenuItem
            // 
            FileToolStripMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem });
            FileToolStripMainMenuItem.Name = "FileToolStripMainMenuItem";
            FileToolStripMainMenuItem.Size = new Size(37, 20);
            FileToolStripMainMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            NewToolStripMenuItem.Size = new Size(141, 22);
            NewToolStripMenuItem.Text = "New";
            NewToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // EditToolStripMainMenuItem
            // 
            EditToolStripMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FormatJSONToolStripMenuItem, FormatXMLToolStripMenuItem, JoinToolStripMenuItem, ListDuplicatesToolStripMenuItem, PrependAppendToolStripMenuItem, RemoveEmptyToolStripMenuItem, SQLIn123ToolStripMenuItem, SQLInabcToolStripMenuItem, TrimToolStripMenuItem, UniqueToolStripMenuItem });
            EditToolStripMainMenuItem.Name = "EditToolStripMainMenuItem";
            EditToolStripMainMenuItem.Size = new Size(39, 20);
            EditToolStripMainMenuItem.Text = "Edit";
            // 
            // FormatJSONToolStripMenuItem
            // 
            FormatJSONToolStripMenuItem.Name = "FormatJSONToolStripMenuItem";
            FormatJSONToolStripMenuItem.Size = new Size(176, 22);
            FormatJSONToolStripMenuItem.Tag = "6";
            FormatJSONToolStripMenuItem.Text = "Format JSON";
            FormatJSONToolStripMenuItem.Click += CommandMenuItem_Click;
            // 
            // FormatXMLToolStripMenuItem
            // 
            FormatXMLToolStripMenuItem.Name = "FormatXMLToolStripMenuItem";
            FormatXMLToolStripMenuItem.Size = new Size(176, 22);
            FormatXMLToolStripMenuItem.Tag = "5";
            FormatXMLToolStripMenuItem.Text = "Format XML";
            FormatXMLToolStripMenuItem.Click += CommandMenuItem_Click;
            // 
            // JoinToolStripMenuItem
            // 
            JoinToolStripMenuItem.Name = "JoinToolStripMenuItem";
            JoinToolStripMenuItem.Size = new Size(176, 22);
            JoinToolStripMenuItem.Text = "Join";
            JoinToolStripMenuItem.Click += JoinToolStripMenuItem_Click;
            // 
            // ListDuplicatesToolStripMenuItem
            // 
            ListDuplicatesToolStripMenuItem.Name = "ListDuplicatesToolStripMenuItem";
            ListDuplicatesToolStripMenuItem.Size = new Size(176, 22);
            ListDuplicatesToolStripMenuItem.Tag = "4";
            ListDuplicatesToolStripMenuItem.Text = "List Duplicates";
            ListDuplicatesToolStripMenuItem.Click += CommandMenuItem_Click;
            // 
            // PrependAppendToolStripMenuItem
            // 
            PrependAppendToolStripMenuItem.Name = "PrependAppendToolStripMenuItem";
            PrependAppendToolStripMenuItem.Size = new Size(176, 22);
            PrependAppendToolStripMenuItem.Text = "Prepend && Append";
            PrependAppendToolStripMenuItem.Click += PrependAppendToolStripMenuItem_Click;
            // 
            // RemoveEmptyToolStripMenuItem
            // 
            RemoveEmptyToolStripMenuItem.Name = "RemoveEmptyToolStripMenuItem";
            RemoveEmptyToolStripMenuItem.Size = new Size(176, 22);
            RemoveEmptyToolStripMenuItem.Tag = "3";
            RemoveEmptyToolStripMenuItem.Text = "Remove empty";
            RemoveEmptyToolStripMenuItem.Click += CommandMenuItem_Click;
            // 
            // SQLIn123ToolStripMenuItem
            // 
            SQLIn123ToolStripMenuItem.Name = "SQLIn123ToolStripMenuItem";
            SQLIn123ToolStripMenuItem.Size = new Size(176, 22);
            SQLIn123ToolStripMenuItem.Tag = "9";
            SQLIn123ToolStripMenuItem.Text = "SQL in (1,2,3)";
            SQLIn123ToolStripMenuItem.Click += CommandMenuItem_Click;
            // 
            // SQLInabcToolStripMenuItem
            // 
            SQLInabcToolStripMenuItem.Name = "SQLInabcToolStripMenuItem";
            SQLInabcToolStripMenuItem.Size = new Size(176, 22);
            SQLInabcToolStripMenuItem.Tag = "10";
            SQLInabcToolStripMenuItem.Text = "SQL in ('a', 'b','c')";
            SQLInabcToolStripMenuItem.Click += CommandMenuItem_Click;
            // 
            // TrimToolStripMenuItem
            // 
            TrimToolStripMenuItem.Name = "TrimToolStripMenuItem";
            TrimToolStripMenuItem.Size = new Size(176, 22);
            TrimToolStripMenuItem.Tag = "1";
            TrimToolStripMenuItem.Text = "Trim";
            TrimToolStripMenuItem.Click += CommandMenuItem_Click;
            // 
            // UniqueToolStripMenuItem
            // 
            UniqueToolStripMenuItem.Name = "UniqueToolStripMenuItem";
            UniqueToolStripMenuItem.Size = new Size(176, 22);
            UniqueToolStripMenuItem.Tag = "2";
            UniqueToolStripMenuItem.Text = "Unique";
            UniqueToolStripMenuItem.Click += CommandMenuItem_Click;
            // 
            // ViewToolStripMainMenuItem
            // 
            ViewToolStripMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LogToolStripMenuItem });
            ViewToolStripMainMenuItem.Name = "ViewToolStripMainMenuItem";
            ViewToolStripMainMenuItem.Size = new Size(44, 20);
            ViewToolStripMainMenuItem.Text = "View";
            // 
            // LogToolStripMenuItem
            // 
            LogToolStripMenuItem.Checked = true;
            LogToolStripMenuItem.CheckState = CheckState.Checked;
            LogToolStripMenuItem.Name = "LogToolStripMenuItem";
            LogToolStripMenuItem.Size = new Size(94, 22);
            LogToolStripMenuItem.Text = "Log";
            LogToolStripMenuItem.Click += LogToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 737);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MainMenuStrip);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "JtvDevTools";
            KeyDown += MainForm_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtEditor).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLog).EndInit();
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private FastColoredTextBoxNS.FastColoredTextBox txtEditor;
        private FastColoredTextBoxNS.FastColoredTextBox txtLog;
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem EditToolStripMainMenuItem;
        private ToolStripMenuItem TrimToolStripMenuItem;
        private ToolStripMenuItem RemoveEmptyToolStripMenuItem;
        private ToolStripMenuItem ListDuplicatesToolStripMenuItem;
        private ToolStripMenuItem UniqueToolStripMenuItem;
        private ToolStripMenuItem FormatXMLToolStripMenuItem;
        private ToolStripMenuItem FormatJSONToolStripMenuItem;
        private ToolStripMenuItem PrependAppendToolStripMenuItem;
        private ToolStripMenuItem JoinToolStripMenuItem;
        private ToolStripMenuItem SQLIn123ToolStripMenuItem;
        private ToolStripMenuItem SQLInabcToolStripMenuItem;
        private ToolStripMenuItem FileToolStripMainMenuItem;
        private ToolStripMenuItem NewToolStripMenuItem;
        private ToolStripMenuItem ViewToolStripMainMenuItem;
        private ToolStripMenuItem LogToolStripMenuItem;
    }
}

