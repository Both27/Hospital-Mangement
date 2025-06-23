namespace FinalExam.UserControls
{
    partial class UC_Patient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            dtDob = new DateTimePicker();
            cmbGender = new ComboBox();
            button1 = new Button();
            btnUpdate = new Button();
            button3 = new Button();
            BtnDelete = new Button();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbRoom = new ComboBox();
            cmbDoctor = new ComboBox();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            txtPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 32);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 2;
            label2.Text = "FirstName: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 85);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 2;
            label3.Text = "LastName: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(336, 85);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 2;
            label4.Text = "Gender: ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(336, 139);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 2;
            label5.Text = "DOB: ";
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(98, 26);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(212, 27);
            txtFirstname.TabIndex = 1;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(98, 79);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(212, 27);
            txtLastname.TabIndex = 1;
            // 
            // dtDob
            // 
            dtDob.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtDob.ImeMode = ImeMode.NoControl;
            dtDob.Location = new Point(410, 133);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(258, 27);
            dtDob.TabIndex = 3;
            dtDob.UseWaitCursor = true;
            dtDob.Value = new DateTime(2025, 5, 7, 19, 10, 30, 0);
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(410, 78);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(50, 28);
            cmbGender.TabIndex = 4;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(13, 110, 253);
            button1.Location = new Point(118, 413);
            button1.Name = "button1";
            button1.Size = new Size(95, 37);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FromArgb(32, 201, 151);
            btnUpdate.Location = new Point(235, 413);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 37);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(108, 117, 125);
            button3.Location = new Point(475, 413);
            button3.Name = "button3";
            button3.Size = new Size(95, 37);
            button3.TabIndex = 5;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.White;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDelete.ForeColor = Color.Brown;
            BtnDelete.Location = new Point(356, 413);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(95, 37);
            BtnDelete.TabIndex = 5;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(475, 85);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 6;
            label1.Text = "Room: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.MediumSeaGreen;
            label6.Location = new Point(635, 91);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "Available";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(336, 32);
            label7.Name = "label7";
            label7.Size = new Size(64, 21);
            label7.TabIndex = 10;
            label7.Text = "Dcotor: ";
            // 
            // cmbRoom
            // 
            cmbRoom.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(539, 78);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(90, 28);
            cmbRoom.TabIndex = 11;
            cmbRoom.SelectedIndexChanged += cmbRoom_SelectedIndexChanged;
            // 
            // cmbDoctor
            // 
            cmbDoctor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(410, 30);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(258, 28);
            cmbDoctor.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(681, 236);
            dataGridView1.TabIndex = 13;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 137);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 14;
            label8.Text = "Phone: ";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(98, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(212, 27);
            txtPhone.TabIndex = 15;
            // 
            // UC_Patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtPhone);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(cmbDoctor);
            Controls.Add(cmbRoom);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(BtnDelete);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(button1);
            Controls.Add(cmbGender);
            Controls.Add(dtDob);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Name = "UC_Patient";
            Size = new Size(705, 485);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtGender;
        private DateTimePicker dtDob;
        private ComboBox cmbGender;
        private Button button1;
        private Button btnUpdate;
        private Button button3;
        private Button BtnDelete;
        private Label label1;
        private Label label6;
        private Label label7;
        private ComboBox cmbRoom;
        private ComboBox cmbDoctor;
        private DataGridView dataGridView1;
        private Label label8;
        private TextBox txtPhone;
    }
}
