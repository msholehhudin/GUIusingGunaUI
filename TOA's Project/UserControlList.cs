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
    public partial class UserControlList : UserControl
    {
        ListDevices db = new ListDevices();
        FormListDevices form;
        
        public UserControlList()
        {
            InitializeComponent();
            form = new FormListDevices(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
        }
        public void Display()
        {
            db.Filter_data("SELECT * FROM listdevices", dataGridView1);
        }

        private void UserControlList_Load(object sender, EventArgs e)
        {
            Display();
        }
       
    }
}
