
namespace JtvDevTools
{
    partial class EditorUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorUserControl));
            this.txtEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.EditorContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGuidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatXLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrimLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmptyLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Base64EncodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Base64DecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SqlInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SqlInStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrependToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppendPrependToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor)).BeginInit();
            this.EditorContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.txtEditor.AutoScrollMinSize = new System.Drawing.Size(25, 15);
            this.txtEditor.BackBrush = null;
            this.txtEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtEditor.CaretColor = System.Drawing.Color.WhiteSmoke;
            this.txtEditor.CharHeight = 15;
            this.txtEditor.CharWidth = 7;
            this.txtEditor.ContextMenuStrip = this.EditorContextMenuStrip;
            this.txtEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtEditor.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtEditor.IsReplaceMode = false;
            this.txtEditor.Location = new System.Drawing.Point(0, 0);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.txtEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtEditor.ServiceColors")));
            this.txtEditor.Size = new System.Drawing.Size(588, 374);
            this.txtEditor.TabIndex = 4;
            this.txtEditor.Zoom = 100;
            // 
            // EditorContextMenuStrip
            // 
            this.EditorContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.base64ToolStripMenuItem,
            this.sQLToolStripMenuItem});
            this.EditorContextMenuStrip.Name = "EditorContextMenuStrip";
            this.EditorContextMenuStrip.Size = new System.Drawing.Size(181, 114);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGuidToolStripMenuItem,
            this.AppendToolStripMenuItem,
            this.PrependToolStripMenuItem,
            this.AppendPrependToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // NewGuidToolStripMenuItem
            // 
            this.NewGuidToolStripMenuItem.Name = "NewGuidToolStripMenuItem";
            this.NewGuidToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewGuidToolStripMenuItem.Text = "New Guid";
            this.NewGuidToolStripMenuItem.Click += new System.EventHandler(this.NewGuidToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatJsonToolStripMenuItem,
            this.FormatXLToolStripMenuItem,
            this.TrimLinesToolStripMenuItem,
            this.removeEmptyLinesToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // FormatJsonToolStripMenuItem
            // 
            this.FormatJsonToolStripMenuItem.Name = "FormatJsonToolStripMenuItem";
            this.FormatJsonToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.FormatJsonToolStripMenuItem.Text = "Json";
            this.FormatJsonToolStripMenuItem.Click += new System.EventHandler(this.FormatJsonToolStripMenuItem_Click);
            // 
            // FormatXLToolStripMenuItem
            // 
            this.FormatXLToolStripMenuItem.Name = "FormatXLToolStripMenuItem";
            this.FormatXLToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.FormatXLToolStripMenuItem.Text = "XML";
            // 
            // TrimLinesToolStripMenuItem
            // 
            this.TrimLinesToolStripMenuItem.Name = "TrimLinesToolStripMenuItem";
            this.TrimLinesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.TrimLinesToolStripMenuItem.Text = "Trim lines";
            this.TrimLinesToolStripMenuItem.Click += new System.EventHandler(this.TrimLinesToolStripMenuItem_Click);
            // 
            // removeEmptyLinesToolStripMenuItem
            // 
            this.removeEmptyLinesToolStripMenuItem.Name = "removeEmptyLinesToolStripMenuItem";
            this.removeEmptyLinesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.removeEmptyLinesToolStripMenuItem.Text = "Remove empty lines";
            this.removeEmptyLinesToolStripMenuItem.Click += new System.EventHandler(this.removeEmptyLinesToolStripMenuItem_Click);
            // 
            // base64ToolStripMenuItem
            // 
            this.base64ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Base64EncodeToolStripMenuItem,
            this.Base64DecodeToolStripMenuItem});
            this.base64ToolStripMenuItem.Name = "base64ToolStripMenuItem";
            this.base64ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base64ToolStripMenuItem.Text = "Base64";
            // 
            // Base64EncodeToolStripMenuItem
            // 
            this.Base64EncodeToolStripMenuItem.Name = "Base64EncodeToolStripMenuItem";
            this.Base64EncodeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.Base64EncodeToolStripMenuItem.Text = "Encode";
            this.Base64EncodeToolStripMenuItem.Click += new System.EventHandler(this.Base64EncodeToolStripMenuItem_Click);
            // 
            // Base64DecodeToolStripMenuItem
            // 
            this.Base64DecodeToolStripMenuItem.Name = "Base64DecodeToolStripMenuItem";
            this.Base64DecodeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.Base64DecodeToolStripMenuItem.Text = "Decode";
            this.Base64DecodeToolStripMenuItem.Click += new System.EventHandler(this.Base64DecodeToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SqlInToolStripMenuItem,
            this.SqlInStringToolStripMenuItem});
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sQLToolStripMenuItem.Text = "SQL";
            // 
            // SqlInToolStripMenuItem
            // 
            this.SqlInToolStripMenuItem.Name = "SqlInToolStripMenuItem";
            this.SqlInToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.SqlInToolStripMenuItem.Text = "in (1,2,3)";
            this.SqlInToolStripMenuItem.Click += new System.EventHandler(this.SqlInToolStripMenuItem_Click);
            // 
            // SqlInStringToolStripMenuItem
            // 
            this.SqlInStringToolStripMenuItem.Name = "SqlInStringToolStripMenuItem";
            this.SqlInStringToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.SqlInStringToolStripMenuItem.Text = "in (\'1\', \'2\', \'3\')";
            this.SqlInStringToolStripMenuItem.Click += new System.EventHandler(this.SqlInStringToolStripMenuItem_Click);
            // 
            // AppendToolStripMenuItem
            // 
            this.AppendToolStripMenuItem.Name = "AppendToolStripMenuItem";
            this.AppendToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AppendToolStripMenuItem.Text = "Append";
            this.AppendToolStripMenuItem.Click += new System.EventHandler(this.AppendToolStripMenuItem_Click);
            // 
            // PrependToolStripMenuItem
            // 
            this.PrependToolStripMenuItem.Name = "PrependToolStripMenuItem";
            this.PrependToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PrependToolStripMenuItem.Text = "Prepend";
            this.PrependToolStripMenuItem.Click += new System.EventHandler(this.PrependToolStripMenuItem_Click);
            // 
            // AppendPrependToolStripMenuItem
            // 
            this.AppendPrependToolStripMenuItem.Name = "AppendPrependToolStripMenuItem";
            this.AppendPrependToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AppendPrependToolStripMenuItem.Text = "Append+Prepend";
            this.AppendPrependToolStripMenuItem.Click += new System.EventHandler(this.AppendPrependToolStripMenuItem_Click);
            // 
            // EditorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEditor);
            this.Name = "EditorUserControl";
            this.Size = new System.Drawing.Size(588, 374);
            ((System.ComponentModel.ISupportInitialize)(this.txtEditor)).EndInit();
            this.EditorContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox txtEditor;
        private System.Windows.Forms.ContextMenuStrip EditorContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGuidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatXLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrimLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmptyLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base64ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Base64EncodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Base64DecodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SqlInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SqlInStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrependToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppendPrependToolStripMenuItem;
    }
}
