namespace JtvDevTools.RestClient.Forms
{
    partial class OpenAPIForm
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
            this.GetSpecificationButton = new System.Windows.Forms.Button();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetSpecificationButton
            // 
            this.GetSpecificationButton.Location = new System.Drawing.Point(452, 13);
            this.GetSpecificationButton.Name = "GetSpecificationButton";
            this.GetSpecificationButton.Size = new System.Drawing.Size(171, 23);
            this.GetSpecificationButton.TabIndex = 0;
            this.GetSpecificationButton.Text = "Read OpenAPI Specification";
            this.GetSpecificationButton.UseVisualStyleBackColor = true;
            this.GetSpecificationButton.Click += new System.EventHandler(this.GetSpecificationButton_Click);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(12, 13);
            this.AddressTextBox.MaxLength = 4096;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(434, 20);
            this.AddressTextBox.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 51);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(924, 106);
            this.textBox2.TabIndex = 2;
            // 
            // OpenAPIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 526);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.GetSpecificationButton);
            this.Name = "OpenAPIForm";
            this.Text = "Open API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetSpecificationButton;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}