using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TOA_s_Project.Database;

namespace TOA_s_Project
{

    class DBInventory
    {
        /*  public static MySqlConnection GetConnection()
          {
              string sql = "datasource=localhost;username=root;password=sholehhudin1995;database=toa;";
              MySqlConnection con = new MySqlConnection();
              try
              {
                  con.Open();
              }
              catch (MySqlException ex)
              {
                  MessageBox.Show("Failed to Connect ! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              return con;
          }
  */
     
        public static void AddInventory(InventoryAtt inv)
        {
            Connection connect = new Connection();
            string sql = "INSERT INTO inventory VALUES(NULL, @ns, @name, @barcode, @brand, @type, @quantity, @loc, @desc)";
             MySqlConnection con = connect.conn;
            
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ns", MySqlDbType.VarChar).Value = inv.Serial_Number;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = inv.Item_Name;
            cmd.Parameters.Add("@barcode", MySqlDbType.VarChar).Value = inv.Barcode;
            cmd.Parameters.Add("@brand", MySqlDbType.VarChar).Value = inv.Brand;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = inv.Item_type;
            cmd.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = inv.Quantity;
            cmd.Parameters.Add("@loc", MySqlDbType.VarChar).Value = inv.Location;
            cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = inv.Description;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection Error !" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
       /* public static void UpdateInventory(InventoryAtt inv, string id)
        {

            string sql = "UPDATE inventory SET ns = @ns, item_name = @name, barcode = @barcode, brand = @brand, item_type = @type, quantity = @quantity, location = @location, description = @description WHERE ID = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ns", MySqlDbType.VarChar).Value = inv.Serial_Number;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = inv.Item_Name;
            cmd.Parameters.Add("@barcode", MySqlDbType.VarChar).Value = inv.Barcode;
            cmd.Parameters.Add("@brand", MySqlDbType.VarChar).Value = inv.Brand;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = inv.Item_type;
            cmd.Parameters.Add("@quantity", MySqlDbType.VarChar).Value = inv.Quantity;
            cmd.Parameters.Add("@loc", MySqlDbType.VarChar).Value = inv.Location;
            cmd.Parameters.Add("@desc", MySqlDbType.VarChar).Value = inv.Description;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection Error !" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteInventory(string id)
        {
            string sql = "DELETE FROM inventory WHERE id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
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
            con.Close();
        }*/
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            Connection connect = new Connection();
            //MySqlConnection con = GetConnection();
            MySqlConnection con = connect.conn;

            MySqlCommand cmd = new MySqlCommand(sql, con);
           // MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter();
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
        