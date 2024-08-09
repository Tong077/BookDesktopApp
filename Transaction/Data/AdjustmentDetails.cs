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
    public class AdjustmentDetails
    {
        
        
            public static DataTable Get(int adjustmentId)
            {
                OracleCommand command = new OracleCommand("ADJUSTMENTDETAILGET", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("AdjustmentId", adjustmentId);

                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            public static void Add(AdjustmentDetail adjustmentDetail)
            {
                OracleCommand command = new OracleCommand("ADJUSTMENTDETAILADD", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_AdjustmentId", OracleDbType.Int32).Value = adjustmentDetail.AdjustmentId;
                command.Parameters.Add("P_ItemId", OracleDbType.Int32).Value = adjustmentDetail.ItemId;
                command.Parameters.Add("P_ItemDescription", OracleDbType.Varchar2).Value = adjustmentDetail.ItemDescription;
                command.Parameters.Add("P_Quantity", OracleDbType.Decimal).Value = adjustmentDetail.Quantity;
                command.Parameters.Add("P_Price", OracleDbType.Decimal).Value = adjustmentDetail.Price;

                command.ExecuteNonQuery();
            }
            public static void Update(AdjustmentDetail adjustmentDetail)
            {
                OracleCommand command = new OracleCommand("ADJUSTMENTDETAILUPDATE", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_AdjustmentDeatilId", OracleDbType.Int32).Value = adjustmentDetail.AdjustmentDetailID;
                command.Parameters.Add("P_AdjustmentId", OracleDbType.Int32).Value = adjustmentDetail.AdjustmentId;
                command.Parameters.Add("P_ItemId", OracleDbType.Int32).Value = adjustmentDetail.ItemId;
                command.Parameters.Add("P_ItemDescription", OracleDbType.Varchar2).Value = adjustmentDetail.ItemDescription;
                command.Parameters.Add("P_Quantity", OracleDbType.Decimal).Value = adjustmentDetail.Quantity;
                command.Parameters.Add("P_Price", OracleDbType.Decimal).Value = adjustmentDetail.Price;

                command.ExecuteNonQuery();
            }
            public static void Delete(int adjustmentId)
            {
                OracleCommand command = new OracleCommand("ADJUSTMENTDETAILDELETE", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_AdjustmentId", OracleDbType.Int32);
                command.Parameters["P_AdjustmentId"].Value = adjustmentId;

                command.ExecuteNonQuery();
            }
    }
    
}
