﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOA_s_Project
{
    public partial class UserControlList : UserControl
    {
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
    }
}
