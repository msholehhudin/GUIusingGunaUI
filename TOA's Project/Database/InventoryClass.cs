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
        public string pic { get; set; }

        //FOR ID
        public string id { get; set; }

        //Read Properties
       
        public DataSet ds = new DataSet();

        public void Filter_data(String query_filter, DataGridView dgv)
        {
            string sql = query_filter;
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        public void AddInventory()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO inventory VALUES(NULL, @ns, @name, @barcode, @brand, @type, @quantity, @loc, @desc, @pic)";
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
                cmd.Parameters.Add("@pic", MySqlDbType.VarChar).Value = pic;

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
       
        public void UpdateInventory(InventoryAtt att, string id)
        {

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE inventory SET ns = @ns, item_name = @item_name, barcode = @barcode, brand = @brand, item_type = @item_type, quantity = @quantity, location = @location, description = @description WHERE id = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;


                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@ns", MySqlDbType.VarChar).Value = att.Serial_Number;
                cmd.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = att.Item_Name;
                cmd.Parameters.Add("@barcode", MySqlDbType.VarChar).Value = att.Barcode;
                cmd.Parameters.Add("@brand", MySqlDbType.VarChar).Value = att.Brand;
                cmd.Parameters.Add("@item_type", MySqlDbType.VarChar).Value = att.Item_type;
                cmd.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = att.Quantity;
                cmd.Parameters.Add("@location", MySqlDbType.VarChar).Value = att.Location;
                cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = att.Description;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Connection Error !" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }

        }
        public void DeleteInventory(string id)
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "DELETE FROM inventory WHERE id=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Connection Error !" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        public void WriteOff(InventoryAtt wo, string id)
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO write-off VALUES(NULL, @ns, @name, @barcode, @brand, @type, @quantity, @loc, @desc, @pic)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@ns", MySqlDbType.VarChar).Value = wo.Serial_Number;
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = wo.Item_Name;
                cmd.Parameters.Add("@barcode", MySqlDbType.VarChar).Value = wo.Barcode;
                cmd.Parameters.Add("@brand", MySqlDbType.VarChar).Value = wo.Brand;
                cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = wo.Item_type;
                cmd.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = wo.Quantity;
                cmd.Parameters.Add("@loc", MySqlDbType.VarChar).Value = wo.Location;
                cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = wo.Description;
                cmd.Parameters.Add("@pic", MySqlDbType.VarChar).Value = pic;

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
    }
}
            
