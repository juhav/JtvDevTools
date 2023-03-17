namespace JtvDevTools.RestClient.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewHTTPRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.RequestsTabPage = new System.Windows.Forms.TabPage();
            this.RequestsDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.btnNewRequest = new System.Windows.Forms.ToolStripButton();
            this.btnEditRequest = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteRequest = new System.Windows.Forms.ToolStripButton();
            this.VariablesTabPage = new System.Windows.Forms.TabPage();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnNewVariable = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteVariable = new System.Windows.Forms.ToolStripButton();
            this.MainMenuStrip.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.RequestsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsDataGridView)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.VariablesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMainMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMainMenuItem
            // 
            this.FileToolStripMainMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewHTTPRequestToolStripMenuItem});
            this.FileToolStripMainMenuItem.Name = "FileToolStripMainMenuItem";
            this.FileToolStripMainMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMainMenuItem.Text = "File";
            // 
            // NewHTTPRequestToolStripMenuItem
            // 
            this.NewHTTPRequestToolStripMenuItem.Name = "NewHTTPRequestToolStripMenuItem";
            this.NewHTTPRequestToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.NewHTTPRequestToolStripMenuItem.Text = "New HTTP Request";
            this.NewHTTPRequestToolStripMenuItem.Click += new System.EventHandler(this.NewHTTPRequestToolStripMenuItem_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.RequestsTabPage);
            this.MainTabControl.Controls.Add(this.VariablesTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(800, 426);
            this.MainTabControl.TabIndex = 1;
            // 
            // RequestsTabPage
            // 
            this.RequestsTabPage.Controls.Add(this.RequestsDataGridView);
            this.RequestsTabPage.Controls.Add(this.toolStrip2);
            this.RequestsTabPage.Location = new System.Drawing.Point(4, 24);
            this.RequestsTabPage.Name = "RequestsTabPage";
            this.RequestsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RequestsTabPage.Size = new System.Drawing.Size(792, 398);
            this.RequestsTabPage.TabIndex = 0;
            this.RequestsTabPage.Text = "Requests";
            this.RequestsTabPage.UseVisualStyleBackColor = true;
            // 
            // RequestsDataGridView
            // 
            this.RequestsDataGridView.AllowUserToAddRows = false;
            this.RequestsDataGridView.AllowUserToDeleteRows = false;
            this.RequestsDataGridView.AllowUserToOrderColumns = true;
            this.RequestsDataGridView.AllowUserToResizeRows = false;
            this.RequestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestsDataGridView.Location = new System.Drawing.Point(3, 28);
            this.RequestsDataGridView.MultiSelect = false;
            this.RequestsDataGridView.Name = "RequestsDataGridView";
            this.RequestsDataGridView.ReadOnly = true;
            this.RequestsDataGridView.RowHeadersVisible = false;
            this.RequestsDataGridView.RowTemplate.Height = 25;
            this.RequestsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RequestsDataGridView.ShowCellToolTips = false;
            this.RequestsDataGridView.Size = new System.Drawing.Size(786, 367);
            this.RequestsDataGridView.TabIndex = 0;
            this.RequestsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RequestsDataGridView_CellFormatting);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.btnNewRequest,
            this.btnEditRequest,
            this.btnDeleteRequest});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(786, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabel1.Text = "API:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRequest.Image")));
            this.btnNewRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(51, 22);
            this.btnNewRequest.Text = "New";
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            // 
            // btnEditRequest
            // 
            this.btnEditRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRequest.Image")));
            this.btnEditRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditRequest.Name = "btnEditRequest";
            this.btnEditRequest.Size = new System.Drawing.Size(47, 22);
            this.btnEditRequest.Text = "Edit";
            this.btnEditRequest.Click += new System.EventHandler(this.btnEditRequest_Click);
            // 
            // btnDeleteRequest
            // 
            this.btnDeleteRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRequest.Image")));
            this.btnDeleteRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.Size = new System.Drawing.Size(60, 22);
            this.btnDeleteRequest.Text = "Delete";
            this.btnDeleteRequest.Click += new System.EventHandler(this.btnDeleteRequest_Click);
            // 
            // VariablesTabPage
            // 
            this.VariablesTabPage.Controls.Add(this.dgvVariables);
            this.VariablesTabPage.Controls.Add(this.toolStrip3);
            this.VariablesTabPage.Location = new System.Drawing.Point(4, 24);
            this.VariablesTabPage.Name = "VariablesTabPage";
            this.VariablesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VariablesTabPage.Size = new System.Drawing.Size(792, 398);
            this.VariablesTabPage.TabIndex = 2;
            this.VariablesTabPage.Text = "Variables";
            this.VariablesTabPage.UseVisualStyleBackColor = true;
            // 
            // dgvVariables
            // 
            this.dgvVariables.AllowUserToAddRows = false;
            this.dgvVariables.AllowUserToDeleteRows = false;
            this.dgvVariables.AllowUserToResizeRows = false;
            this.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVariables.Location = new System.Drawing.Point(3, 28);
            this.dgvVariables.MultiSelect = false;
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.ReadOnly = true;
            this.dgvVariables.RowHeadersVisible = false;
            this.dgvVariables.RowTemplate.Height = 25;
            this.dgvVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVariables.ShowCellToolTips = false;
            this.dgvVariables.Size = new System.Drawing.Size(786, 367);
            this.dgvVariables.TabIndex = 1;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewVariable,
            this.btnDeleteVariable});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(786, 25);
            this.toolStrip3.TabIndex = 2;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnNewVariable
            // 
            this.btnNewVariable.Image = ((System.Drawing.Image)(resources.GetObject("btnNewVariable.Image")));
            this.btnNewVariable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewVariable.Name = "btnNewVariable";
            this.btnNewVariable.Size = new System.Drawing.Size(51, 22);
            this.btnNewVariable.Text = "New";
            this.btnNewVariable.Click += new System.EventHandler(this.btnNewVariable_Click);
            // 
            // btnDeleteVariable
            // 
            this.btnDeleteVariable.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteVariable.Image")));
            this.btnDeleteVariable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteVariable.Name = "btnDeleteVariable";
            this.btnDeleteVariable.Size = new System.Drawing.Size(60, 22);
            this.btnDeleteVariable.Text = "Delete";
            this.btnDeleteVariable.Click += new System.EventHandler(this.btnDeleteVariable_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainForm";
            this.Text = "HTTP Client";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.RequestsTabPage.ResumeLayout(false);
            this.RequestsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsDataGridView)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.VariablesTabPage.ResumeLayout(false);
            this.VariablesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem FileToolStripMainMenuItem;
        private ToolStripMenuItem NewHTTPRequestToolStripMenuItem;
        private TabControl MainTabControl;
        private TabPage RequestsTabPage;
        private DataGridView RequestsDataGridView;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripButton btnNewRequest;
        private ToolStripButton btnDeleteRequest;
        private ToolStripButton btnEditRequest;
        private TabPage VariablesTabPage;
        private DataGridView dgvVariables;
        private ToolStrip toolStrip3;
        private ToolStripButton btnNewVariable;
        private ToolStripButton btnDeleteVariable;
    }
}