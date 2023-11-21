namespace JtvDevTools.RestClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResource = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAuth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientCertificate = new System.Windows.Forms.TextBox();
            this.chkPrettyPrint = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaveResponseBodyToFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExpectStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAPI = new System.Windows.Forms.TextBox();
            this.chkPreAuthenticate = new System.Windows.Forms.CheckBox();
            this.txtHeaders = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuery = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Url:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(137, 125);
            this.txtBaseUrl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBaseUrl.MaxLength = 1024;
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.Size = new System.Drawing.Size(374, 23);
            this.txtBaseUrl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Method:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboMethod
            // 
            this.cboMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethod.FormattingEnabled = true;
            this.cboMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE",
            "PATCH",
            "HEAD",
            "TRACE",
            "CONNECT",
            "OPTIONS"});
            this.cboMethod.Location = new System.Drawing.Point(137, 96);
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.Size = new System.Drawing.Size(99, 23);
            this.cboMethod.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resource:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtResource
            // 
            this.txtResource.Location = new System.Drawing.Point(137, 154);
            this.txtResource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResource.MaxLength = 1024;
            this.txtResource.Name = "txtResource";
            this.txtResource.Size = new System.Drawing.Size(264, 23);
            this.txtResource.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Auth:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAuth
            // 
            this.cboAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuth.FormattingEnabled = true;
            this.cboAuth.Items.AddRange(new object[] {
            "None",
            "NTLM",
            "NTLM Custom",
            "Basic"});
            this.cboAuth.Location = new System.Drawing.Point(137, 184);
            this.cboAuth.Name = "cboAuth";
            this.cboAuth.Size = new System.Drawing.Size(143, 23);
            this.cboAuth.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Client Cert:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClientCertificate
            // 
            this.txtClientCertificate.Location = new System.Drawing.Point(137, 212);
            this.txtClientCertificate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClientCertificate.MaxLength = 100;
            this.txtClientCertificate.Name = "txtClientCertificate";
            this.txtClientCertificate.Size = new System.Drawing.Size(303, 23);
            this.txtClientCertificate.TabIndex = 8;
            // 
            // chkPrettyPrint
            // 
            this.chkPrettyPrint.Location = new System.Drawing.Point(137, 241);
            this.chkPrettyPrint.Name = "chkPrettyPrint";
            this.chkPrettyPrint.Size = new System.Drawing.Size(33, 23);
            this.chkPrettyPrint.TabIndex = 9;
            this.chkPrettyPrint.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pretty Print:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSaveResponseBodyToFile
            // 
            this.txtSaveResponseBodyToFile.Location = new System.Drawing.Point(137, 270);
            this.txtSaveResponseBodyToFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaveResponseBodyToFile.MaxLength = 260;
            this.txtSaveResponseBodyToFile.Name = "txtSaveResponseBodyToFile";
            this.txtSaveResponseBodyToFile.Size = new System.Drawing.Size(374, 23);
            this.txtSaveResponseBodyToFile.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(11, 270);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Save Body:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtExpectStatus
            // 
            this.txtExpectStatus.Location = new System.Drawing.Point(137, 299);
            this.txtExpectStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtExpectStatus.MaxLength = 5;
            this.txtExpectStatus.Name = "txtExpectStatus";
            this.txtExpectStatus.Size = new System.Drawing.Size(84, 23);
            this.txtExpectStatus.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Expect Status:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Id:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(11, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "Name:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(11, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "API:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 9);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.MaxLength = 1024;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(374, 23);
            this.txtId.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.MaxLength = 1024;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(374, 23);
            this.txtName.TabIndex = 18;
            // 
            // txtAPI
            // 
            this.txtAPI.Location = new System.Drawing.Point(137, 67);
            this.txtAPI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAPI.MaxLength = 1024;
            this.txtAPI.Name = "txtAPI";
            this.txtAPI.Size = new System.Drawing.Size(374, 23);
            this.txtAPI.TabIndex = 19;
            // 
            // chkPreAuthenticate
            // 
            this.chkPreAuthenticate.Location = new System.Drawing.Point(299, 184);
            this.chkPreAuthenticate.Name = "chkPreAuthenticate";
            this.chkPreAuthenticate.Size = new System.Drawing.Size(141, 23);
            this.chkPreAuthenticate.TabIndex = 20;
            this.chkPreAuthenticate.Text = "PreAuthenticate";
            this.chkPreAuthenticate.UseVisualStyleBackColor = true;
            // 
            // txtHeaders
            // 
            this.txtHeaders.AutoCompleteBracketsList = new char[] {
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
            this.txtHeaders.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtHeaders.BackBrush = null;
            this.txtHeaders.CharHeight = 14;
            this.txtHeaders.CharWidth = 8;
            this.txtHeaders.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHeaders.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtHeaders.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtHeaders.IsReplaceMode = false;
            this.txtHeaders.Location = new System.Drawing.Point(13, 357);
            this.txtHeaders.Name = "txtHeaders";
            this.txtHeaders.Paddings = new System.Windows.Forms.Padding(0);
            this.txtHeaders.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtHeaders.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtHeaders.ServiceColors")));
            this.txtHeaders.Size = new System.Drawing.Size(497, 150);
            this.txtHeaders.TabIndex = 21;
            this.txtHeaders.Zoom = 100;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(11, 513);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Query:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuery
            // 
            this.txtQuery.AutoCompleteBracketsList = new char[] {
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
            this.txtQuery.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtQuery.BackBrush = null;
            this.txtQuery.CharHeight = 14;
            this.txtQuery.CharWidth = 8;
            this.txtQuery.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuery.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtQuery.IsReplaceMode = false;
            this.txtQuery.Location = new System.Drawing.Point(13, 542);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Paddings = new System.Windows.Forms.Padding(0);
            this.txtQuery.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtQuery.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtQuery.ServiceColors")));
            this.txtQuery.Size = new System.Drawing.Size(497, 147);
            this.txtQuery.TabIndex = 21;
            this.txtQuery.Zoom = 100;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(10, 328);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Headers:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RequestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.txtHeaders);
            this.Controls.Add(this.chkPreAuthenticate);
            this.Controls.Add(this.txtAPI);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExpectStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSaveResponseBodyToFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkPrettyPrint);
            this.Controls.Add(this.txtClientCertificate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboAuth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResource);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMethod);
            this.Controls.Add(this.txtBaseUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RequestUserControl";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Size = new System.Drawing.Size(529, 785);
            ((System.ComponentModel.ISupportInitialize)(this.txtHeaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAuth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientCertificate;
        private System.Windows.Forms.CheckBox chkPrettyPrint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaveResponseBodyToFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExpectStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAPI;
        private System.Windows.Forms.CheckBox chkPreAuthenticate;
        private FastColoredTextBoxNS.FastColoredTextBox txtHeaders;
        private System.Windows.Forms.Label label12;
        private FastColoredTextBoxNS.FastColoredTextBox txtQuery;
        private System.Windows.Forms.Label label13;
    }
}
