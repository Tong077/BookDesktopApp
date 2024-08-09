using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Data
{
    public class BookShopContext
    {
        static OracleConnection conn;
        public static void OpenConnection()
        {
            if (conn == null)
            {
                conn = new OracleConnection();
                conn.ConnectionString = "Data Source=localhost:1521/XEPDB1;User Id=pos;Password=123;";
                conn.Open();
            }

        }
        public static OracleConnection GetConnection()
        {
            if (conn == null)

                OpenConnection();

            return conn;
        }
        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
            }
            conn = null;
        }
    }
}

