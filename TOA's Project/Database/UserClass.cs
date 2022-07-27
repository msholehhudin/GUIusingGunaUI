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
        public string Email { set; get; }
        public string Full_Name { set; get; }
        public string Username { set; get; }
        public string nik { set; get; }
        public string Password { set; get; }

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
                    
                    check = true;
                }
             

                conn.Close();

            }
            return check;
        }
        public void AddUser()
        {

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO user VALUES(NULL, @email, @fullname, @username, @password)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = Full_Name;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = Password;
              

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
        public void UpdateUser(string id)
        {

            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "UPDATE user SET email = @email, fullname = @fullname, username = @username, password = @password WHERE id = @id";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;


                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
                cmd.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = Full_Name;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = Username;
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = SecureData.EncryptData(Password);
          

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
        public void Showdata(string query_filter, DataGridView dgv)
        {
            string sql = query_filter;
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;


        }
        
        }
    }

