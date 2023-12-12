public static class DataGridViewHelper
{
    public static void TrimSelectedCells(DataGridView dgv)
    {
        for (int i = 0; i < dgv.SelectedCells.Count; i++)
        {
            var value = dgv.SelectedCells[i].Value as string ?? "";

            dgv.SelectedCells[i].Value = value.Trim();
        }
    }

    public static void InsertNewGuidToSelectedCells(DataGridView dgv)
    {
        for (int i = 0; i < dgv.SelectedCells.Count; i++)
        {
            dgv.SelectedCells[i].Value = Guid.NewGuid().ToString(); 
        }
    }

    public static void ClearSelectedCells(DataGridView dgv)
    {
        for (int i = 0; i < dgv.SelectedCells.Count; i++)
        {
            dgv.SelectedCells[i].Value = "";
        }
    }

    public static void NewRow(DataGridView dgv)
    {
       
    }

    public static void NewColumn(DataGridView dgv)
    {
    }

    public static void SetColumnSortMode(DataGridView? dataGridView, DataGridViewColumnSortMode sortMode = DataGridViewColumnSortMode.NotSortable)
    {
        if (dataGridView == null) return;

        foreach (DataGridViewColumn c in dataGridView.Columns)
        {
            c.SortMode = sortMode;
        }
    }
}
