namespace JtvDevTools.WinForms.Forms
{
    partial class SqlToolsForm
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
            label1 = new Label();
            txtConnectionString = new TextBox();
            btnConnect = new Button();
            cboTables = new ComboBox();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Connection String:";
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(12, 27);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(496, 23);
            txtConnectionString.TabIndex = 1;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(514, 27);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // cboTables
            // 
            cboTables.FormattingEnabled = true;
            cboTables.Location = new Point(12, 74);
            cboTables.Name = "cboTables";
            cboTables.Size = new Size(203, 23);
            cboTables.TabIndex = 3;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(221, 74);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += this.btnGenerate_Click;
            // 
            // SqlToolsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 258);
            Controls.Add(btnGenerate);
            Controls.Add(cboTables);
            Controls.Add(btnConnect);
            Controls.Add(txtConnectionString);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SqlToolsForm";
            Text = "Connect to SQL Server Database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtConnectionString;
        private Button btnConnect;
        private ComboBox cboTables;
        private Button btnGenerate;
    }
}