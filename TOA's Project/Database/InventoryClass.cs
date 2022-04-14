using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using TOA_s_Project.Database;
using System.Windows.Forms;

namespace TOA_s_Project.Database
{
    class InventoryClass:Connection
    {
        //PROPERTIES
        public string Serial_Number { get; set; }
        public string Item_Name { get; set; }
        public string Barcode { get; set; }
        public string Brand { get; set; }
        public string Item_type { get; set; }
        public string Quantity { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        //FOR ID
        public string id { get; set; }


        /*public string search_text;*/
        private string query = "SELECT * FROM inventory";

        //Read Properties
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();
       
        
        public void Datagrid_data()
        {
            dt.Clear();
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            da.Fill(ds);
            dt = ds.Tables[0];
        }

        public void Filter_data()
        {
        /*    dt.Clear();
            string query_filter = "SELECT * FROM inventory WHERE item_name='" + search_text + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(query_filter, conn);
            da.Fill(ds);
            dt = ds.Tables[0];*/
        }

        public void AddInventory()
        {

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO inventory VALUES(NULL, @ns, @name, @barcode, @brand, @type, @quantity, @loc, @desc)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@ns", MySqlDbType.VarChar).Value = Serial_Number;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = Item_Name;
                cmd.Parameters.Add("@barcode", MySqlDbType.VarChar).Value = Barcode;
                cmd.Parameters.Add("@brand", MySqlDbType.VarChar).Value = Brand;
                cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = Item_type;
                cmd.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = Quantity;
                cmd.Parameters.Add("@loc", MySqlDbType.VarChar).Value = Location;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = Description;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Connection Error !" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }

        }

        public void UpdateInventory()
        {

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE inventory SET ns=@ns, item_name=@name, barcode=@barcode, brand=@brand, item_type=@type, quantity=@quantity, location=@loc, description=@desc WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@ns", MySqlDbType.VarChar).Value = Serial_Number;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = Item_Name;
                cmd.Parameters.Add("@barcode", MySqlDbType.VarChar).Value = Barcode;
                cmd.Parameters.Add("@brand", MySqlDbType.VarChar).Value = Brand;
                cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = Item_type;
                cmd.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = Quantity;
                cmd.Parameters.Add("@loc", MySqlDbType.VarChar).Value = Location;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = Description;

                cmd.Parameters.Add("@did", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }
        public void DeleteInventory()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM inventory WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@did", MySqlDbType.VarChar).Value = id;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
            
