namespace JtvDevTools.RestClient.UserControls
{
    partial class RequestUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestUserControl));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RequestBodySplitContainer = new System.Windows.Forms.SplitContainer();
            this.txtRequest = new FastColoredTextBoxNS.FastColoredTextBox();
            this.RequestContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertGuidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertFileToBase64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCertificateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRequestBody = new FastColoredTextBoxNS.FastColoredTextBox();
            this.txtResponse = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewRequest = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSendRequest = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.InsertVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestBodySplitContainer)).BeginInit();
            this.RequestBodySplitContainer.Panel1.SuspendLayout();
            this.RequestBodySplitContainer.Panel2.SuspendLayout();
            this.RequestBodySplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequest)).BeginInit();
            this.RequestContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponse)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RequestBodySplitContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtResponse);
            this.splitContainer1.Size = new System.Drawing.Size(961, 776);
            this.splitContainer1.SplitterDistance = 469;
            this.splitContainer1.TabIndex = 3;
            // 
            // RequestBodySplitContainer
            // 
            this.RequestBodySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestBodySplitContainer.Location = new System.Drawing.Point(0, 0);
            this.RequestBodySplitContainer.Name = "RequestBodySplitContainer";
            this.RequestBodySplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RequestBodySplitContainer.Panel1
            // 
            this.RequestBodySplitContainer.Panel1.Controls.Add(this.txtRequest);
            // 
            // RequestBodySplitContainer.Panel2
            // 
            this.RequestBodySplitContainer.Panel2.Controls.Add(this.txtRequestBody);
            this.RequestBodySplitContainer.Size = new System.Drawing.Size(469, 776);
            this.RequestBodySplitContainer.SplitterDistance = 388;
            this.RequestBodySplitContainer.TabIndex = 1;
            // 
            // txtRequest
            // 
            this.txtRequest.AutoCompleteBracketsList = new char[] {
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
            this.txtRequest.AutoScrollMinSize = new System.Drawing.Size(95, 15);
            this.txtRequest.BackBrush = null;
            this.txtRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtRequest.CharHeight = 15;
            this.txtRequest.CharWidth = 7;
            this.txtRequest.ContextMenuStrip = this.RequestContextMenuStrip;
            this.txtRequest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRequest.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequest.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtRequest.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRequest.IsReplaceMode = false;
            this.txtRequest.Location = new System.Drawing.Point(0, 0);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Paddings = new System.Windows.Forms.Padding(0);
            this.txtRequest.ReservedCountOfLineNumberChars = 2;
            this.txtRequest.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtRequest.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtRequest.ServiceColors")));
            this.txtRequest.Size = new System.Drawing.Size(469, 388);
            this.txtRequest.TabIndex = 0;
            this.txtRequest.Text = "[Request]";
            this.txtRequest.Zoom = 100;
            this.txtRequest.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.txtRequest_TextChanged);
            // 
            // RequestContextMenuStrip
            // 
            this.RequestContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertGuidToolStripMenuItem,
            this.insertFileToBase64ToolStripMenuItem,
            this.InsertVariableToolStripMenuItem,
            this.selectCertificateToolStripMenuItem});
            this.RequestContextMenuStrip.Name = "RequestContextMenuStrip";
            this.RequestContextMenuStrip.Size = new System.Drawing.Size(181, 114);
            // 
            // insertGuidToolStripMenuItem
            // 
            this.insertGuidToolStripMenuItem.Name = "insertGuidToolStripMenuItem";
            this.insertGuidToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertGuidToolStripMenuItem.Text = "Insert Guid";
            this.insertGuidToolStripMenuItem.Click += new System.EventHandler(this.insertGuidToolStripMenuItem_Click);
            // 
            // insertFileToBase64ToolStripMenuItem
            // 
            this.insertFileToBase64ToolStripMenuItem.Name = "insertFileToBase64ToolStripMenuItem";
            this.insertFileToBase64ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertFileToBase64ToolStripMenuItem.Text = "Insert File to Base64";
            this.insertFileToBase64ToolStripMenuItem.Click += new System.EventHandler(this.insertFileToBase64ToolStripMenuItem_Click);
            // 
            // selectCertificateToolStripMenuItem
            // 
            this.selectCertificateToolStripMenuItem.Name = "selectCertificateToolStripMenuItem";
            this.selectCertificateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectCertificateToolStripMenuItem.Text = "Select Certificate";
            this.selectCertificateToolStripMenuItem.Click += new System.EventHandler(this.selectCertificateToolStripMenuItem_Click);
            // 
            // txtRequestBody
            // 
            this.txtRequestBody.AutoCompleteBracketsList = new char[] {
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
            this.txtRequestBody.AutoScrollMinSize = new System.Drawing.Size(32, 15);
            this.txtRequestBody.BackBrush = null;
            this.txtRequestBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtRequestBody.CharHeight = 15;
            this.txtRequestBody.CharWidth = 7;
            this.txtRequestBody.ContextMenuStrip = this.RequestContextMenuStrip;
            this.txtRequestBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRequestBody.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtRequestBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestBody.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtRequestBody.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtRequestBody.IsReplaceMode = false;
            this.txtRequestBody.Location = new System.Drawing.Point(0, 0);
            this.txtRequestBody.Name = "txtRequestBody";
            this.txtRequestBody.Paddings = new System.Windows.Forms.Padding(0);
            this.txtRequestBody.ReservedCountOfLineNumberChars = 2;
            this.txtRequestBody.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtRequestBody.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtRequestBody.ServiceColors")));
            this.txtRequestBody.Size = new System.Drawing.Size(469, 384);
            this.txtRequestBody.TabIndex = 1;
            this.txtRequestBody.Zoom = 100;
            // 
            // txtResponse
            // 
            this.txtResponse.AutoCompleteBracketsList = new char[] {
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
            this.txtResponse.AutoScrollMinSize = new System.Drawing.Size(95, 15);
            this.txtResponse.BackBrush = null;
            this.txtResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtResponse.CharHeight = 15;
            this.txtResponse.CharWidth = 7;
            this.txtResponse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResponse.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponse.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.txtResponse.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtResponse.IsReplaceMode = false;
            this.txtResponse.Location = new System.Drawing.Point(0, 0);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Paddings = new System.Windows.Forms.Padding(0);
            this.txtResponse.ReadOnly = true;
            this.txtResponse.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtResponse.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtResponse.ServiceColors")));
            this.txtResponse.Size = new System.Drawing.Size(488, 776);
            this.txtResponse.TabIndex = 0;
            this.txtResponse.Text = "[Response]";
            this.txtResponse.Zoom = 100;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewRequest,
            this.SaveToolStripButton,
            this.toolStripSeparator1,
            this.btnSendRequest,
            this.CloseButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(961, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewRequest
            // 
            this.NewRequest.Image = ((System.Drawing.Image)(resources.GetObject("NewRequest.Image")));
            this.NewRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewRequest.Name = "NewRequest";
            this.NewRequest.Size = new System.Drawing.Size(51, 22);
            this.NewRequest.Text = "New";
            this.NewRequest.Click += new System.EventHandler(this.NewRequest_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.SaveToolStripButton.Text = "Save";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnSendRequest.Image")));
            this.btnSendRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(53, 22);
            this.btnSendRequest.Text = "Send";
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CloseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 22);
            this.CloseButton.Text = "toolStripButton1";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // InsertVariableToolStripMenuItem
            // 
            this.InsertVariableToolStripMenuItem.Name = "InsertVariableToolStripMenuItem";
            this.InsertVariableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.InsertVariableToolStripMenuItem.Text = "Insert Variable";
            this.InsertVariableToolStripMenuItem.Click += new System.EventHandler(this.InsertVariableToolStripMenuItem_Click);
            // 
            // RequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RequestUserControl";
            this.Size = new System.Drawing.Size(961, 801);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.RequestBodySplitContainer.Panel1.ResumeLayout(false);
            this.RequestBodySplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RequestBodySplitContainer)).EndInit();
            this.RequestBodySplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRequest)).EndInit();
            this.RequestContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResponse)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer RequestBodySplitContainer;
        private FastColoredTextBoxNS.FastColoredTextBox txtRequest;
        private FastColoredTextBoxNS.FastColoredTextBox txtRequestBody;
        private FastColoredTextBoxNS.FastColoredTextBox txtResponse;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSendRequest;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.ContextMenuStrip RequestContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem insertGuidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertFileToBase64ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCertificateToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton NewRequest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem InsertVariableToolStripMenuItem;
    }
}
