using JtvDevTools.Core.DB;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace JtvDevTools.WinForms.Forms
{
    public partial class SqlToolsForm : Form
    {
        private DB db;
        private MainForm mainForm;

        public SqlToolsForm(MainForm mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            db = new DB(txtConnectionString.Text);

            var dt = db.GetDataTable("select * from [INFORMATION_SCHEMA].[Tables] order by TABLE_NAME");

            cboTables.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                cboTables.Items.Add(row.Field<string>("TABLE_NAME"));
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cboTables.SelectedItem == null) return;

            var table = (cboTables.SelectedItem as string);

            var dt = db.GetDataTable($"select * from [INFORMATION_SCHEMA].[Columns] where TABLE_NAME = '{table}' order by COLUMN_NAME");

            var sb = new StringBuilder(4096);

            sb.AppendLine("public class " + table);
            sb.AppendLine("{");

            foreach (DataRow row in dt.Rows)
            {
                var columnName = row.Field<string>("COLUMN_NAME");
                var sqlDataType = row.Field<string>("DATA_TYPE");
                var isNullable = (row.Field<string>("IS_NULLABLE") == "YES");

                var csDataType = GetCsDataType(sqlDataType, isNullable);

                sb.AppendLine($"    public {GetCsDataType(sqlDataType, isNullable)} {columnName} {{ get; set; }}");
            }

            sb.AppendLine("}");
            sb.AppendLine("");

            sb.AppendLine("foreach (DataRow row in dt.Rows)");
            sb.AppendLine("{");
            sb.AppendLine("    var result = new " + table + "()");
            sb.AppendLine("    {");

            int rowNum = 1;
            int rowCount = dt.Rows.Count;

            foreach (DataRow row in dt.Rows)
            {
                var columnName = row.Field<string>("COLUMN_NAME");
                var sqlDataType = row.Field<string>("DATA_TYPE");
                var isNullable = (row.Field<string>("IS_NULLABLE") == "YES");

                var csDataType = GetCsDataType(sqlDataType, isNullable);

                sb.Append($"        {columnName} = row.Field<{GetCsDataTypeForDataRowField(sqlDataType, isNullable)}>(\"{columnName}\")");

                if (rowNum < rowCount)
                {
                    sb.AppendLine(",");
                }
                else
                {
                    sb.AppendLine();
                }

                rowNum++;
            }

            sb.AppendLine("    };");
            sb.AppendLine("}");

            mainForm.txtEditor.Text = sb.ToString();
        }

        private string GetCsDataTypeForDataRowField(string sqlDataType, bool isNullable)
        {
            string result = null;

            switch (sqlDataType)
            {
                case "nvarchar": 
                    return "string";

                case "int": result = "int"; break;
                case "bit": result = "bool"; break;
                case "uniqueidentifier": result = "Guid"; break;
            }

            if (result == null)
            {
                throw new NotImplementedException($"Unable to convert sql type {sqlDataType}.");
            }

            if (isNullable)
            {
                result = result + "?";
            }

            return result;
        }

        private string GetCsDataType(string sqlDataType, bool isNullable)
        {
            string result = null;

            switch (sqlDataType)
            {
                case "nvarchar": result = "string"; break;
                case "int": result = "int"; break;
                case "bit": result = "bool"; break;
                case "uniqueidentifier": result = "Guid"; break;
            }

            if (result == null)
            {
                throw new NotImplementedException($"Unable to convert sql type {sqlDataType}.");
            }

            if (isNullable)
            {
                result = result + "?";
            }

            return result;
        }
    }

}
