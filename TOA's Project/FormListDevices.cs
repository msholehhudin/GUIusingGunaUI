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
    public partial class FormListDevices : Form
    {
        private readonly UserControlList _parent;
        public FormListDevices(UserControlList parent)
        {
            InitializeComponent();
            _parent = parent;
        }
    }
}
