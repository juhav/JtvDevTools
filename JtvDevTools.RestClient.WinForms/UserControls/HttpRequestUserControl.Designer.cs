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
            this.HeadersTextBox = new System.Windows.Forms.TextBox();
            this.QueryParamsTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.cboApi = new System.Windows.Forms.ComboBox();
            this.ApiBrowserButton = new System.Windows.Forms.Button();
            this.ResourceTextBox = new System.Windows.Forms.TextBox();
            this.RequestBodyTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base URL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 64);
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
            this.MethodComboBox.Location = new System.Drawing.Point(122, 64);
            this.MethodComboBox.Name = "MethodComboBox";
            this.MethodComboBox.Size = new System.Drawing.Size(154, 23);
            this.MethodComboBox.TabIndex = 2;
            // 
            // BaseUrlComboBox
            // 
            this.BaseUrlComboBox.FormattingEnabled = true;
            this.BaseUrlComboBox.Location = new System.Drawing.Point(122, 93);
            this.BaseUrlComboBox.Name = "BaseUrlComboBox";
            this.BaseUrlComboBox.Size = new System.Drawing.Size(326, 23);
            this.BaseUrlComboBox.TabIndex = 3;
            this.BaseUrlComboBox.TextChanged += new System.EventHandler(this.BaseUrlComboBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resource:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 151);
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
            this.AuthenticationComboBox.Location = new System.Drawing.Point(122, 151);
            this.AuthenticationComboBox.Name = "AuthenticationComboBox";
            this.AuthenticationComboBox.Size = new System.Drawing.Size(326, 23);
            this.AuthenticationComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Client Certificate:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClientCertificateTextBox
            // 
            this.ClientCertificateTextBox.Location = new System.Drawing.Point(122, 180);
            this.ClientCertificateTextBox.MaxLength = 50;
            this.ClientCertificateTextBox.Name = "ClientCertificateTextBox";
            this.ClientCertificateTextBox.Size = new System.Drawing.Size(277, 23);
            this.ClientCertificateTextBox.TabIndex = 11;
            // 
            // SelectClientCertButton
            // 
            this.SelectClientCertButton.Location = new System.Drawing.Point(405, 180);
            this.SelectClientCertButton.Name = "SelectClientCertButton";
            this.SelectClientCertButton.Size = new System.Drawing.Size(43, 23);
            this.SelectClientCertButton.TabIndex = 12;
            this.SelectClientCertButton.Text = "...";
            this.SelectClientCertButton.UseVisualStyleBackColor = true;
            this.SelectClientCertButton.Click += new System.EventHandler(this.SelectClientCertButton_Click);
            // 
            // HeadersTextBox
            // 
            this.HeadersTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.HeadersTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeadersTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeadersTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.HeadersTextBox.Location = new System.Drawing.Point(3, 3);
            this.HeadersTextBox.Multiline = true;
            this.HeadersTextBox.Name = "HeadersTextBox";
            this.HeadersTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HeadersTextBox.Size = new System.Drawing.Size(462, 355);
            this.HeadersTextBox.TabIndex = 14;
            // 
            // QueryParamsTextBox
            // 
            this.QueryParamsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueryParamsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryParamsTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QueryParamsTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.QueryParamsTextBox.Location = new System.Drawing.Point(3, 3);
            this.QueryParamsTextBox.Multiline = true;
            this.QueryParamsTextBox.Name = "QueryParamsTextBox";
            this.QueryParamsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.QueryParamsTextBox.Size = new System.Drawing.Size(462, 355);
            this.QueryParamsTextBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Name:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 35);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "API:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(122, 6);
            this.NameTextBox.MaxLength = 50;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(326, 23);
            this.NameTextBox.TabIndex = 20;
            // 
            // cboApi
            // 
            this.cboApi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApi.FormattingEnabled = true;
            this.cboApi.Location = new System.Drawing.Point(122, 35);
            this.cboApi.Name = "cboApi";
            this.cboApi.Size = new System.Drawing.Size(277, 23);
            this.cboApi.TabIndex = 21;
            this.cboApi.SelectedIndexChanged += new System.EventHandler(this.cboApi_SelectedIndexChanged);
            // 
            // ApiBrowserButton
            // 
            this.ApiBrowserButton.Location = new System.Drawing.Point(405, 34);
            this.ApiBrowserButton.Name = "ApiBrowserButton";
            this.ApiBrowserButton.Size = new System.Drawing.Size(43, 23);
            this.ApiBrowserButton.TabIndex = 22;
            this.ApiBrowserButton.Text = "...";
            this.ApiBrowserButton.UseVisualStyleBackColor = true;
            // 
            // ResourceTextBox
            // 
            this.ResourceTextBox.Location = new System.Drawing.Point(122, 122);
            this.ResourceTextBox.MaxLength = 50;
            this.ResourceTextBox.Name = "ResourceTextBox";
            this.ResourceTextBox.Size = new System.Drawing.Size(326, 23);
            this.ResourceTextBox.TabIndex = 23;
            // 
            // RequestBodyTextBox
            // 
            this.RequestBodyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.RequestBodyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RequestBodyTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RequestBodyTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.RequestBodyTextBox.Location = new System.Drawing.Point(3, 3);
            this.RequestBodyTextBox.Multiline = true;
            this.RequestBodyTextBox.Name = "RequestBodyTextBox";
            this.RequestBodyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RequestBodyTextBox.Size = new System.Drawing.Size(462, 355);
            this.RequestBodyTextBox.TabIndex = 25;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 389);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AuthenticationComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ResourceTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ApiBrowserButton);
            this.tabPage1.Controls.Add(this.MethodComboBox);
            this.tabPage1.Controls.Add(this.cboApi);
            this.tabPage1.Controls.Add(this.BaseUrlComboBox);
            this.tabPage1.Controls.Add(this.NameTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ClientCertificateTextBox);
            this.tabPage1.Controls.Add(this.SelectClientCertButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.HeadersTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Headers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.QueryParamsTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(468, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Query Parameters";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RequestBodyTextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(468, 361);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Body";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // HttpRequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tabControl1);
            this.Name = "HttpRequestUserControl";
            this.Size = new System.Drawing.Size(476, 389);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

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
        private TextBox HeadersTextBox;
        private TextBox QueryParamsTextBox;
        private Label label9;
        private Label label10;
        private TextBox NameTextBox;
        private Button ApiBrowserButton;
        private TextBox ResourceTextBox;
        private TextBox RequestBodyTextBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        public ComboBox cboApi;
    }
}
