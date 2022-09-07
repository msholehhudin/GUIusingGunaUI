using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace TOA_s_Project.Database
{
    class History:Connection
    {
        public string name { set; get; }
        public string action { set; get; }
        public string item_name { set; get; }
        public string serial_number { set; get; }
        public string time { set; get; }

        public void AddInventory()
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO history VALUES(NULL, @name, @action, @item_name,@serial_number, @date)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@action", MySqlDbType.VarChar).Value = action;
                cmd.Parameters.Add("@item_name", MySqlDbType.VarChar).Value = item_name;
                cmd.Parameters.Add("@serial_number", MySqlDbType.VarChar).Value = serial_number;
                cmd.Parameters.Add("@date", MySqlDbType.VarChar).Value = time;
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }
        public void Shows(String query_filter, DataGridView dgv)
        {
            string sql = query_filter;
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }
    }
}
