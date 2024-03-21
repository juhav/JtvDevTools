using System.Drawing;
using System.Windows.Forms;

namespace JtvDevTools.RestClient.UserControls
{
    partial class VariablesEditorUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariablesEditorUserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddSecretVariableButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.CloseButton = new System.Windows.Forms.ToolStripButton();
            this.dgvEditor = new System.Windows.Forms.DataGridView();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSecretColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VariableValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSecretVariableButton,
            this.DeleteToolStripButton,
            this.toolStripSeparator1,
            this.SaveButton,
            this.CloseButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(770, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddSecretVariableButton
            // 
            this.AddSecretVariableButton.Image = ((System.Drawing.Image)(resources.GetObject("AddSecretVariableButton.Image")));
            this.AddSecretVariableButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddSecretVariableButton.Name = "AddSecretVariableButton";
            this.AddSecretVariableButton.Size = new System.Drawing.Size(84, 22);
            this.AddSecretVariableButton.Text = "Add Secret";
            this.AddSecretVariableButton.Click += new System.EventHandler(this.AddSecretVariableButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.DeleteToolStripButton.Text = "Delete";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(51, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            // dgvEditor
            // 
            this.dgvEditor.AllowDrop = true;
            this.dgvEditor.AllowUserToOrderColumns = true;
            this.dgvEditor.AllowUserToResizeRows = false;
            this.dgvEditor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvEditor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvEditor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group,
            this.VariableNameColumn,
            this.IsSecretColumn,
            this.VariableValueColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEditor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEditor.EnableHeadersVisualStyles = false;
            this.dgvEditor.Location = new System.Drawing.Point(0, 25);
            this.dgvEditor.Name = "dgvEditor";
            this.dgvEditor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEditor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEditor.RowTemplate.Height = 25;
            this.dgvEditor.Size = new System.Drawing.Size(770, 503);
            this.dgvEditor.TabIndex = 0;
            this.dgvEditor.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvEditor_CellBeginEdit);
            this.dgvEditor.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditor_CellEndEdit);
            this.dgvEditor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEditor_CellFormatting);
            this.dgvEditor.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvEditor_CellValidating);
            this.dgvEditor.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditor_CellValueChanged);
            this.dgvEditor.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvEditor_RowsRemoved);
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            // 
            // VariableNameColumn
            // 
            this.VariableNameColumn.DataPropertyName = "Name";
            this.VariableNameColumn.HeaderText = "Variable";
            this.VariableNameColumn.MaxInputLength = 100;
            this.VariableNameColumn.MinimumWidth = 50;
            this.VariableNameColumn.Name = "VariableNameColumn";
            this.VariableNameColumn.Width = 200;
            // 
            // IsSecretColumn
            // 
            this.IsSecretColumn.DataPropertyName = "IsSecret";
            this.IsSecretColumn.HeaderText = "Secret";
            this.IsSecretColumn.Name = "IsSecretColumn";
            this.IsSecretColumn.ReadOnly = true;
            this.IsSecretColumn.Visible = false;
            // 
            // VariableValueColumn
            // 
            this.VariableValueColumn.DataPropertyName = "Value";
            this.VariableValueColumn.HeaderText = "Value";
            this.VariableValueColumn.Name = "VariableValueColumn";
            this.VariableValueColumn.Width = 200;
            // 
            // VariablesEditorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEditor);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VariablesEditorUserControl";
            this.Size = new System.Drawing.Size(770, 528);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton CloseButton;
        private System.Windows.Forms.DataGridView dgvEditor;
        private ToolStripButton AddSecretVariableButton;
        private ToolStripButton DeleteToolStripButton;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn VariableNameColumn;
        private DataGridViewCheckBoxColumn IsSecretColumn;
        private DataGridViewTextBoxColumn VariableValueColumn;
    }
}
