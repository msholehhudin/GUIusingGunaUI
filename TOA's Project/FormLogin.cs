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

namespace TOA_s_Project
{
    public partial class FormLogin : Form
    {
        UserClass dc = new UserClass();
       

        public static string T_username;  
        public static string T_role;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            dc.log_username = txtUsername.Text;
            dc.log_password = txtPassword.Text;
            bool verify = dc.User_verification();

            if(verify == true)
            {
                MessageBox.Show("Successfully Login!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int role = dc.log_role;
                T_username = dc.log_username;
                if (role == 0)
                {
                    T_role = "Super User";
                }
                else if (role == 1)
                {
                    T_role = "Admin User";
                }
                else if (role == 2)
                {
                    T_role = "Standard User";
                }
                
                FormMain main = new FormMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
