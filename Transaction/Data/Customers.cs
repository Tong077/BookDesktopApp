using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transaction.Modols;

namespace Transaction.Data
{
    public class Customers
    {
        public static DataTable GetAll()
        {
            DataTable table = new DataTable();
            OracleCommand command = new OracleCommand("CustomerGet", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public static Customer Get(int CustomerId)
        {
            Customer customer = new Customer();
            OracleCommand command = new OracleCommand("CustomerGet", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_CustomerId", CustomerId);
            OracleDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                customer.CustomerId = Convert.ToInt32(reader["Customerid"]);
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.CompanyName = reader["CompanyName"].ToString();
                customer.Phone = reader["Phone"].ToString();
                customer.Email = reader["Email"].ToString();
                customer.Address = reader["Address"].ToString();
            }
            return customer;
        }
        public static void Add(Customer customer)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerAdd", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(" P_CustomerName", customer.CustomerName);
                command.Parameters.Add(" P_CompanyName", customer.CompanyName);
                command.Parameters.Add(" P_Phone", customer.Phone);
                command.Parameters.Add(" P_Email", customer.Email);
                command.Parameters.Add("P_Address", customer.Address);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Update(Customer customer)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerUpdate", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(" P_CusomterId", customer.CustomerId);
                command.Parameters.Add(" P_CustomerName", customer.CustomerName);
                command.Parameters.Add(" P_CompanyName", customer.CompanyName);
                command.Parameters.Add(" P_Phone", customer.Phone);
                command.Parameters.Add(" P_Email", customer.Email);
                command.Parameters.Add("P_Address", customer.Address);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void Delete(int CustomerId)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerDelete", BookShopContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("CustomerId", CustomerId);

                command.ExecuteNonQuery();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

