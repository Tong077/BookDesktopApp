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
    public class SalesReps
    {
        public static DataTable Getall()
        {
            OracleCommand command = new OracleCommand("SaleRepGet", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public static SalesRep Get(int salerepId)
        {
            SalesRep salerep = null;
            OracleCommand command = new OracleCommand("SALEREPGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_SalerepId", salerepId);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                salerep = new SalesRep();
                salerep.SaleRepId = Convert.ToInt32(reader["SaleRepId"].ToString());
                salerep.SaleRepName = reader["SalerepName"].ToString();
                salerep.Sex = reader["Sex"].ToString();
                salerep.DoB = Convert.ToDateTime(reader["DoB"].ToString());
                salerep.PoB = reader["PoB"].ToString();
                salerep.Address = reader["Address"].ToString();
            }
            return salerep;

        }
    }
}
