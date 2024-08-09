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
    public class Vendors
    {
        public static DataTable Getall()
        {
            DataTable table = new DataTable();
            OracleCommand command = new OracleCommand("VendorGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public static Vendor Get(int VendorId)
        {
            Vendor vendor = new Vendor();
            OracleCommand command = new OracleCommand("VendorGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("VendorId", VendorId);
            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                vendor.VendorId = Convert.ToInt32(reader["VendorId"]);
                vendor.VendorName = reader["VendorName"].ToString();
                vendor.CompanyName = reader["CompanyName"].ToString();
                vendor.Phone = reader["Phone"].ToString();
                vendor.Email = reader["Email"].ToString();
                vendor.Address = reader["Address"].ToString();
            }
            return vendor;
        }
        public static void Add(Vendor vendor)
        {
            try
            {
                OracleCommand command = new OracleCommand("VENDORADD", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_VendorName", vendor.VendorName);
                command.Parameters.Add("P_CompanyName", vendor.CompanyName);
                command.Parameters.Add("P_Phone", vendor.Phone);
                command.Parameters.Add("P_Email", vendor.Email);
                command.Parameters.Add("P_Address", vendor.Address);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Update(Vendor vendor)
        {
            try
            {
                OracleCommand command = new OracleCommand(" VENDORUPDATE", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("  P_VENDORID", vendor.VendorId);
                command.Parameters.Add(" P_VENDORNAME", vendor.VendorName);
                command.Parameters.Add(" P_CompanyName", vendor.CompanyName);
                command.Parameters.Add(" P_Phone", vendor.Phone);
                command.Parameters.Add(" P_Email", vendor.Email);
                command.Parameters.Add(" P_Address", vendor.Address);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Delete(int vendorId)
        {
            try
            {
                OracleCommand command = new OracleCommand("VENDORDELETE", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_VendorId", vendorId);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

