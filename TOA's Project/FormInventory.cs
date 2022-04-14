﻿using System;
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
        private readonly UserControlInventory _parent;
        public FormInventory(UserControlInventory parent)
        {
            InitializeComponent();
            _parent = parent;
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
                Clear();
            }
            _parent.Display();
        }
        public void Clear()
        {
            SerialNumber.Text = itemName.Text = barcode.Text = brand.Text = itemType.Text = quantity.Text = location.Text = description.Text = string.Empty;
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
            inv.AddInventory();
        }
    }
}
