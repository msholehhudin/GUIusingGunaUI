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
    public partial class FormListDevices : Form
    {
        ListDevices ls = new ListDevices();
        private readonly UserControlList _parent;
        public FormListDevices(UserControlList parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void Create()
        {
            ls.Serial_Number = SerialNumber.Text;
            ls.Item_Name = itemName.Text;
            ls.Barcode = barcode.Text;
            ls.Brand = brand.Text;
            ls.Item_type = itemType.Text;
            ls.Quantity = quantity.Text;
            ls.Location = location.Text;
            ls.Description = description.Text;
            ls.pic = FormLogin.T_username;
            ls.AddListData();
        }
    
        public void Clear()
        {
            SerialNumber.Text = itemName.Text = barcode.Text = brand.Text = itemType.Text = quantity.Text = description.Text = string.Empty;
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                Create();
                Clear();
            }
          /*  if (btnSave.Text == "Update")
            {
                InventoryAtt att = new InventoryAtt(SerialNumber.Text.Trim(), itemName.Text.Trim(), barcode.Text.Trim(), brand.Text.Trim(), itemType.Text.Trim(), quantity.Text.Trim(), location.Text.Trim(), description.Text.Trim());
                inv.UpdateInventory(att, id);
                Clear();
            }*/
            _parent.Display();
        }
    }
}
