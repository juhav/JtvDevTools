namespace JtvDevTools.RestClient.WinForms.Forms
{
    partial class RequestResponseForm
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
            JtvDevTools.RestClient.WinForms.ViewModels.HttpRequestViewModel httpRequestViewModel2 = new JtvDevTools.RestClient.WinForms.ViewModels.HttpRequestViewModel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestResponseForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.httpRequestUserControl1 = new JtvDevTools.RestClient.WinForms.UserControls.HttpRequestUserControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.httpRequestUserControl1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(1230, 837);
            this.splitContainer1.SplitterDistance = 553;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // httpRequestUserControl1
            // 
            this.httpRequestUserControl1.BackColor = System.Drawing.SystemColors.Control;
            this.httpRequestUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.httpRequestUserControl1.Location = new System.Drawing.Point(0, 25);
            this.httpRequestUserControl1.Name = "httpRequestUserControl1";
            this.httpRequestUserControl1.Padding = new System.Windows.Forms.Padding(4);
            this.httpRequestUserControl1.Size = new System.Drawing.Size(553, 812);
            this.httpRequestUserControl1.TabIndex = 1;
            httpRequestViewModel2.ApiName = null;
            httpRequestViewModel2.Authentication = JtvDevTools.RestClient.WinForms.Models.AuthenticationType.None;
            httpRequestViewModel2.BaseURL = null;
            httpRequestViewModel2.Body = null;
            httpRequestViewModel2.ClientCertificate = null;
            httpRequestViewModel2.Id = new System.Guid("42a9b0b0-0ffb-41ea-94a5-a6beffa340a4");
            httpRequestViewModel2.Method = JtvDevTools.RestClient.WinForms.Models.HttpMethod.GET;
            httpRequestViewModel2.Name = null;
            httpRequestViewModel2.Resource = null;
            this.httpRequestUserControl1.ViewModel = httpRequestViewModel2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(553, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(671, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton1.Text = "Execute";
            // 
            // RequestResponseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 837);
            this.Controls.Add(this.splitContainer1);
            this.Name = "RequestResponseForm";
            this.Text = "REST Client";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ToolStrip toolStrip1;
        private ToolStrip toolStrip2;
        private UserControls.HttpRequestUserControl httpRequestUserControl1;
        private ToolStripButton toolStripButton1;
    }
}