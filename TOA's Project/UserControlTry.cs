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
    public partial class UserControlTry : UserControl
    {
        History log = new History();
        public UserControlTry()
        {
            InitializeComponent();
        }

        public void Display()
        {
            log.Shows("SELECT name,action,item_name,serial_number,date FROM history", dataGridView1);
        }
        private void UserControlTry_Load(object sender, EventArgs e)
        {
            /* DateTime dateTime = DateTime.Now;

             lblHistory.Text = FormLogin.T_username + " baru saja melakukan pada " + dateTime;*/
            Display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            log.Shows("SELECT name,action,item_name,serial_number,date FROM history", dataGridView1);
        }
    }
}
