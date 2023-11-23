using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.Core.DB;

public class DB
{
    private readonly string connectionString;

    public DB(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public DataSet GetDataSet(string sql)
    {
        var ds = new DataSet();

        using var cnn = new SqlConnection(connectionString);

        cnn.Open();

        using var cmd = new SqlCommand(sql, cnn);
        using var da = new SqlDataAdapter(cmd);

        da.Fill(ds);

        return ds;
    }

    public DataTable GetDataTable(string sql)
    {
        var ds = GetDataSet(sql);
        var dt = ds.Tables[0];

        return dt;
    }
}
