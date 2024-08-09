using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transaction.Modoels;

namespace Transaction.Data
{
    public class Sales
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("SALEGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public static Sale Get(int saleId)
        {
            Sale sale = null;
            OracleCommand command = new OracleCommand("SALEGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("saleId", saleId);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sale = new Sale();
                sale.SaleId = Convert.ToInt32(reader["SaleId"].ToString());
                sale.SaleDate = Convert.ToDateTime(reader["SaleSale date"].ToString());
                sale.RefNumber = reader["RefNumber"].ToString();
                sale.CustomerId = Convert.ToInt32(reader["CCustomerId"].ToString());

                if (!Convert.IsDBNull(reader["SalesRepId"]))
                    sale.SaleRepId = Convert.ToInt32(reader["SalesRepId"].ToString());

                if (!Convert.IsDBNull(reader["AppUserId"]))
                    sale.AppUserId = Convert.ToInt32(reader["AppUserId"].ToString());
            }
            return sale;


        }
        public static int Add(Sale sale)
        {
            int saleid = 0;
            OracleCommand command = new OracleCommand("SALEADD", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_Saledate", OracleDbType.Date).Value = sale.SaleDate;
            command.Parameters.Add("P_RefNumber", OracleDbType.Varchar2).Value = sale.RefNumber;
            command.Parameters.Add("P_CustomerId", OracleDbType.Varchar2).Value = sale.CustomerId;
            command.Parameters.Add("P_SaleRepId", OracleDbType.Varchar2).Value = sale.SaleRepId;
            command.Parameters.Add("P_Note", OracleDbType.Varchar2).Value = sale.Note;
            command.Parameters.Add("P_AppUserId", OracleDbType.Int32).Value = sale.AppUserId;
            command.Parameters.Add("P_SaleId", OracleDbType.Int32).Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();

            saleid = Convert.ToInt32(command.Parameters["P_SaleId"].Value.ToString());

            return saleid;

        }
        public static void Update(Sale sale)
        {
            try
            {
                OracleCommand command = new OracleCommand("SALEUPDATE", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_SaleId", OracleDbType.Int32).Value = sale.SaleId;

                command.Parameters.Add("P_SaleDate", OracleDbType.Date).Value = sale.SaleDate;

                command.Parameters.Add("P_RefNumber", OracleDbType.Varchar2).Value = sale.RefNumber;

                command.Parameters.Add("P_CustomerId", OracleDbType.Int32).Value = sale.CustomerId;

                command.Parameters.Add("P_SaleRepId", OracleDbType.Int32).Value = sale.SaleRepId;

                command.Parameters.Add("P_AppUserId", OracleDbType.Int32).Value = sale.AppUserId;

                command.Parameters.Add("P_Note", OracleDbType.Varchar2).Value = sale.Note;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Delete(int saleid)
        {
            OracleCommand command = new OracleCommand("SALEDELETE", BookShopContext.GetConnection());

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_SaleId", OracleDbType.Int32);

            command.Parameters["P_SaleId"].Value = saleid;

            command.ExecuteNonQuery();
        }
    }
}
