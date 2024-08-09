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
    public class PurchaseDetails
    {
        public static DataTable Get(int purchaseId)
        {
            OracleCommand command = new OracleCommand("PURCHASEDETAILGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseId", purchaseId);

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static void Add(PurchaseDetail purchaseDetail)
        {
            OracleCommand command = new OracleCommand("PURCHASEDETAILADD", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseId", OracleDbType.Int32).Value = purchaseDetail.PurchaseId;
            command.Parameters.Add("P_ItemId", OracleDbType.Int32).Value = purchaseDetail.ItemId;
            command.Parameters.Add("P_ItemDescription", OracleDbType.Varchar2).Value = purchaseDetail.ItemDescription;
            command.Parameters.Add("P_Quantity", OracleDbType.Decimal).Value = purchaseDetail.Quantity;
            command.Parameters.Add("P_Price", OracleDbType.Decimal).Value = purchaseDetail.Price;

            command.ExecuteNonQuery();
        }
        public static void Update(PurchaseDetail purchaseDetail)
        {
            OracleCommand command = new OracleCommand("PURCHASEDETAILUPDATE", BookShopContext.GetConnection());
            command.Parameters.Add("P_PurchaseDetailId", OracleDbType.Int32).Value = purchaseDetail.purchaseDetailId;
            command.Parameters.Add("P_PurchaseId", OracleDbType.Int32).Value = purchaseDetail.PurchaseId;
            command.Parameters.Add("P_ItemId", OracleDbType.Int32).Value = purchaseDetail.ItemId;
            command.Parameters.Add("P_ItemDescription", OracleDbType.Varchar2).Value = purchaseDetail.ItemDescription;
            command.Parameters.Add("P_Quantity", OracleDbType.Decimal).Value = purchaseDetail.Quantity;
            command.Parameters.Add("P_Price", OracleDbType.Decimal).Value = purchaseDetail.Price;

            command.ExecuteNonQuery();
        }
        public static void Delete(int purchaseId)
        {
            OracleCommand command = new OracleCommand("PURCHASEDETAILDELETE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseId", OracleDbType.Int32);
            command.Parameters["P_PurchaseId"].Value = purchaseId;

            command.ExecuteNonQuery();  
        }
        
    }
}
