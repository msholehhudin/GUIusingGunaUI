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
            userControlInventory1.Visible = false;
            userControlWriteOff1.Visible = false;
            userControlSetting1.Visible = false;
            userControlList1.Visible = false;
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
            userControlDashboard1.Visible = true;
            userControlInventory1.Visible = false;
            userControlWriteOff1.Visible = false;
            userControlSetting1.Visible = false;
            userControlList1.Visible = false;
        }

        private void btnMonitoring_Click(object sender, EventArgs e)
        {
            MovePanel(btnMonitoring);
            userControlDashboard1.Visible = false;
            userControlInventory1.Visible = false;
            userControlWriteOff1.Visible = false;
            userControlSetting1.Visible = false;
            userControlList1.Visible = false;

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MovePanel(btnInventory);
            userControlDashboard1.Visible = false;
            userControlInventory1.Visible = true;
            userControlWriteOff1.Visible = false;
            userControlSetting1.Visible = false;
            userControlList1.Visible = false;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            lblTimeAndDate.Text = DateTime.Now.ToString("dd-MMMM-yyyy HH:mm:ss tt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControlDashboard1.Visible = false;
            userControlInventory1.Visible = false;
            userControlWriteOff1.Visible = true;
            userControlSetting1.Visible = false;
            userControlList1.Visible = false;
        }

        private void btnEditProf_Click(object sender, EventArgs e)
        {
            MovePanel(btnEditProf);
            userControlDashboard1.Visible = false;
            userControlInventory1.Visible = false;
            userControlWriteOff1.Visible = false;
            userControlSetting1.Visible = true;
            userControlList1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovePanel(btnEditProf);
            userControlDashboard1.Visible = false;
            userControlInventory1.Visible = false;
            userControlWriteOff1.Visible = false;
            userControlSetting1.Visible = false;
            userControlList1.Visible = true;
        }
    }
}
