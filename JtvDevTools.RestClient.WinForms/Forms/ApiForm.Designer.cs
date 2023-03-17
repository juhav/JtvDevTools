namespace JtvDevTools.RestClient.WinForms
{
    partial class ApiForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvScopes = new System.Windows.Forms.DataGridView();
            this.ScopeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.VariableNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScopes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Name:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Description:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 41);
            this.txtName.MaxLength = 60;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(464, 23);
            this.txtName.TabIndex = 21;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(107, 71);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(464, 23);
            this.txtDescription.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(107, 12);
            this.IdTextBox.MaxLength = 50;
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(292, 23);
            this.IdTextBox.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(470, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 29);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(353, 553);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 29);
            this.btnOK.TabIndex = 26;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // dgvScopes
            // 
            this.dgvScopes.AllowUserToResizeRows = false;
            this.dgvScopes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScopes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScopeColumn});
            this.dgvScopes.Location = new System.Drawing.Point(12, 128);
            this.dgvScopes.Name = "dgvScopes";
            this.dgvScopes.RowHeadersVisible = false;
            this.dgvScopes.RowTemplate.Height = 25;
            this.dgvScopes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScopes.ShowCellToolTips = false;
            this.dgvScopes.Size = new System.Drawing.Size(559, 163);
            this.dgvScopes.TabIndex = 27;
            // 
            // ScopeColumn
            // 
            this.ScopeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ScopeColumn.DataPropertyName = "Name";
            this.ScopeColumn.HeaderText = "Scope";
            this.ScopeColumn.MaxInputLength = 50;
            this.ScopeColumn.Name = "ScopeColumn";
            this.ScopeColumn.Width = 250;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Scopes / Environments:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvVariables
            // 
            this.dgvVariables.AllowUserToResizeRows = false;
            this.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VariableNameColumn,
            this.VariableValueColumn});
            this.dgvVariables.Location = new System.Drawing.Point(12, 326);
            this.dgvVariables.MultiSelect = false;
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.RowHeadersVisible = false;
            this.dgvVariables.RowTemplate.Height = 25;
            this.dgvVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVariables.ShowCellToolTips = false;
            this.dgvVariables.Size = new System.Drawing.Size(559, 201);
            this.dgvVariables.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Variables:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VariableNameColumn
            // 
            this.VariableNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VariableNameColumn.HeaderText = "Name";
            this.VariableNameColumn.MinimumWidth = 50;
            this.VariableNameColumn.Name = "VariableNameColumn";
            this.VariableNameColumn.Width = 250;
            // 
            // VariableValueColumn
            // 
            this.VariableValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VariableValueColumn.HeaderText = "Value";
            this.VariableValueColumn.Name = "VariableValueColumn";
            this.VariableValueColumn.Width = 250;
            // 
            // ApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvVariables);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvScopes);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "API";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScopes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Label label1;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label label2;
        private TextBox IdTextBox;
        private Button btnCancel;
        private Button btnOK;
        private DataGridView dgvScopes;
        private Label label3;
        private DataGridViewTextBoxColumn ScopeColumn;
        private DataGridView dgvVariables;
        private DataGridViewTextBoxColumn VariableNameColumn;
        private DataGridViewTextBoxColumn VariableValueColumn;
        private Label label4;
    }
}