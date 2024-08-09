using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction.Models;

namespace Transaction.Data
{
    public class AppUsers
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("APPUSERGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static AppUser Get(int userid)
        {
            AppUser appuser = null;
            OracleCommand command = new OracleCommand("APPUSERGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.Add("AppuserId", userid);
            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                appuser = new AppUser();
                appuser.AppUserId = Convert.ToInt32(reader["AppUserId"].ToString());
                appuser.UserName = reader["UserName"].ToString();
                appuser.UserPassword = reader["UserPassword"].ToString();
                appuser.IsAdmin = Convert.ToBoolean(Convert.ToInt32(reader["IsAdmin"]));

            }
            return appuser;
        }
        public static void Add(AppUser appuser)
        {
            OracleCommand command = new OracleCommand("APPUSERADD", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

           
            command.Parameters.Add("P_UserName", appuser.UserName);
            command.Parameters.Add("P_UserPassword", appuser.UserPassword);

            command.ExecuteNonQuery();
        }
        public static void Delete(int appuserid)
        {
            OracleCommand command = new OracleCommand("APPUSERDELETE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", OracleDbType.Int32);
            command.Parameters["P_AppUserId"].Value = appuserid;

            command.ExecuteNonQuery();
        }
        public static void Update(AppUser appuser)
        {
            OracleCommand command = new OracleCommand("APPUSERUPDATE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appuser.AppUserId);
            command.Parameters.Add("P_UserName", appuser.UserName);
            command.Parameters.Add("P_UserPassword", appuser.UserPassword);

            command.ExecuteNonQuery();
        }

        public static AppUser Login(string username, string password)
        {
           
            OracleCommand command = new OracleCommand("APPUSERLOGIN", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_UserName", username);
            command.Parameters.Add("P_UserPassword", password);

            AppUser appuser = null;
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                appuser = new AppUser();
                appuser.AppUserId = Convert.ToInt32(reader["AppUserId"].ToString());
                appuser.UserName = reader["UserName"].ToString();
                appuser.UserPassword = reader["UserPassword"].ToString();
                //appuser.IsAdmin = Convert.IsDBNull(Convert.ToBoolean(Convert.ToInt32(reader["IsAdmin"])));
                if (!Convert.IsDBNull(reader["IsAdmin"]))
                {
                    appuser.IsAdmin = Convert.ToBoolean(Convert.ToInt32(reader["IsAdmin"]));
                }
                else
                {
                    appuser.IsAdmin = false;
                }
            }
            return appuser;

        }
    }
}
