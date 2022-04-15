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
        FormInventory form;
        InventoryClass inv = new InventoryClass();
        public UserControlInventory()
        {
            InitializeComponent();
            form = new FormInventory(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Display()
        {
            inv.Filter_data("SELECT * FROM inventory", dataGridView1);
        }
        private void UserControlInventory_Load_1(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        { 
            inv.Filter_data("SELECT * FROM inventory WHERE item_name LIKE '%" + txtSearch.Text + "%'", dataGridView1);
           
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                
                form.Clear();
                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.Serial_Number = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.Item_Name = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.Barcode = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.Brand = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.Item_Type = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.Quantity = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.Location = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.Description = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Are You Sure Want to Delete this Data ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    inv.DeleteInventory(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
