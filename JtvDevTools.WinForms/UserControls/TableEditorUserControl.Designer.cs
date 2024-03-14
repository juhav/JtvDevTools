using System.Windows.Forms;

namespace JtvDevTools.WinForms.UserControls
{
    partial class TableEditorUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableEditorUserControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            TableEditorNewToolStripDropDownButton = new ToolStripDropDownButton();
            NewRowToolStripMenuItem = new ToolStripMenuItem();
            NewColumnToolStripMenuItem = new ToolStripMenuItem();
            TableEditorToolStripDropDownButton = new ToolStripDropDownButton();
            TableEditorTrimToolStripMenuItem = new ToolStripMenuItem();
            TableEditorInsertGuidToolStripMenuItem = new ToolStripMenuItem();
            TableEditorColumnToolStripDropDownButton = new ToolStripDropDownButton();
            TableEditorAddColumnToolStripMenuItem = new ToolStripMenuItem();
            TableEditorDeleteColumnsToolStripMenuItem = new ToolStripMenuItem();
            dgvEditor = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditor).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { TableEditorNewToolStripDropDownButton, TableEditorToolStripDropDownButton, TableEditorColumnToolStripDropDownButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(714, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // TableEditorNewToolStripDropDownButton
            // 
            TableEditorNewToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TableEditorNewToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { NewRowToolStripMenuItem, NewColumnToolStripMenuItem });
            TableEditorNewToolStripDropDownButton.Image = (Image)resources.GetObject("TableEditorNewToolStripDropDownButton.Image");
            TableEditorNewToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            TableEditorNewToolStripDropDownButton.Name = "TableEditorNewToolStripDropDownButton";
            TableEditorNewToolStripDropDownButton.Size = new Size(44, 22);
            TableEditorNewToolStripDropDownButton.Text = "New";
            // 
            // NewRowToolStripMenuItem
            // 
            NewRowToolStripMenuItem.Name = "NewRowToolStripMenuItem";
            NewRowToolStripMenuItem.Size = new Size(117, 22);
            NewRowToolStripMenuItem.Text = "Row";
            NewRowToolStripMenuItem.Click += NewRowToolStripMenuItem_Click;
            // 
            // NewColumnToolStripMenuItem
            // 
            NewColumnToolStripMenuItem.Name = "NewColumnToolStripMenuItem";
            NewColumnToolStripMenuItem.Size = new Size(117, 22);
            NewColumnToolStripMenuItem.Text = "Column";
            NewColumnToolStripMenuItem.Click += NewColumnToolStripMenuItem_Click;
            // 
            // TableEditorToolStripDropDownButton
            // 
            TableEditorToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TableEditorToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { TableEditorTrimToolStripMenuItem, TableEditorInsertGuidToolStripMenuItem });
            TableEditorToolStripDropDownButton.Image = (Image)resources.GetObject("TableEditorToolStripDropDownButton.Image");
            TableEditorToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            TableEditorToolStripDropDownButton.Name = "TableEditorToolStripDropDownButton";
            TableEditorToolStripDropDownButton.Size = new Size(40, 22);
            TableEditorToolStripDropDownButton.Text = "Edit";
            // 
            // TableEditorTrimToolStripMenuItem
            // 
            TableEditorTrimToolStripMenuItem.Name = "TableEditorTrimToolStripMenuItem";
            TableEditorTrimToolStripMenuItem.Size = new Size(131, 22);
            TableEditorTrimToolStripMenuItem.Text = "Trim";
            TableEditorTrimToolStripMenuItem.Click += TableEditorTrimToolStripMenuItem_Click;
            // 
            // TableEditorInsertGuidToolStripMenuItem
            // 
            TableEditorInsertGuidToolStripMenuItem.Name = "TableEditorInsertGuidToolStripMenuItem";
            TableEditorInsertGuidToolStripMenuItem.Size = new Size(131, 22);
            TableEditorInsertGuidToolStripMenuItem.Text = "Insert Guid";
            TableEditorInsertGuidToolStripMenuItem.Click += TableEditorInsertGuidToolStripMenuItem_Click;
            // 
            // TableEditorColumnToolStripDropDownButton
            // 
            TableEditorColumnToolStripDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TableEditorColumnToolStripDropDownButton.DropDownItems.AddRange(new ToolStripItem[] { TableEditorAddColumnToolStripMenuItem, TableEditorDeleteColumnsToolStripMenuItem });
            TableEditorColumnToolStripDropDownButton.Image = (Image)resources.GetObject("TableEditorColumnToolStripDropDownButton.Image");
            TableEditorColumnToolStripDropDownButton.ImageTransparentColor = Color.Magenta;
            TableEditorColumnToolStripDropDownButton.Name = "TableEditorColumnToolStripDropDownButton";
            TableEditorColumnToolStripDropDownButton.Size = new Size(68, 22);
            TableEditorColumnToolStripDropDownButton.Text = "Columns";
            // 
            // TableEditorAddColumnToolStripMenuItem
            // 
            TableEditorAddColumnToolStripMenuItem.Name = "TableEditorAddColumnToolStripMenuItem";
            TableEditorAddColumnToolStripMenuItem.Size = new Size(158, 22);
            TableEditorAddColumnToolStripMenuItem.Text = "Add Column";
            TableEditorAddColumnToolStripMenuItem.Click += TableEditorAddColumnToolStripMenuItem_Click;
            // 
            // TableEditorDeleteColumnsToolStripMenuItem
            // 
            TableEditorDeleteColumnsToolStripMenuItem.Name = "TableEditorDeleteColumnsToolStripMenuItem";
            TableEditorDeleteColumnsToolStripMenuItem.Size = new Size(158, 22);
            TableEditorDeleteColumnsToolStripMenuItem.Text = "Delete Columns";
            TableEditorDeleteColumnsToolStripMenuItem.Click += TableEditorDeleteColumnsToolStripMenuItem_Click;
            // 
            // dgvEditor
            // 
            dgvEditor.AllowDrop = true;
            dgvEditor.AllowUserToAddRows = false;
            dgvEditor.AllowUserToOrderColumns = true;
            dgvEditor.AllowUserToResizeRows = false;
            dgvEditor.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvEditor.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvEditor.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEditor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 20, 20);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEditor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEditor.Dock = DockStyle.Fill;
            dgvEditor.EnableHeadersVisualStyles = false;
            dgvEditor.Location = new Point(0, 25);
            dgvEditor.Name = "dgvEditor";
            dgvEditor.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 40, 40);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEditor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEditor.RowTemplate.Height = 25;
            dgvEditor.Size = new Size(714, 450);
            dgvEditor.TabIndex = 0;
            dgvEditor.DataMemberChanged += dgvEditor_DataMemberChanged;
            dgvEditor.CellMouseClick += dgvEditor_CellMouseClick;
            dgvEditor.ColumnAdded += dgvEditor_ColumnAdded;
            dgvEditor.ColumnHeaderMouseClick += dgvEditor_ColumnHeaderMouseClick;
            dgvEditor.RowHeaderMouseClick += dgvEditor_RowHeaderMouseClick;
            dgvEditor.RowPostPaint += dgvEditor_RowPostPaint;
            dgvEditor.KeyDown += dgvEditor_KeyDown;
            dgvEditor.KeyPress += dgvEditor_KeyPress;
            // 
            // TableEditorUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvEditor);
            Controls.Add(toolStrip1);
            Name = "TableEditorUserControl";
            Size = new Size(714, 475);
            Load += TableEditorUserControl_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton TableEditorNewToolStripDropDownButton;
        private ToolStripMenuItem NewRowToolStripMenuItem;
        private ToolStripMenuItem NewColumnToolStripMenuItem;
        private ToolStripDropDownButton TableEditorToolStripDropDownButton;
        private ToolStripMenuItem TableEditorTrimToolStripMenuItem;
        private ToolStripMenuItem TableEditorInsertGuidToolStripMenuItem;
        private ToolStripDropDownButton TableEditorColumnToolStripDropDownButton;
        private ToolStripMenuItem TableEditorAddColumnToolStripMenuItem;
        private ToolStripMenuItem TableEditorDeleteColumnsToolStripMenuItem;
        private DataGridView dgvEditor;
    }
}
