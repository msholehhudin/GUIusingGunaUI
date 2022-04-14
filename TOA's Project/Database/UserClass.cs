using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace TOA_s_Project.Database
{

    class UserClass:Connection
    {

        public string log_username { set; get; }
        public string log_password { set; get; }
        public Int32 log_role { set; get; }

        public bool User_verification()
        {
            conn.Open();
            MySqlDataReader rd;
            bool check = false;
            using (var cmd = new MySqlCommand())
            {
                
                cmd.CommandText = "SELECT * FROM user WHERE username = @username AND password = @password";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = log_username;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = log_password;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    //log_role = rd.GetInt32("role");
                    check = true;
                }
             

                conn.Close();

            }
            return check;
        }
    }
}
