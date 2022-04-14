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
    
    public partial class UserControlInventory : UserControl
    {
        InventoryClass inv = new InventoryClass();
        public UserControlInventory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormInventory form = new FormInventory(this);
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void Display()
        {
            inv.Datagrid_data();
            dataGridView1.DataSource = inv.dt;
        }

        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlInventory_Load(object sender, EventArgs e)
        {
            /* inv.ShowDatabase();
             dgvInventory.DataSource = inv.DT;*/
            /*inv.Datagrid_data();
            dataGridView1.DataSource = inv.dt;*/
        }
        public void READ()
        {
           /* dgvInventory.DataSource = null;
            inv.ShowData();
            dgvInventory.DataSource = inv.dt;*/
        }

        private void UserControlInventory_Load_1(object sender, EventArgs e)
        {
            Display();
        }
    }
}
