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
    public partial class FormRegister : Form
    {
        UserClass rgstr = new UserClass();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void Create()
        {
            rgstr.Email = txtEmail.Text;
            rgstr.Full_Name = txtFullname.Text;
            rgstr.Username = txtUsername.Text;
            rgstr.Password = txtPassword.Text;
            rgstr.AddUser();
        }

        public void Clear()
        {
            txtEmail.Text = txtFullname.Text = txtUsername.Text = txtPassword.Text = txtConPas.Text = string.Empty;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Length < 1)
            {
                MessageBox.Show("Email is Empty");
                return;
            }  
            if (txtFullname.Text.Trim().Length < 1)
            {
                MessageBox.Show("Full Name is Empty");
                return;
            }  
            if (txtUsername.Text.Trim().Length < 1)
            {
                MessageBox.Show("Nick Name is Empty");
                return;
            }  
            if (txtPassword.Text.Trim().Length < 1)
            {
                MessageBox.Show("Password is Empty");
                return;
            }
            if (txtConPas.Text.Trim().Length < 1)
            {
                MessageBox.Show("Password is Empty");
                return;
            }
            if (btnRegister.Text == "REGISTER")
            {
                Create();
                Clear();
            }
        }
    }
}
