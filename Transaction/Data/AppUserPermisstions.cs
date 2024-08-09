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
    public class AppUserPermisstions
    {
        public static DataTable Get(int userid)
        {
            OracleCommand command = new OracleCommand("APPUSERPERMISSIONGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("AppUserId", userid);

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static void Add(AppUserPermission permisstion)
        {
            OracleCommand command = new OracleCommand("APPUSERPERMISSIONADD", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_AppUserId", OracleDbType.Varchar2).Value = permisstion.AppUserId;
            command.Parameters.Add("P_Permission", OracleDbType.Varchar2).Value = permisstion.PermissionName;

            command.ExecuteNonQuery();
        }

        public static void Delete(int userid)
        {
            OracleCommand command = new OracleCommand("APPUSERPERMISSIONDELETE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_AppUserId", OracleDbType.Int32);
            command.Parameters["P_AppUserId"].Value = userid;

            command.ExecuteNonQuery();
        }
    }
}

