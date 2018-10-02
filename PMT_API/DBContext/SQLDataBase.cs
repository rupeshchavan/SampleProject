using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace PMT_API.DBContext
{
    public class SQLDataBase
    {

        string ConnectionString = System.Configuration.ConfigurationManager.AppSettings[""].ToString();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter dta; 
        public string ErrorMessage { get; set; }

        public SQLDataBase()
        {
            conn = new SqlConnection(this.ConnectionString);
        }

        public SQLDataBase(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
            conn = new SqlConnection(this.ConnectionString);
        }
        
        public int ExecuteQuery(string query)
        {
            int i = 0;
            ErrorMessage = "";
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = query;

            try
            {
                conn.Open();
                i = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message.ToString();
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
            return i;
        }


        public string getScalar(string query)
        {
            string sclalar = "";
            ErrorMessage = "";
            DataTable dt = new DataTable();
            dta = new SqlDataAdapter(query, conn);
            try
            {
                dta.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    sclalar = dt.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message.ToString();
            }
            return sclalar;
        }


    }
}