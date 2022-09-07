using System;
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
    public partial class FormMain : Form
    {
        /*UserControlDashboard ds = new UserControlDashboard();
        UserControlInventory inv = new UserControlInventory();
        UserControlSetting stting = new UserControlSetting();
        UserControlList ls = new UserControlList();
        UserControlWriteOff wo = new UserControlWriteOff();*/
     /*   UserControlDashboard ds;
        UserControlInventory inv;
        UserControlSetting stting;
        UserControlList ls;
        UserControlWriteOff wo;
        */
        public FormMain()
        {
            InitializeComponent();
        }

        private void MovePanel (Control btn)
        {
            pnlMove.Top = btn.Top;
            pnlMove.Height = btn.Height;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            lblUsername.Text = FormLogin.T_username;
            timerDateAndTime.Start();
            userControlInventory2.Visible = false;
            userControlWriteOff2.Visible = false;
            userControlSetting2.Visible = false;
            userControlList2.Visible = false;
            userControlTry1.Visible = false;
            /* inv.Visible = false;
             stting.Visible = false;
             ls.Visible = false;
             wo.Visible = false;*/
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure to Logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(logout == DialogResult.Yes)
            {
                MovePanel(btnLogout);
                timerDateAndTime.Stop();
                new FormLogin().Show();
                this.Hide();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(btnDashboard);
            userControlDashboard2.Visible = true;
            userControlInventory2.Visible = false;
            userControlWriteOff2.Visible = false;
            userControlSetting2.Visible = false;
            userControlList2.Visible = false;
            userControlTry1.Visible = false;
            /*  ds.Visible = true;
              inv.Visible = false;
              stting.Visible = false;
              ls.Visible = false;
              wo.Visible = false;*/
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            MovePanel(btnMonitoring);
            userControlDashboard2.Visible = false;
            userControlInventory2.Visible = false;
            userControlWriteOff2.Visible = false;
            userControlSetting2.Visible = false;
            userControlList2.Visible = false;
            userControlTry1.Visible = false;
            /* ds.Visible = false;
             inv.Visible = false;
             stting.Visible = false;
             ls.Visible = false;
             wo.Visible = false;*/
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MovePanel(btnInventory);
            userControlDashboard2.Visible = false;
            userControlInventory2.Visible = true;
            userControlWriteOff2.Visible = false;
            userControlSetting2.Visible = false;
            userControlList2.Visible = false;
            userControlTry1.Visible = false;
            /*  ds.Visible = false;
              inv.Visible = true;
              stting.Visible = false;
              ls.Visible = false;
              wo.Visible = false;*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MovePanel(woBtn);
            userControlDashboard2.Visible = false;
            userControlInventory2.Visible = false;
            userControlWriteOff2.Visible = true;
            userControlSetting2.Visible = false;
            userControlList2.Visible = false;
            userControlTry1.Visible = false;
            /*ds.Visible = false;
            inv.Visible = false;
            stting.Visible = false;
            ls.Visible = false;
            wo.Visible = true;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovePanel(lsBtn);
            userControlDashboard2.Visible = false;
            userControlInventory2.Visible = false;
            userControlWriteOff2.Visible = false;
            userControlList2.Visible = true;
            userControlSetting2.Visible = false;
            userControlTry1.Visible = false;
            /*ds.Visible = false;
            inv.Visible = false;
            stting.Visible = false;
            ls.Visible = true;
            wo.Visible = false;*/
        }
        private void btnEditProf_Click(object sender, EventArgs e)
        {
            MovePanel(btnEditProf);
            userControlDashboard2.Visible = false;
            userControlInventory2.Visible = false;
            userControlWriteOff2.Visible = false;
            userControlList2.Visible = false;
            userControlSetting2.Visible = true;
            userControlTry1.Visible = false;
            /*ds.Visible = false;
            inv.Visible = false;
            stting.Visible = true;
            ls.Visible = false;
            wo.Visible = false;*/
        }

       

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblTimeAndDate.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovePanel(button1);
            userControlDashboard2.Visible = false;
            userControlInventory2.Visible = false;
            userControlWriteOff2.Visible = false;
            userControlList2.Visible = false;
            userControlSetting2.Visible = false;
            userControlTry1.Visible = true;
        }
    }
}
