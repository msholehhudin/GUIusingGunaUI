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
    public partial class UserControlWriteOff : UserControl
    {
        WriteOff wo = new WriteOff();
        public UserControlWriteOff()
        {
            InitializeComponent();
        }
        public void Display()
        {
            wo.Filter_data("SELECT ns, item_name, barcode, brand, item_type, quantity, location, description, pic FROM writeoff", dgvWO);
        }
        private void UserControlWriteOff_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            wo.Filter_data("SELECT ns, item_name, barcode, brand, item_type, quantity, location, description, pic FROM writeoff", dgvWO);
        }
    }
}
