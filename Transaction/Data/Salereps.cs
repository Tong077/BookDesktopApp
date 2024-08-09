using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transaction.Models;

namespace Transaction.Data
{
    public class Salereps
    {
        public static DataTable Getall()
        {
            DataTable table = new DataTable();
            OracleCommand command = new OracleCommand("SalerepGet", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public static Salerep Get(int salerepID)
        {
            Salerep salerep = new Salerep();
            OracleCommand command = new OracleCommand("SalerepGet", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("SalerepID", salerepID);
            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                salerep.SaleRepID = Convert.ToInt32(reader["SalerepID"]);
                salerep.SaleRepName = reader["SalerepName"].ToString();
                salerep.Sex = reader["Sex"].ToString();
                salerep.Dob = Convert.ToDateTime(reader["Dob"].ToString());
                salerep.Pob = reader["Pob"].ToString();
                salerep.Address = reader["Address"].ToString();
            }
            return salerep;
        }
        public static void Add(Salerep salerep)
        {


            OracleCommand command = new OracleCommand("SALEREPAdd", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_SALEREPNAME", salerep.SaleRepName);
            command.Parameters.Add("P_Sex", salerep.Sex);
            command.Parameters.Add("P_Dob", salerep.Dob);
            command.Parameters.Add("P_Pob", salerep.Pob);
            command.Parameters.Add("P_Address", salerep.Address);
            command.Parameters.Add("P_NATIONALCARDNUMBER", salerep.NATIONALCARDNUMBER);
            command.ExecuteNonQuery();


        }
        public static void Update(Salerep salerep)
        {
            OracleCommand command = new OracleCommand("SALEREPUPDATE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(" P_SalerepID", salerep.SaleRepID);
            command.Parameters.Add("P_SALEREPNAME", salerep.SaleRepName);
            command.Parameters.Add("P_Sex", salerep.Sex);
            command.Parameters.Add("P_Dob", salerep.Dob);
            command.Parameters.Add("P_Pob", salerep.Pob);
            command.Parameters.Add("P_Address", salerep.Address);
            command.Parameters.Add("P_NATIONALCARDNUMBER", salerep.NATIONALCARDNUMBER);
            command.ExecuteNonQuery();
        }

        public static void Delete(int salerepId)
        {
            try
            {
                OracleCommand command = new OracleCommand("SALEREPDELETE", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_SalerepId", salerepId);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
