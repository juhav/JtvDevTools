using JtvDevTools.WinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JtvDevTools.WinForms.UserControls
{
    public partial class TableEditorUserControl : UserControl
    {
        private Table table;

        public Table Table
        {
            get => table;
        }

        public TableEditorUserControl()
        {
            InitializeComponent();
        }

        private void CreateTableEditor()
        {
            table = new Table();
            table.DataTable = new DataTable();

            for (int i = 0; i < 15; i++)
            {
                var c = new DataColumn()
                {
                    ColumnName = "C" + (i + 1).ToString(),
                    DataType = typeof(string),
                    DefaultValue = "",
                };

                table.DataTable.Columns.Add(c);
            }

            for (int i = 0; i < 20; i++)
            {
                var row = table.DataTable.NewRow();
                table.DataTable.Rows.Add(row);
            }

            dgvEditor.DataSource = table.DataTable;

            foreach (DataGridViewColumn column in dgvEditor.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dgvEditor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            var dgv = sender as DataGridView;

            if (dgv == null) return;

            dgv.ClearSelection();
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
        }

        private void dgvEditor_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgvEditor_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dgv = sender as DataGridView;

            dgv.ClearSelection();
            dgv.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgv.Columns[e.ColumnIndex].Selected = true;
        }

        private void dgvEditor_DataMemberChanged(object sender, EventArgs e)
        {
            DataGridViewHelper.SetColumnSortMode(sender as DataGridView);
        }

        private void dgvEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DataGridViewHelper.ClearSelectedCells(dgvEditor);
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                var data = dgvEditor.GetClipboardContent();

            }
        }

        private void dgvEditor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvEditor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dgv = sender as DataGridView;

            dgv.ClearSelection();
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Rows[e.RowIndex].Selected = true;
        }

        private void dgvEditor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rowHeaderText = (e.RowIndex + 1).ToString();
            var dgv = sender as DataGridView;
            using (SolidBrush brush = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor))
            {
                var textFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Far,
                    LineAlignment = StringAlignment.Center
                };

                var bounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth - 1, e.RowBounds.Height);
                e.Graphics.DrawString(rowHeaderText, this.Font, brush, bounds, textFormat);
            }
        }

        private void NewColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = table.DataTable.NewRow();
            table.DataTable.Rows.Add(row);
        }

        private void TableEditorAddColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.DataTable.Columns.Add(new DataColumn()
            {
                AllowDBNull = false,
                ColumnName = "Column_" + Guid.NewGuid().ToString("N"),
                DataType = typeof(string),
                DefaultValue = ""
            });
        }

        private void TableEditorDeleteColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dataColumns = new List<DataColumn>();
            foreach (DataGridViewColumn column in dgvEditor.SelectedColumns)
            {
                var dataColumn = table.DataTable.Columns[column.DataPropertyName];
                dataColumns.Add(dataColumn);
            }

            dataColumns.ForEach(c => table.DataTable.Columns.Remove(c));
        }

        private void TableEditorTrimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.TrimSelectedCells(dgvEditor);
        }

        private void TableEditorInsertGuidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewHelper.InsertNewGuidToSelectedCells(dgvEditor);
        }


        private void SetRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }

            dgvEditor.Refresh();
        }

        private void TableEditorUserControl_Load(object sender, EventArgs e)
        {
            CreateTableEditor();
            SetRowNumber(dgvEditor);

            Type dgvType = dgvEditor.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)!;
            pi.SetValue(dgvEditor, true, null);
        }
    }
}
