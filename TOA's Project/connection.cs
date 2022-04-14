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
    public partial class connection : Form
    {
        //UserClass con = new UserClass();
        //DBInventory con = new DBInventory();
        Connection con = new Connection();
        public connection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //con.conn.Open();
                // DBInventory.GetConnection();
                con.conn.Open();
                label1.Text = "Konek.";
                label1.ForeColor = Color.Green;
                //con.conn.Close();
            }
            catch
            {
                label1.Text = "Failed";
            }
        }
    }
}
