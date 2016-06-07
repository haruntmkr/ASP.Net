using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
/// <summary>
/// Summary description for veritabani
/// </summary>
public class veritabani
{
    public veritabani()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public SqlConnection Connection()
    {
        SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["BGABANKUltimateConnectionString"].ConnectionString);
        conn.Open();
        return conn;
    }
    public int Command(string sql)
    {
        SqlConnection conn = this.Connection();
        SqlCommand cmd = new SqlCommand(sql, conn);
        int final = 0;

        try
        {
            final = cmd.ExecuteNonQuery();

        }
        catch (SqlException ex)
        {
            throw ex;

        }

        cmd.Dispose();
        conn.Close();
        conn.Dispose();

        return final;

    }
    public SqlDataReader GetDataReader(string sql)
    {
        SqlConnection conn = this.Connection();
        using (SqlCommand command = new SqlCommand(sql, conn))
        {
            command.ExecuteNonQuery();
            SqlDataReader rd = command.ExecuteReader();
            return rd;
        }
    }
    public DataTable GetDataTable(string sql)
    {
        SqlConnection conn = this.Connection();
        SqlDataAdapter sDa = new SqlDataAdapter(sql, conn);

        DataTable dt = new DataTable();

        try
        {
            sDa.Fill(dt);
        }
        catch (SqlException ex)
        {
            throw;
        }

        sDa.Dispose();
        conn.Close();
        conn.Dispose();

        return dt;
    }

    public DataRow GetDataRow(string sql)
    {
        DataTable dt = GetDataTable(sql);
        if (dt.Rows.Count == 0) return null;
        return dt.Rows[0];
    }


    public string GetDataCell(string sorgu2)
    {
        throw new NotImplementedException();
    }


}