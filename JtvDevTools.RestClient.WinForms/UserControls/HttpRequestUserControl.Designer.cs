namespace JtvDevTools.RestClient.WinForms.UserControls
{
    partial class HttpRequestUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MethodComboBox = new System.Windows.Forms.ComboBox();
            this.BaseUrlComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthenticationComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientCertificateTextBox = new System.Windows.Forms.TextBox();
            this.SelectClientCertButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRequestName = new System.Windows.Forms.TextBox();
            this.ResourceTextBox = new System.Windows.Forms.TextBox();
            this.RequestBodyTextBox = new System.Windows.Forms.TextBox();
            this.dgvHeaders = new System.Windows.Forms.DataGridView();
            this.HeaderNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQueryParams = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtApiName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryParams)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base URL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Method:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MethodComboBox
            // 
            this.MethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodComboBox.FormattingEnabled = true;
            this.MethodComboBox.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "PATCH",
            "HEAD",
            "CONNECT",
            "OPTIONS",
            "TRACE"});
            this.MethodComboBox.Location = new System.Drawing.Point(119, 93);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(154, 23);
            this.MethodComboBox.TabIndex = 2;
            // 
            // BaseUrlComboBox
            // 
            this.BaseUrlComboBox.FormattingEnabled = true;
            this.BaseUrlComboBox.Location = new System.Drawing.Point(119, 122);
            this.BaseUrlComboBox.Name = "BaseUrlComboBox";
            this.BaseUrlComboBox.Size = new System.Drawing.Size(326, 23);
            this.BaseUrlComboBox.TabIndex = 3;
            this.BaseUrlComboBox.TextChanged += new System.EventHandler(this.BaseUrlComboBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resource:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Authentication:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AuthenticationComboBox
            // 
            this.AuthenticationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthenticationComboBox.FormattingEnabled = true;
            this.AuthenticationComboBox.Items.AddRange(new object[] {
            "None",
            "Basic",
            "Windows with Default Credentials",
            "Windows"});
            this.AuthenticationComboBox.Location = new System.Drawing.Point(119, 180);
            this.AuthenticationComboBox.Name = "AuthenticationComboBox";
            this.AuthenticationComboBox.Size = new System.Drawing.Size(326, 23);
            this.AuthenticationComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client Certificate:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientCertificateTextBox
            // 
            this.ClientCertificateTextBox.Location = new System.Drawing.Point(119, 209);
            this.ClientCertificateTextBox.MaxLength = 50;
            this.ClientCertificateTextBox.Name = "ClientCertificateTextBox";
            this.ClientCertificateTextBox.Size = new System.Drawing.Size(277, 23);
            this.ClientCertificateTextBox.TabIndex = 11;
            // 
            // SelectClientCertButton
            // 
            this.SelectClientCertButton.Location = new System.Drawing.Point(402, 209);
            this.SelectClientCertButton.Name = "SelectClientCertButton";
            this.SelectClientCertButton.Size = new System.Drawing.Size(43, 23);
            this.SelectClientCertButton.TabIndex = 12;
            this.SelectClientCertButton.Text = "...";
            this.SelectClientCertButton.UseVisualStyleBackColor = true;
            this.SelectClientCertButton.Click += new System.EventHandler(this.SelectClientCertButton_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(7, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Request Name:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(7, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "API:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRequestName
            // 
            this.txtRequestName.Location = new System.Drawing.Point(119, 36);
            this.txtRequestName.MaxLength = 50;
            this.txtRequestName.Name = "txtRequestName";
            this.txtRequestName.Size = new System.Drawing.Size(326, 23);
            this.txtRequestName.TabIndex = 20;
            // 
            // ResourceTextBox
            // 
            this.ResourceTextBox.Location = new System.Drawing.Point(119, 151);
            this.ResourceTextBox.MaxLength = 50;
            this.ResourceTextBox.Name = "ResourceTextBox";
            this.ResourceTextBox.Size = new System.Drawing.Size(326, 23);
            this.ResourceTextBox.TabIndex = 23;
            // 
            // RequestBodyTextBox
            // 
            this.RequestBodyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestBodyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.RequestBodyTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RequestBodyTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.RequestBodyTextBox.Location = new System.Drawing.Point(7, 635);
            this.RequestBodyTextBox.Multiline = true;
            this.RequestBodyTextBox.Name = "RequestBodyTextBox";
            this.RequestBodyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RequestBodyTextBox.Size = new System.Drawing.Size(448, 273);
            this.RequestBodyTextBox.TabIndex = 25;
            // 
            // dgvHeaders
            // 
            this.dgvHeaders.AllowUserToResizeRows = false;
            this.dgvHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHeaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvHeaders.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HeaderNameColumn,
            this.HeaderValueColumn});
            this.dgvHeaders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvHeaders.Location = new System.Drawing.Point(7, 271);
            this.dgvHeaders.Name = "dgvHeaders";
            this.dgvHeaders.RowHeadersVisible = false;
            this.dgvHeaders.RowTemplate.Height = 25;
            this.dgvHeaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHeaders.ShowCellToolTips = false;
            this.dgvHeaders.Size = new System.Drawing.Size(448, 135);
            this.dgvHeaders.TabIndex = 1;
            // 
            // HeaderNameColumn
            // 
            this.HeaderNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HeaderNameColumn.DataPropertyName = "Name";
            this.HeaderNameColumn.HeaderText = "Name";
            this.HeaderNameColumn.MaxInputLength = 100;
            this.HeaderNameColumn.Name = "HeaderNameColumn";
            this.HeaderNameColumn.Width = 200;
            // 
            // HeaderValueColumn
            // 
            this.HeaderValueColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HeaderValueColumn.DataPropertyName = "Value";
            this.HeaderValueColumn.HeaderText = "Value";
            this.HeaderValueColumn.MaxInputLength = 4096;
            this.HeaderValueColumn.Name = "HeaderValueColumn";
            this.HeaderValueColumn.Width = 200;
            // 
            // dgvQueryParams
            // 
            this.dgvQueryParams.AllowUserToResizeRows = false;
            this.dgvQueryParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQueryParams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvQueryParams.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvQueryParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvQueryParams.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvQueryParams.Location = new System.Drawing.Point(7, 441);
            this.dgvQueryParams.Name = "dgvQueryParams";
            this.dgvQueryParams.RowHeadersVisible = false;
            this.dgvQueryParams.RowTemplate.Height = 25;
            this.dgvQueryParams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueryParams.ShowCellToolTips = false;
            this.dgvQueryParams.Size = new System.Drawing.Size(448, 159);
            this.dgvQueryParams.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 4096;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(448, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "HEADERS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(7, 412);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(448, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "QUERY PARAMETERS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.LightGray;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(7, 606);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(448, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "BODY";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.BackColor = System.Drawing.Color.LightGray;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(7, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(448, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "REQUEST";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApiName
            // 
            this.txtApiName.Location = new System.Drawing.Point(119, 64);
            this.txtApiName.MaxLength = 50;
            this.txtApiName.Name = "txtApiName";
            this.txtApiName.Size = new System.Drawing.Size(326, 23);
            this.txtApiName.TabIndex = 30;
            // 
            // HttpRequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txtApiName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RequestBodyTextBox);
            this.Controls.Add(this.dgvQueryParams);
            this.Controls.Add(this.dgvHeaders);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AuthenticationComboBox);
            this.Controls.Add(this.SelectClientCertButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientCertificateTextBox);
            this.Controls.Add(this.ResourceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MethodComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRequestName);
            this.Controls.Add(this.BaseUrlComboBox);
            this.Name = "HttpRequestUserControl";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(462, 915);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryParams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox MethodComboBox;
        private ComboBox BaseUrlComboBox;
        private Label label3;
        private Label label4;
        private ComboBox AuthenticationComboBox;
        private Label label5;
        private TextBox ClientCertificateTextBox;
        private Button SelectClientCertButton;
        private Label label9;
        private Label label10;
        private TextBox txtRequestName;
        private TextBox ResourceTextBox;
        private TextBox RequestBodyTextBox;
        private DataGridView dgvHeaders;
        private DataGridViewTextBoxColumn HeaderNameColumn;
        private DataGridViewTextBoxColumn HeaderValueColumn;
        private DataGridView dgvQueryParams;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label11;
        private TextBox txtApiName;
    }
}
