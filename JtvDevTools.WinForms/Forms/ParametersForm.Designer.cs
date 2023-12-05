namespace JtvDevTools.WinForms.Forms
{
    partial class ParametersForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGrid = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            ValueColumn = new DataGridViewTextBoxColumn();
            TypeColumn = new DataGridViewTextBoxColumn();
            btnOK = new Button();
            btnCancel = new Button();
            ErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToResizeRows = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ValueColumn, TypeColumn });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            DataGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            DataGrid.Location = new Point(12, 12);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersVisible = false;
            DataGrid.RowTemplate.Height = 25;
            DataGrid.Size = new Size(436, 285);
            DataGrid.TabIndex = 0;
            DataGrid.CellFormatting += DataGrid_CellFormatting;
            DataGrid.CellValidating += DataGrid_CellValidating;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "Parameter";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            NameColumn.Width = 200;
            // 
            // ValueColumn
            // 
            ValueColumn.DataPropertyName = "Value";
            ValueColumn.HeaderText = "Value";
            ValueColumn.Name = "ValueColumn";
            ValueColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ValueColumn.Width = 200;
            // 
            // TypeColumn
            // 
            TypeColumn.DataPropertyName = "Type";
            TypeColumn.HeaderText = "Type";
            TypeColumn.Name = "TypeColumn";
            TypeColumn.ReadOnly = true;
            TypeColumn.Visible = false;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(292, 312);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(373, 312);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Location = new Point(12, 312);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 15);
            ErrorLabel.TabIndex = 3;
            // 
            // ParametersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 347);
            Controls.Add(ErrorLabel);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(DataGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParametersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Parameters";
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGrid;
        private Button btnOK;
        private Button btnCancel;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ValueColumn;
        private DataGridViewTextBoxColumn TypeColumn;
        private Label ErrorLabel;
    }
}