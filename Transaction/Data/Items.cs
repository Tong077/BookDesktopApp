using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction.Modols;

namespace Transaction.Data
{
    public class Items
    {
        public static DataTable GetAll()
        {
            DataTable table = new DataTable();
            OracleCommand command = new OracleCommand("ITEMGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(table);

            return table;
        }

        public static Item Get(int itemId)
        {
            Item item = null;
            OracleCommand command = new OracleCommand("ITEMGET", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_ItemId", itemId);
            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                item = new Item();
                item.ItemId = Convert.ToInt32(reader["ItemId"]);
                item.ItemName = reader["ItemName"].ToString();
                item.ItemDescription = reader["ItemDescription"].ToString();
                item.Quantity = Convert.IsDBNull(reader["Quantity"]) ? 0 : Convert.ToDouble(reader["Quantity"]);
                item.Price = Convert.IsDBNull(reader["Price"]) ? 0 : Convert.ToDouble(reader["Price"]);
            }
            return item;
        }
        public static void Add(Item item)
        {
            OracleCommand command = new OracleCommand("ItemAdd", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(" P_ItemName", item.ItemName);
            command.Parameters.Add(" P_ItemDescription", item.ItemDescription);
            command.Parameters.Add(" P_Quantity", item.Quantity);
            command.Parameters.Add(" P_Price", item.Price);

            command.ExecuteNonQuery();

        }
        public static void Update(Item item)
        {
            OracleCommand command = new OracleCommand("ItemUpdate",BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(" P_ItemId", item.ItemId);
            command.Parameters.Add(" P_ItemName", item.ItemName);
            command.Parameters.Add(" P_Itemdescription", item.ItemDescription);
            command.Parameters.Add(" P_Quantity", item.Quantity);
            command.Parameters.Add(" P_Price", item.Price);

            command.ExecuteNonQuery();
        }
        public static void Delete(int itemId)
        {
            OracleCommand command = new OracleCommand("ItemDelete", BookShopContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(" P_ItemId", itemId);
            command.ExecuteNonQuery();
        }
    }
}
