using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Transaction.Models;

namespace Transaction.Data
{
    public class Adjustments
    {
        public static DataTable GetAll()
        {
            DataTable table = new DataTable();
            OracleCommand command = new OracleCommand("ADJUSTMENTGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(table);

            return table;

        }
        public static void Get(int AdjustmentId)
        {
            Adjustment adjustment = null;
            OracleCommand command = new OracleCommand("ADJUSTMENTGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AdjustmentId", AdjustmentId);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                adjustment = new Adjustment();
                adjustment.AdjustmentId = Convert.ToInt32( reader["AdjustmentId"].ToString());
                adjustment.AdjustmentDate = Convert.ToDateTime(reader["AdjustmentDate"].ToString());
                adjustment.RefNumber = reader["RefNumber"].ToString();
                adjustment.AppuserId = Convert.ToInt32(reader["AppUserId"].ToString());
                adjustment.Note = reader["Not"].ToString();
            }
        }
        public static int Add(Adjustment adjustment)
        {
            int adjustmentid = 0;
            OracleCommand command = new OracleCommand("ADJUSTMENTADD", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AdjustmentDate", OracleDbType.Date).Value = adjustment.AdjustmentDate;
            command.Parameters.Add("P_RefNumber", OracleDbType.Varchar2).Value = adjustment.RefNumber;
            command.Parameters.Add("P_AppUserId", OracleDbType.Int32).Value = adjustment.AppuserId;
            command.Parameters.Add("P_Note", OracleDbType.Varchar2).Value = adjustment.Note;

            command.Parameters.Add("P_AdjustmentId", OracleDbType.Int32).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            
            adjustmentid = Convert.ToInt32(command.Parameters["P_AdjustmentId"].Value.ToString());
            return adjustmentid;
        }
        public static void Update(Adjustment adjustment) 
        {
            OracleCommand command = new OracleCommand("ADJUSTMENTUPADTE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("AdjustmentId",OracleDbType.Int32).Value = adjustment.AdjustmentId;
            command.Parameters.Add("AdjustmentDate", OracleDbType.Date).Value = adjustment.AdjustmentDate;
            command.Parameters.Add("RefNumber", OracleDbType.Varchar2).Value = adjustment.RefNumber;
            command.Parameters.Add("AppuserId", OracleDbType.Int32).Value = adjustment.AppuserId;
            command.Parameters.Add("Note", OracleDbType.Int32).Value = adjustment.Note;

            command.ExecuteNonQuery ();
        
        }
        public static void Delete(int adjustmentId)
        {
            OracleCommand command = new OracleCommand("ADJUSTMENTDELETE", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("AdjustmentId", adjustmentId);
            command.Parameters["AdjustmentId"].Value = adjustmentId;
            command.ExecuteNonQuery ();
            
        }
    }
}
