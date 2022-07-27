using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOA_s_Project.Database
{
    class WriteOff:Connection
    {
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

        //public DataSet ds = new DataSet();

        public void Filter_data(String query_filter, DataGridView dgv)
        {
            string sql = query_filter;
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        public void AddWriteOff()
        {

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO writeoff VALUES(NULL, @ns, @name, @barcode, @brand, @type, @quantity, @loc, @desc, @pic)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;


                //cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
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

    }
}

