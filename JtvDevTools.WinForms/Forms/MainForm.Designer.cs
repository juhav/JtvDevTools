
namespace JtvDevTools.WinForms.Forms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            MainMenuStrip = new MenuStrip();
            FileToolStripMainMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            ViewToolStripMainMenuItem = new ToolStripMenuItem();
            SQLToolsToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            toolStrip2 = new ToolStrip();
            TextEditorNewToolStripButton = new ToolStripButton();
            TextEditorEditToolStripDropDownButton = new ToolStripDropDownButton();
            tabPage2 = new TabPage();
            dgvEditor = new DataGridView();
            toolStrip1 = new ToolStrip();
            TableEditorNewToolStripDropDownButton = new ToolStripDropDownButton();
            NewRowToolStripMenuItem = new ToolStripMenuItem();
            NewColumnToolStripMenuItem = new ToolStripMenuItem();
            TableEditorToolStripDropDownButton = new ToolStripDropDownButton();
            TableEditorTrimToolStripMenuItem = new ToolStripMenuItem();
            TableEditorInsertGuidToolStripMenuItem = new ToolStripMenuItem();
            TableEditorColumnToolStripDropDownButton = new ToolStripDropDownButton();
            TableEditorAddColumnToolStripMenuItem = new ToolStripMenuItem();
            TableEditorDeleteColumnsToolStripMenuItem = new ToolStripMenuItem();
            tabPage3 = new TabPage();
            HttpClientSplitContainer = new SplitContainer();
            txtRequest = new FastColoredTextBoxNS.FastColoredTextBox();
            txtResponse = new FastColoredTextBoxNS.FastColoredTextBox();
            toolStrip3 = new ToolStrip();
            HttpClientRequestToolStripDropDownButton = new ToolStripDropDownButton();
            HttpClientNewRequestToolStripMenuItem = new ToolStripMenuItem();
            HtpClientSelectClientCertificateToolStripMenuItem = new ToolStripMenuItem();
            HttpClientSendToolStripButton = new ToolStripButton();
            BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)txtEditor).BeginInit();
            MainMenuStrip.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            toolStrip2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditor).BeginInit();
            toolStrip1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HttpClientSplitContainer).BeginInit();
            HttpClientSplitContainer.Panel1.SuspendLayout();
            HttpClientSplitContainer.Panel2.SuspendLayout();
            HttpClientSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtRequest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtResponse).BeginInit();
            toolStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // txtEditor
            // 
            txtEditor.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            txtEditor.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            txtEditor.AutoScrollMinSize = new Size(39, 15);
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
            txtEditor.Location = new Point(3, 28);
            txtEditor.Margin = new Padding(4, 3, 4, 3);
            txtEditor.Name = "txtEditor";
            txtEditor.Paddings = new Padding(0);
            txtEditor.ReservedCountOfLineNumberChars = 3;
            txtEditor.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            txtEditor.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("txtEditor.ServiceColors");
            txtEditor.Size = new Size(1237, 654);
            txtEditor.TabIndex = 5;
            txtEditor.Zoom = 100;
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMainMenuItem, ViewToolStripMainMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Padding = new Padding(7, 2, 0, 2);
            MainMenuStrip.Size = new Size(1251, 24);
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
            // ViewToolStripMainMenuItem
            // 
            ViewToolStripMainMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SQLToolsToolStripMenuItem });
            ViewToolStripMainMenuItem.Name = "ViewToolStripMainMenuItem";
            ViewToolStripMainMenuItem.Size = new Size(44, 20);
            ViewToolStripMainMenuItem.Text = "View";
            // 
            // SQLToolsToolStripMenuItem
            // 
            SQLToolsToolStripMenuItem.Name = "SQLToolsToolStripMenuItem";
            SQLToolsToolStripMenuItem.Size = new Size(125, 22);
            SQLToolsToolStripMenuItem.Text = "SQL Tools";
            SQLToolsToolStripMenuItem.Click += SQLToolsToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1251, 713);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtEditor);
            tabPage1.Controls.Add(toolStrip2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1243, 685);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Text Editor";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { TextEditorNewToolStripButton, TextEditorEditToolStripDropDownButton });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1237, 25);
            toolStrip2.TabIndex = 4;
            toolStrip2.Text = "toolStrip2";
            // 
            // TextEditorNewToolStripButton
            // 
            TextEditorNewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TextEditorNewToolStripButton.Image = (Image)resources.GetObject("TextEditorNewToolStripButton.Image");
            TextEditorNewToolStripButton.ImageTransparentColor = Color.Magenta;
            TextEditorNewToolStripButton.Name = "TextEditorNewToolStripButton";
            TextEditorNewToolStripButton.Size = new Size(35, 22);
            TextEditorNewToolStripButton.Text = "New";
            TextEditorNewToolStripButton.Click += TextEditorNewToolStripButton_Click;
            // 
            // TextEditorEditToolStripDropDownButton
            // 
            TextEditorEditToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TextEditorEditToolStripDropDownButton.Image = (Image)resources.GetObject("TextEditorEditToolStripDropDownButton.Image");
            TextEditorEditToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            TextEditorEditToolStripDropDownButton.Name = "TextEditorEditToolStripDropDownButton";
            TextEditorEditToolStripDropDownButton.Size = new Size(40, 22);
            TextEditorEditToolStripDropDownButton.Text = "Edit";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvEditor);
            tabPage2.Controls.Add(toolStrip1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1243, 685);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Table Editor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEditor
            // 
            dgvEditor.AllowUserToAddRows = false;
            dgvEditor.AllowUserToOrderColumns = true;
            dgvEditor.AllowUserToResizeRows = false;
            dgvEditor.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvEditor.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvEditor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEditor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEditor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEditor.Dock = DockStyle.Fill;
            dgvEditor.EnableHeadersVisualStyles = false;
            dgvEditor.Location = new Point(3, 28);
            dgvEditor.Name = "dgvEditor";
            dgvEditor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEditor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEditor.RowTemplate.Height = 25;
            dgvEditor.Size = new Size(1237, 654);
            dgvEditor.TabIndex = 0;
            dgvEditor.DataMemberChanged += dgvEditor_DataMemberChanged;
            dgvEditor.CellMouseClick += DataGridEditor_CellMouseClick;
            dgvEditor.ColumnAdded += DataGridEditor_ColumnAdded;
            dgvEditor.ColumnHeaderMouseClick += DataGridEditor_ColumnHeaderMouseClick;
            dgvEditor.RowHeaderMouseClick += DataGridEditor_RowHeaderMouseClick;
            dgvEditor.RowPostPaint += DataGridEditor_RowPostPaint;
            dgvEditor.KeyDown += DataGridEditor_KeyDown;
            dgvEditor.KeyPress += DataGridEditor_KeyPress;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TableEditorNewToolStripDropDownButton, TableEditorToolStripDropDownButton, TableEditorColumnToolStripDropDownButton });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1237, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // TableEditorNewToolStripDropDownButton
            // 
            TableEditorNewToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TableEditorNewToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { NewRowToolStripMenuItem, NewColumnToolStripMenuItem });
            TableEditorNewToolStripDropDownButton.Image = (Image)resources.GetObject("TableEditorNewToolStripDropDownButton.Image");
            TableEditorNewToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            TableEditorNewToolStripDropDownButton.Name = "TableEditorNewToolStripDropDownButton";
            TableEditorNewToolStripDropDownButton.Size = new Size(44, 22);
            TableEditorNewToolStripDropDownButton.Text = "New";
            // 
            // NewRowToolStripMenuItem
            // 
            NewRowToolStripMenuItem.Name = "NewRowToolStripMenuItem";
            NewRowToolStripMenuItem.Size = new Size(117, 22);
            NewRowToolStripMenuItem.Text = "Row";
            NewRowToolStripMenuItem.Click += NewRowToolStripMenuItem_Click;
            // 
            // NewColumnToolStripMenuItem
            // 
            NewColumnToolStripMenuItem.Name = "NewColumnToolStripMenuItem";
            NewColumnToolStripMenuItem.Size = new Size(117, 22);
            NewColumnToolStripMenuItem.Text = "Column";
            NewColumnToolStripMenuItem.Click += NewColumnToolStripMenuItem_Click;
            // 
            // TableEditorToolStripDropDownButton
            // 
            TableEditorToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TableEditorToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { TableEditorTrimToolStripMenuItem, TableEditorInsertGuidToolStripMenuItem });
            TableEditorToolStripDropDownButton.Image = (Image)resources.GetObject("TableEditorToolStripDropDownButton.Image");
            TableEditorToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            TableEditorToolStripDropDownButton.Name = "TableEditorToolStripDropDownButton";
            TableEditorToolStripDropDownButton.Size = new Size(40, 22);
            TableEditorToolStripDropDownButton.Text = "Edit";
            // 
            // TableEditorTrimToolStripMenuItem
            // 
            TableEditorTrimToolStripMenuItem.Name = "TableEditorTrimToolStripMenuItem";
            TableEditorTrimToolStripMenuItem.Size = new Size(131, 22);
            TableEditorTrimToolStripMenuItem.Text = "Trim";
            TableEditorTrimToolStripMenuItem.Click += TableEditorTrimToolStripMenuItem_Click;
            // 
            // TableEditorInsertGuidToolStripMenuItem
            // 
            TableEditorInsertGuidToolStripMenuItem.Name = "TableEditorInsertGuidToolStripMenuItem";
            TableEditorInsertGuidToolStripMenuItem.Size = new Size(131, 22);
            TableEditorInsertGuidToolStripMenuItem.Text = "Insert Guid";
            TableEditorInsertGuidToolStripMenuItem.Click += TableEditorInsertGuidToolStripMenuItem_Click;
            // 
            // TableEditorColumnToolStripDropDownButton
            // 
            TableEditorColumnToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TableEditorColumnToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { TableEditorAddColumnToolStripMenuItem, TableEditorDeleteColumnsToolStripMenuItem });
            TableEditorColumnToolStripDropDownButton.Image = (Image)resources.GetObject("TableEditorColumnToolStripDropDownButton.Image");
            TableEditorColumnToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            TableEditorColumnToolStripDropDownButton.Name = "TableEditorColumnToolStripDropDownButton";
            TableEditorColumnToolStripDropDownButton.Size = new Size(68, 22);
            TableEditorColumnToolStripDropDownButton.Text = "Columns";
            // 
            // TableEditorAddColumnToolStripMenuItem
            // 
            TableEditorAddColumnToolStripMenuItem.Name = "TableEditorAddColumnToolStripMenuItem";
            TableEditorAddColumnToolStripMenuItem.Size = new Size(158, 22);
            TableEditorAddColumnToolStripMenuItem.Text = "Add Column";
            TableEditorAddColumnToolStripMenuItem.Click += TableEditorAddColumnToolStripMenuItem_Click;
            // 
            // TableEditorDeleteColumnsToolStripMenuItem
            // 
            TableEditorDeleteColumnsToolStripMenuItem.Name = "TableEditorDeleteColumnsToolStripMenuItem";
            TableEditorDeleteColumnsToolStripMenuItem.Size = new Size(158, 22);
            TableEditorDeleteColumnsToolStripMenuItem.Text = "Delete Columns";
            TableEditorDeleteColumnsToolStripMenuItem.Click += TableEditorDeleteColumnsToolStripMenuItem_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(HttpClientSplitContainer);
            tabPage3.Controls.Add(toolStrip3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1243, 685);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "HTTP Client";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // HttpClientSplitContainer
            // 
            HttpClientSplitContainer.Dock = DockStyle.Fill;
            HttpClientSplitContainer.Location = new Point(3, 28);
            HttpClientSplitContainer.Name = "HttpClientSplitContainer";
            // 
            // HttpClientSplitContainer.Panel1
            // 
            HttpClientSplitContainer.Panel1.Controls.Add(txtRequest);
            // 
            // HttpClientSplitContainer.Panel2
            // 
            HttpClientSplitContainer.Panel2.Controls.Add(txtResponse);
            HttpClientSplitContainer.Size = new Size(1237, 654);
            HttpClientSplitContainer.SplitterDistance = 580;
            HttpClientSplitContainer.TabIndex = 0;
            // 
            // txtRequest
            // 
            txtRequest.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            txtRequest.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            txtRequest.AutoScrollMinSize = new Size(88, 15);
            txtRequest.BackBrush = null;
            txtRequest.BackColor = Color.FromArgb(20, 20, 20);
            txtRequest.CharHeight = 15;
            txtRequest.CharWidth = 7;
            txtRequest.Cursor = Cursors.IBeam;
            txtRequest.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            txtRequest.Dock = DockStyle.Fill;
            txtRequest.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRequest.ForeColor = Color.Gainsboro;
            txtRequest.IsReplaceMode = false;
            txtRequest.Location = new Point(0, 0);
            txtRequest.Name = "txtRequest";
            txtRequest.Paddings = new Padding(0);
            txtRequest.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            txtRequest.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("txtRequest.ServiceColors");
            txtRequest.Size = new Size(580, 654);
            txtRequest.TabIndex = 0;
            txtRequest.Text = "[Request]";
            txtRequest.Zoom = 100;
            txtRequest.TextChanged += txtRequest_TextChanged;
            // 
            // txtResponse
            // 
            txtResponse.AutoCompleteBracketsList = new char[]
    {
    '(',
    ')',
    '{',
    '}',
    '[',
    ']',
    '"',
    '"',
    '\'',
    '\''
    };
            txtResponse.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
            txtResponse.AutoScrollMinSize = new Size(95, 15);
            txtResponse.BackBrush = null;
            txtResponse.BackColor = Color.FromArgb(20, 20, 20);
            txtResponse.CharHeight = 15;
            txtResponse.CharWidth = 7;
            txtResponse.Cursor = Cursors.IBeam;
            txtResponse.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            txtResponse.Dock = DockStyle.Fill;
            txtResponse.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtResponse.ForeColor = Color.Gainsboro;
            txtResponse.IsReplaceMode = false;
            txtResponse.Location = new Point(0, 0);
            txtResponse.Name = "txtResponse";
            txtResponse.Paddings = new Padding(0);
            txtResponse.ReadOnly = true;
            txtResponse.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            txtResponse.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("txtResponse.ServiceColors");
            txtResponse.Size = new Size(653, 654);
            txtResponse.TabIndex = 0;
            txtResponse.Text = "[Response]";
            txtResponse.Zoom = 100;
            // 
            // toolStrip3
            // 
            toolStrip3.Items.AddRange(new ToolStripItem[] { HttpClientRequestToolStripDropDownButton, HttpClientSendToolStripButton });
            toolStrip3.Location = new Point(3, 3);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(1237, 25);
            toolStrip3.TabIndex = 1;
            toolStrip3.Text = "toolStrip3";
            // 
            // HttpClientRequestToolStripDropDownButton
            // 
            HttpClientRequestToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            HttpClientRequestToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { HttpClientNewRequestToolStripMenuItem, HtpClientSelectClientCertificateToolStripMenuItem });
            HttpClientRequestToolStripDropDownButton.Image = (Image)resources.GetObject("HttpClientRequestToolStripDropDownButton.Image");
            HttpClientRequestToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            HttpClientRequestToolStripDropDownButton.Name = "HttpClientRequestToolStripDropDownButton";
            HttpClientRequestToolStripDropDownButton.Size = new Size(62, 22);
            HttpClientRequestToolStripDropDownButton.Text = "Request";
            // 
            // HttpClientNewRequestToolStripMenuItem
            // 
            HttpClientNewRequestToolStripMenuItem.Name = "HttpClientNewRequestToolStripMenuItem";
            HttpClientNewRequestToolStripMenuItem.Size = new Size(205, 22);
            HttpClientNewRequestToolStripMenuItem.Text = "New";
            HttpClientNewRequestToolStripMenuItem.Click += HttpClientNewRequestToolStripMenuItem_Click;
            // 
            // HtpClientSelectClientCertificateToolStripMenuItem
            // 
            HtpClientSelectClientCertificateToolStripMenuItem.Name = "HtpClientSelectClientCertificateToolStripMenuItem";
            HtpClientSelectClientCertificateToolStripMenuItem.Size = new Size(205, 22);
            HtpClientSelectClientCertificateToolStripMenuItem.Text = "Select Client Certificate...";
            HtpClientSelectClientCertificateToolStripMenuItem.Click += HtpClientSelectClientCertificateToolStripMenuItem_Click;
            // 
            // HttpClientSendToolStripButton
            // 
            HttpClientSendToolStripButton.Image = (Image)resources.GetObject("HttpClientSendToolStripButton.Image");
            HttpClientSendToolStripButton.ImageTransparentColor = Color.Magenta;
            HttpClientSendToolStripButton.Name = "HttpClientSendToolStripButton";
            HttpClientSendToolStripButton.Size = new Size(53, 22);
            HttpClientSendToolStripButton.Text = "Send";
            HttpClientSendToolStripButton.Click += HttpClientSendToolStripButton_Click;
            // 
            // BackgroundWorker
            // 
            BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 737);
            Controls.Add(tabControl1);
            Controls.Add(MainMenuStrip);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "JtvDevTools";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            ((System.ComponentModel.ISupportInitialize)txtEditor).EndInit();
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditor).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            HttpClientSplitContainer.Panel1.ResumeLayout(false);
            HttpClientSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HttpClientSplitContainer).EndInit();
            HttpClientSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtRequest).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtResponse).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem FileToolStripMainMenuItem;
        private ToolStripMenuItem NewToolStripMenuItem;
        private ToolStripMenuItem ViewToolStripMainMenuItem;
        private ToolStripMenuItem SQLToolsToolStripMenuItem;
        internal FastColoredTextBoxNS.FastColoredTextBox txtEditor;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgvEditor;
        private SplitContainer HttpClientSplitContainer;
        private FastColoredTextBoxNS.FastColoredTextBox txtRequest;
        private FastColoredTextBoxNS.FastColoredTextBox txtResponse;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton TableEditorToolStripDropDownButton;
        private ToolStripMenuItem TableEditorTrimToolStripMenuItem;
        private ToolStripMenuItem TableEditorInsertGuidToolStripMenuItem;
        private ToolStripDropDownButton TableEditorNewToolStripDropDownButton;
        private ToolStripMenuItem NewRowToolStripMenuItem;
        private ToolStripMenuItem NewColumnToolStripMenuItem;
        private ToolStrip toolStrip2;
        private ToolStripDropDownButton TextEditorEditToolStripDropDownButton;
        private ToolStripButton TextEditorNewToolStripButton;
        private ToolStrip toolStrip3;
        private ToolStripDropDownButton TableEditorColumnToolStripDropDownButton;
        private ToolStripMenuItem TableEditorAddColumnToolStripMenuItem;
        private ToolStripMenuItem TableEditorDeleteColumnsToolStripMenuItem;
        private ToolStripDropDownButton HttpClientRequestToolStripDropDownButton;
        private ToolStripMenuItem HttpClientNewRequestToolStripMenuItem;
        private ToolStripButton HttpClientSendToolStripButton;
        private ToolStripMenuItem HtpClientSelectClientCertificateToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
    }
}

