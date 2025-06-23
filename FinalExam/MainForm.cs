using FinalExam.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class MainForm : Form
    {
        private User loggedInUser;
        public MainForm(User loggedInUser)
        {
            InitializeComponent();
            UC_Dashboard uC_Dashboard = new UC_Dashboard();
            addUserControl(uC_Dashboard);
            this.loggedInUser = loggedInUser;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            btnDashboard = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            button1 = new Button();
            BtnBill = new Button();
            pictureBox6 = new PictureBox();
            BtnMedicine = new Button();
            btnRoom = new Button();
            btnDoctor = new Button();
            btnPatien = new Button();
            panelContainer = new Panel();
            backgroundWorker1 = new BackgroundWorker();
            ((ISupportInitialize)pictureBox5).BeginInit();
            ((ISupportInitialize)pictureBox4).BeginInit();
            ((ISupportInitialize)pictureBox3).BeginInit();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox7).BeginInit();
            ((ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(33, 33, 33);
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(171, 52);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.bill;
            pictureBox5.Location = new Point(18, 253);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(26, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bed;
            pictureBox4.Location = new Point(18, 159);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.doctor;
            pictureBox3.Location = new Point(18, 110);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.examination;
            pictureBox2.Location = new Point(18, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dashboard;
            pictureBox1.Location = new Point(18, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BtnBill);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(BtnMedicine);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnRoom);
            panel1.Controls.Add(btnDoctor);
            panel1.Controls.Add(btnPatien);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(-7, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 489);
            panel1.TabIndex = 2;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.transaction_history_9452687;
            pictureBox7.Location = new Point(18, 298);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(26, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 289);
            button1.Name = "button1";
            button1.Size = new Size(171, 52);
            button1.TabIndex = 0;
            button1.Text = "Bill History";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnBill
            // 
            BtnBill.Cursor = Cursors.Hand;
            BtnBill.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBill.Location = new Point(3, 240);
            BtnBill.Name = "BtnBill";
            BtnBill.Size = new Size(171, 52);
            BtnBill.TabIndex = 0;
            BtnBill.Text = "POS";
            BtnBill.UseVisualStyleBackColor = true;
            BtnBill.Click += BtnBill_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.capsule;
            pictureBox6.Location = new Point(18, 204);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(26, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // BtnMedicine
            // 
            BtnMedicine.Cursor = Cursors.Hand;
            BtnMedicine.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMedicine.Location = new Point(3, 195);
            BtnMedicine.Name = "BtnMedicine";
            BtnMedicine.Size = new Size(171, 52);
            BtnMedicine.TabIndex = 4;
            BtnMedicine.Text = "Medicine";
            BtnMedicine.UseVisualStyleBackColor = true;
            BtnMedicine.Click += BtnMedicine_Click;
            // 
            // btnRoom
            // 
            btnRoom.BackColor = Color.White;
            btnRoom.Cursor = Cursors.Hand;
            btnRoom.FlatStyle = FlatStyle.Flat;
            btnRoom.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoom.ForeColor = Color.FromArgb(33, 33, 33);
            btnRoom.Location = new Point(3, 146);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(171, 52);
            btnRoom.TabIndex = 1;
            btnRoom.Text = "Rooms";
            btnRoom.UseVisualStyleBackColor = false;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnDoctor
            // 
            btnDoctor.BackColor = Color.White;
            btnDoctor.Cursor = Cursors.Hand;
            btnDoctor.FlatStyle = FlatStyle.Flat;
            btnDoctor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoctor.ForeColor = Color.FromArgb(33, 33, 33);
            btnDoctor.Location = new Point(3, 97);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Size = new Size(171, 52);
            btnDoctor.TabIndex = 1;
            btnDoctor.Text = "Doctors";
            btnDoctor.UseVisualStyleBackColor = false;
            btnDoctor.Click += btnDoctor_Click;
            // 
            // btnPatien
            // 
            btnPatien.BackColor = Color.White;
            btnPatien.Cursor = Cursors.Hand;
            btnPatien.FlatStyle = FlatStyle.Flat;
            btnPatien.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPatien.ForeColor = Color.FromArgb(33, 33, 33);
            btnPatien.Location = new Point(3, 52);
            btnPatien.Name = "btnPatien";
            btnPatien.Size = new Size(171, 52);
            btnPatien.TabIndex = 1;
            btnPatien.Text = "Patients";
            btnPatien.UseVisualStyleBackColor = false;
            btnPatien.Click += btnPatien_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(174, -1);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(705, 485);
            panelContainer.TabIndex = 3;
            // 
            // MainForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(875, 478);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(33, 33, 33);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mainform";
            ((ISupportInitialize)pictureBox5).EndInit();
            ((ISupportInitialize)pictureBox4).EndInit();
            ((ISupportInitialize)pictureBox3).EndInit();
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((ISupportInitialize)pictureBox7).EndInit();
            ((ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UC_Dashboard uC_Dashboard = new UC_Dashboard();
            addUserControl(uC_Dashboard);
        }

        private void btnPatien_Click(object sender, EventArgs e)
        {
            UC_Patient uC_Patient = new UC_Patient();
            addUserControl(uC_Patient);
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            UC_Doctors uC_Doctors = new UC_Doctors();
            addUserControl(uC_Doctors);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            UC_Rooms uC_Rooms = new UC_Rooms();
            addUserControl(uC_Rooms);
        }

        private void BtnMedicine_Click(object sender, EventArgs e)
        {
            UC_Medicine uC_Medicine = new UC_Medicine();
            addUserControl(uC_Medicine);
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            UC_POS uC_POS = new UC_POS(loggedInUser.Id);
            addUserControl(uC_POS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_Billing uC_Billing = new UC_Billing();
            addUserControl(uC_Billing);
        }
    }
}
