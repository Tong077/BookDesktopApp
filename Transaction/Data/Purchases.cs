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
    public  class Purchases
    {
        public static DataTable GetAll()
        {
            DataTable table = new DataTable();
            OracleCommand command = new OracleCommand("PURCHASEGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(table);

            return table;
        }
        public static Purchase Get(int purchaseId)
        {
            Purchase purchase = new Purchase();
            OracleCommand command = new OracleCommand("PURCHASEGET",BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseId", purchaseId);
            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                purchase.PurchaseID = Convert.ToInt32(reader["purchaseId"]);
                purchase.PurchaseDate = Convert.ToDateTime (reader["PurchaseDate"].ToString());
                purchase.VendorId = Convert.ToInt32(reader["VendorID"].ToString());
                purchase.AppuserId = Convert.ToInt32(reader["AppuserID"].ToString());
                purchase.Note = reader["Note"].ToString();
            }
            return purchase;
        }
        public static int Add(Purchase purchase)
        {
            int purchaseid = 0;
            OracleCommand command = new OracleCommand("PURSHASEADD", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseDate", OracleDbType.Date).Value = purchase.PurchaseDate;
            command.Parameters.Add("P_VendorID", OracleDbType.Int32).Value = purchase.VendorId;
            command.Parameters.Add("P_AppuserID", OracleDbType.Int32).Value = purchase.AppuserId;
            command.Parameters.Add("P_Note", OracleDbType.Varchar2).Value = purchase.Note;
            command.Parameters.Add("P_PurchaseId", OracleDbType.Int32).Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();

            purchaseid = Convert.ToInt32(command.Parameters["P_PurchaseId"].Value.ToString());

            return purchaseid;
        }
        public static void Update(Purchase purchase)
        {
            OracleCommand command = new OracleCommand("PURSHASEUPDATE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseId", purchase.PurchaseID);
            command.Parameters.Add("P_PurchaseDate", purchase.PurchaseDate);
            command.Parameters.Add("P_VendorId", purchase.VendorId);
            command.Parameters.Add("P_AppuserId", purchase.AppuserId);
            command.Parameters.Add("P_Note", purchase.Note);

            command.ExecuteNonQuery();
        }
        public static void Delete(int purchaseId)
        {
            OracleCommand command = new OracleCommand("PURCHASEDELETE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseId", purchaseId);
            command.ExecuteNonQuery();

        }
    }
}
