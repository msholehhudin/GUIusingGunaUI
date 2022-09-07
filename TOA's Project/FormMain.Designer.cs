
namespace TOA_s_Project
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.lsBtn = new System.Windows.Forms.Button();
            this.btnEditProf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.woBtn = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnMonitoring = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimeAndDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.userControlWriteOff2 = new TOA_s_Project.UserControlWriteOff();
            this.userControlInventory2 = new TOA_s_Project.UserControlInventory();
            this.userControlSetting2 = new TOA_s_Project.UserControlSetting();
            this.userControlList2 = new TOA_s_Project.UserControlList();
            this.userControlDashboard2 = new TOA_s_Project.UserControlDashboard();
            this.userControlTry1 = new TOA_s_Project.UserControlTry();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.pnlMove);
            this.panel1.Controls.Add(this.lsBtn);
            this.panel1.Controls.Add(this.btnEditProf);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.woBtn);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnMonitoring);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 560);
            this.panel1.TabIndex = 0;
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.White;
            this.pnlMove.Location = new System.Drawing.Point(3, 188);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(6, 48);
            this.pnlMove.TabIndex = 0;
            // 
            // lsBtn
            // 
            this.lsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsBtn.FlatAppearance.BorderSize = 0;
            this.lsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsBtn.ForeColor = System.Drawing.Color.White;
            this.lsBtn.Image = global::TOA_s_Project.Properties.Resources.inventory_white;
            this.lsBtn.Location = new System.Drawing.Point(0, 393);
            this.lsBtn.Name = "lsBtn";
            this.lsBtn.Size = new System.Drawing.Size(234, 42);
            this.lsBtn.TabIndex = 4;
            this.lsBtn.Text = "          TOA\'s Devices";
            this.lsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lsBtn.UseVisualStyleBackColor = true;
            this.lsBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditProf
            // 
            this.btnEditProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditProf.FlatAppearance.BorderSize = 0;
            this.btnEditProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProf.ForeColor = System.Drawing.Color.White;
            this.btnEditProf.Image = global::TOA_s_Project.Properties.Resources.Logout_white;
            this.btnEditProf.Location = new System.Drawing.Point(0, 432);
            this.btnEditProf.Name = "btnEditProf";
            this.btnEditProf.Size = new System.Drawing.Size(234, 64);
            this.btnEditProf.TabIndex = 3;
            this.btnEditProf.Text = "          Setting";
            this.btnEditProf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProf.UseVisualStyleBackColor = true;
            this.btnEditProf.Click += new System.EventHandler(this.btnEditProf_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "           History";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::TOA_s_Project.Properties.Resources.Logout_white;
            this.btnLogout.Location = new System.Drawing.Point(0, 496);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(234, 64);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // woBtn
            // 
            this.woBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.woBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.woBtn.FlatAppearance.BorderSize = 0;
            this.woBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.woBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woBtn.ForeColor = System.Drawing.Color.White;
            this.woBtn.Location = new System.Drawing.Point(0, 331);
            this.woBtn.Name = "woBtn";
            this.woBtn.Size = new System.Drawing.Size(234, 31);
            this.woBtn.TabIndex = 0;
            this.woBtn.Text = "             Write-Off";
            this.woBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.woBtn.UseVisualStyleBackColor = true;
            this.woBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::TOA_s_Project.Properties.Resources.inventory_white;
            this.btnInventory.Location = new System.Drawing.Point(0, 289);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(234, 42);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "          Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnMonitoring
            // 
            this.btnMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonitoring.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonitoring.FlatAppearance.BorderSize = 0;
            this.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitoring.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoring.ForeColor = System.Drawing.Color.White;
            this.btnMonitoring.Image = global::TOA_s_Project.Properties.Resources.monitoring_white;
            this.btnMonitoring.Location = new System.Drawing.Point(0, 242);
            this.btnMonitoring.Name = "btnMonitoring";
            this.btnMonitoring.Size = new System.Drawing.Size(234, 47);
            this.btnMonitoring.TabIndex = 0;
            this.btnMonitoring.Text = "          Monitoring";
            this.btnMonitoring.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonitoring.UseVisualStyleBackColor = true;
            this.btnMonitoring.Click += new System.EventHandler(this.btnMonitoring_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::TOA_s_Project.Properties.Resources.dashboard_kecil;
            this.btnDashboard.Location = new System.Drawing.Point(0, 190);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(234, 52);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monitoring and Reporting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOA\'s System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TOA_s_Project.Properties.Resources.Logo_Trans_7;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 190);
            this.panel4.TabIndex = 1;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.pnlMove;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(234, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 61);
            this.panel2.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(620, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(27, 21);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "{?}";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(540, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome, ";
            // 
            // lblTimeAndDate
            // 
            this.lblTimeAndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeAndDate.AutoSize = true;
            this.lblTimeAndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAndDate.ForeColor = System.Drawing.Color.White;
            this.lblTimeAndDate.Location = new System.Drawing.Point(534, 8);
            this.lblTimeAndDate.Name = "lblTimeAndDate";
            this.lblTimeAndDate.Size = new System.Drawing.Size(22, 17);
            this.lblTimeAndDate.TabIndex = 0;
            this.lblTimeAndDate.Text = "{?}";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.lblTimeAndDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(234, 525);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(747, 35);
            this.panel3.TabIndex = 0;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.userControlTry1);
            this.pnlCenter.Controls.Add(this.userControlWriteOff2);
            this.pnlCenter.Controls.Add(this.userControlInventory2);
            this.pnlCenter.Controls.Add(this.userControlSetting2);
            this.pnlCenter.Controls.Add(this.userControlList2);
            this.pnlCenter.Controls.Add(this.userControlDashboard2);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(234, 61);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(747, 464);
            this.pnlCenter.TabIndex = 0;
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // userControlWriteOff2
            // 
            this.userControlWriteOff2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlWriteOff2.Location = new System.Drawing.Point(0, 0);
            this.userControlWriteOff2.Name = "userControlWriteOff2";
            this.userControlWriteOff2.Size = new System.Drawing.Size(747, 464);
            this.userControlWriteOff2.TabIndex = 6;
            // 
            // userControlInventory2
            // 
            this.userControlInventory2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlInventory2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlInventory2.Location = new System.Drawing.Point(0, 0);
            this.userControlInventory2.Name = "userControlInventory2";
            this.userControlInventory2.Size = new System.Drawing.Size(747, 464);
            this.userControlInventory2.TabIndex = 5;
            // 
            // userControlSetting2
            // 
            this.userControlSetting2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSetting2.Location = new System.Drawing.Point(0, 0);
            this.userControlSetting2.Name = "userControlSetting2";
            this.userControlSetting2.Size = new System.Drawing.Size(747, 464);
            this.userControlSetting2.TabIndex = 0;
            // 
            // userControlList2
            // 
            this.userControlList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlList2.Location = new System.Drawing.Point(0, 0);
            this.userControlList2.Name = "userControlList2";
            this.userControlList2.Size = new System.Drawing.Size(747, 464);
            this.userControlList2.TabIndex = 1;
            // 
            // userControlDashboard2
            // 
            this.userControlDashboard2.BackColor = System.Drawing.Color.White;
            this.userControlDashboard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlDashboard2.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard2.Name = "userControlDashboard2";
            this.userControlDashboard2.Size = new System.Drawing.Size(747, 464);
            this.userControlDashboard2.TabIndex = 0;
            // 
            // userControlTry1
            // 
            this.userControlTry1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTry1.Location = new System.Drawing.Point(0, 0);
            this.userControlTry1.Name = "userControlTry1";
            this.userControlTry1.Size = new System.Drawing.Size(747, 464);
            this.userControlTry1.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 560);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOA\'s Project";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button woBtn;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnMonitoring;
        private System.Windows.Forms.Panel pnlMove;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimeAndDate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Timer timerDateAndTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditProf;
        private System.Windows.Forms.Button lsBtn;
        private UserControlWriteOff userControlWriteOff2;
        private UserControlInventory userControlInventory2;
        private UserControlSetting userControlSetting2;
        private UserControlList userControlList2;
        private UserControlDashboard userControlDashboard2;
        private UserControlTry userControlTry1;
    }
}

