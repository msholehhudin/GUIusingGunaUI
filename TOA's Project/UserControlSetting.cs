using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOA_s_Project.Database;
using MySql.Data.MySqlClient;

namespace TOA_s_Project
{
    public partial class UserControlSetting : UserControl
    {
        UserClass up = new UserClass();
        

        private void btnSaveProf_Click(object sender, EventArgs e)
        {
            if (txtNIK.Text.Trim().Length < 1)
            {
                MessageBox.Show("Enter Your NIK");
                return;
            } 
            if (txtPassword.Text.Trim().Length < 1)
            {
                MessageBox.Show("Enter Your Password");
                return;
            } 
            if (txtConPass.Text.Trim().Length < 1)
            {
                MessageBox.Show("Confirm Your Password");
                return;
            } 
            
            
            UpdatePass();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBox1.Checked)
                {
                    txtPassword.PasswordChar = '\0';
                    txtConPass.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '•';
                    txtConPass.PasswordChar = '•';
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNIK.Text != "")
            {
                MySqlConnection con = new MySqlConnection("datasource =localhost" + "; database = toa" + "; username =root " + "; password=sholehhudin1995" + "; SslMode=None;");
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT id, email, fullname, username FROM user WHERE nik = @user", con);
                cmd.Parameters.AddWithValue("@user", int.Parse(txtNIK.Text));
                MySqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtID.Text = da.GetValue(0).ToString();
                    txtNickName.Text = da.GetValue(3).ToString();
                }
                con.Close();
            }
        }


        public UserControlSetting()
        {
            InitializeComponent();
        }

        public void UpdatePass()
        {
            if (txtPassword.Text == txtConPass.Text && txtNickName.Text == FormLogin.T_username)
                {
         
                up.Username = txtNickName.Text;
                up.Password = txtPassword.Text;
                up.UpdateUser(txtID.Text);
                Clear();
            }
            else if (txtNickName.Text != FormLogin.T_username)
            {
                MessageBox.Show("That's not your Account, Boy", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Password doesn't match, Please try again", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void UserControlSetting_Load(object sender, EventArgs e)
        {
            
            
        }

        public void Clear()
        {
           txtNIK.Text = txtID.Text = txtNickName.Text = txtPassword.Text = txtConPass.Text = string.Empty;
        }

    }
}
