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
    public partial class UserControlDashboard : UserControl
    {
        InventoryClass cnt = new InventoryClass();
        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            cnt.Count("SELECT COUNT(id) FROM inventory");
            lblInventory.Text = cnt.hitung;

            cnt.Count("SELECT COUNT(id) FROM writeoff");
            labelWO.Text = cnt.hitung;
            
            cnt.Count("SELECT COUNT(id) FROM listdevices");
            labelListDevices.Text = cnt.hitung;

            cnt.Count("SELECT COUNT(id) FROM user");
            labelUser.Text = cnt.hitung;
        }
    }
}
