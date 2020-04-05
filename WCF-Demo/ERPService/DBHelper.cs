using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ERPService
{
    class DBHelper
    {
        public DBHelper()
        {

        }

        public static SqlConnection conn = null;
        public bool OpenConnection()
        {
            conn = new SqlConnection();           
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DBString"].ConnectionString;

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public object ExecuteScalar(string sql)
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(sql, conn);
                return cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
