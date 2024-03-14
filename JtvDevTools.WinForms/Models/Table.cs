using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.WinForms.Models
{
    public class Table
    {
        private DataTable dt;

        public DataTable DataTable
        {
            get => dt;
            set => dt = value;
        }

        public Table()
        {
            dt = new DataTable();
        }

        public void SetValue(int col, int row, string value)
        {
            dt.Rows[row][col] = value;
        }
    }
}
