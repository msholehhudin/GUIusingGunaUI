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
    public partial class FormInventoryInfo : Form
    {
        //InventoryClass inv = new InventoryClass();
        public FormInventoryInfo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             /*FormInventory form = new FormInventory();
             form.ShowDialog();*/
        }

        private void FormInventoryInfo_Load(object sender, EventArgs e)
        {
            /*inv.ShowDatabase();
            dgvInventory.DataSource = inv.*/
        }
        public void READ()
        {
            /*inv.ShowData();
            dgvInventory.DataSource = inv.dt;*/
            
        }
        public void read()
        {
            /*dgvInventory.DataSource = null;
            inv.Datagrid_data();
            dgvInventory.DataSource = inv.dt;*/
        }
        public void Display()
        {
            DBInventory.DisplayAndSearch("SELECT * FROM inventory", dgvInventory);
        }
        private void FormInventoryInfo_Shown(object sender, EventArgs e)
        {
            /* inv.Datagrid_data();
             dgvInventory.DataSource = inv.dt;*/
            Display();
        }
     
    }
}
