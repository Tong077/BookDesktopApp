using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction.Modoels;

namespace Transaction.Data
{
    public class SaleDetails
    {
        public static DataTable Get(int saleid)
        {
            OracleCommand command = new OracleCommand("SALEDETAILGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_SaleId", saleid);

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }
        public static void Add(SaleDetail saledetail)
        {
            OracleCommand command = new OracleCommand("SALEDETAILADD", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_SaleId", OracleDbType.Int32).Value = saledetail.SaleId;
            command.Parameters.Add("P_ItemId", OracleDbType.Int32).Value = saledetail.ItemId;
            command.Parameters.Add("P_ItemDescription", OracleDbType.Varchar2).Value = saledetail.ItemDesciption;
            command.Parameters.Add("P_Quantity", OracleDbType.Decimal).Value = saledetail.Quantity;
            command.Parameters.Add("P_Price", OracleDbType.Decimal).Value = saledetail.Price;

            command.ExecuteNonQuery();
        }
        public static void Update(SaleDetail saledetail)
        {
            OracleCommand command = new OracleCommand("SALEDETAILUPDATE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_SaleDetailId", OracleDbType.Int32).Value = saledetail.SaleDetailId;
            command.Parameters.Add("P_SaleId", OracleDbType.Int32).Value = saledetail.SaleId;
            command.Parameters.Add("P_ItemId", OracleDbType.Int32).Value = saledetail.ItemId;
            command.Parameters.Add("P_ItemDescription", OracleDbType.Varchar2).Value = saledetail.ItemDesciption;
            command.Parameters.Add("P_Quantity", OracleDbType.Decimal).Value = saledetail.Quantity;
            command.Parameters.Add("P_Price", OracleDbType.Decimal).Value = saledetail.Price;

        }
        public static void Delete(int saleid)
        {
            OracleCommand command = new OracleCommand("SALEDETAILDELETE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_SaleId", OracleDbType.Int32);
            command.Parameters["P_SaleId"].Value = saleid;

            command.ExecuteNonQuery();

        }
    }
}
