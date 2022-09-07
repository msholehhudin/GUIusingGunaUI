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
using MySql.Data.MySqlClient;

namespace TOA_s_Project
{
    public partial class FormInventory : Form
    {
        InventoryClass inv = new InventoryClass();
        History hstry = new History();
        private readonly UserControlInventory _parent;
        public string id, Serial_Number, Item_Name, Barcode, Brand, Item_Type, Quantity, Loc, Description;
        public FormInventory(UserControlInventory parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void Create()
        {
            inv.Serial_Number = SerialNumber.Text;
            inv.Item_Name = itemName.Text;
            inv.Barcode = barcode.Text;
            inv.Brand = brand.Text;
            inv.Item_type = itemType.Text;
            inv.Quantity = quantity.Text;
            inv.Location = location.Text;
            inv.Description = description.Text;
            inv.pic = FormLogin.T_username;
            inv.AddInventory();
        }
        public void UpdateInfo()
        {
            lbltext.Text = "Update Inventory";
            btnSave.Text = "Update";
            txtID.Text = id;
            SerialNumber.Text = Serial_Number;
            itemName.Text = Item_Name;
            barcode.Text = Barcode;
            brand.Text = Brand;
            itemType.Text = Item_Type;
            quantity.Text = Quantity;
            location.Text = Loc;
            description.Text = Description;
        }
        public void SaveInfo()
        {
            lbltext.Text = "Add Inventory";
            btnSave.Text = "Save";
        }
        public void history()
        {
            DateTime dateTime = DateTime.Now;
            hstry.name = FormLogin.T_username;
            hstry.item_name = itemName.Text;
            if (btnSave.Text == "Save")
            {
                hstry.action = "Add a new Inventory";
            }
            else
            {
                hstry.action = "Edit an Inventory";
            }
            hstry.serial_number = SerialNumber.Text;
            hstry.time = dateTime.ToString();
            hstry.AddInventory();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (SerialNumber.Text.Trim().Length<1)
            {
                MessageBox.Show("Serial Number is Empty");
                return;
            }
            if (itemName.Text.Trim().Length<1)
            {
                MessageBox.Show("Item Name is Empty");
                return;
            }
            if (barcode.Text.Trim().Length<1)
            {
                MessageBox.Show("Barcode is Empty");
                return;
            }
            if (brand.Text.Trim().Length<1)
            {
                MessageBox.Show("Brand is Empty");
                return;
            }
            if (quantity.Text.Trim().Length<1)
            {
                MessageBox.Show("Quantity is Empty");
                return;
            }
            if (location.Text.Trim().Length<1)
            {
                MessageBox.Show("Location is Empty");
                return;
            }
            if (description.Text.Trim().Length<1)
            {
                MessageBox.Show("Description is Empty");
                return;
            }
            if(btnSave.Text == "Save")
            {
                Create();
                history();
                Clear();
            }
            if(btnSave.Text == "Update")
            {
                InventoryAtt att = new InventoryAtt(SerialNumber.Text.Trim(), itemName.Text.Trim(), barcode.Text.Trim(), brand.Text.Trim(), itemType.Text.Trim(), quantity.Text.Trim(), location.Text.Trim(), description.Text.Trim());
                inv.UpdateInventory(att, id);
                history();
                Clear();
            }
            _parent.Display();
        }
        public void Clear()
        {
            SerialNumber.Text = itemName.Text = barcode.Text = brand.Text = itemType.Text = quantity.Text = location.Text = description.Text = string.Empty;
        }
       
    }
}
