namespace FinalExam.UserControls
{
    partial class UC_Doctors
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
            label5 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            cmbGender = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            cmbSpecialty = new ComboBox();
            dataGridView1 = new DataGridView();
            btnDeleteRoom = new Button();
            btnUpdateRoom = new Button();
            BtnClear = new Button();
            btnAddRoom = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 16;
            label5.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 49);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 17;
            label2.Text = "FirstName: ";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.Cursor = Cursors.Hand;
            txtFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(98, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(208, 27);
            txtFirstName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 106);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 17;
            label1.Text = "LastName: ";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.Cursor = Cursors.Hand;
            txtLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(98, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(208, 27);
            txtLastName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(357, 163);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 17;
            label3.Text = "Gender: ";
            // 
            // cmbGender
            // 
            cmbGender.Cursor = Cursors.Hand;
            cmbGender.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(442, 156);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(67, 28);
            cmbGender.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 163);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 17;
            label4.Text = "DOB: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(98, 161);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(357, 106);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 17;
            label6.Text = "Phone: ";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Cursor = Cursors.Hand;
            txtPhone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(442, 100);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(208, 27);
            txtPhone.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(357, 43);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 17;
            label7.Text = "Specialty: ";
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.Cursor = Cursors.Hand;
            cmbSpecialty.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSpecialty.FormattingEnabled = true;
            cmbSpecialty.Location = new Point(442, 36);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(208, 28);
            cmbSpecialty.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 265);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(696, 202);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.White;
            btnDeleteRoom.Cursor = Cursors.Hand;
            btnDeleteRoom.FlatStyle = FlatStyle.Flat;
            btnDeleteRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteRoom.ForeColor = Color.Brown;
            btnDeleteRoom.Location = new Point(341, 222);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(95, 37);
            btnDeleteRoom.TabIndex = 22;
            btnDeleteRoom.Text = "Delete";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            btnDeleteRoom.Click += btnDeleteRoom_Click;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.BackColor = Color.White;
            btnUpdateRoom.Cursor = Cursors.Hand;
            btnUpdateRoom.FlatStyle = FlatStyle.Flat;
            btnUpdateRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateRoom.ForeColor = Color.FromArgb(32, 201, 151);
            btnUpdateRoom.Location = new Point(237, 222);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(95, 37);
            btnUpdateRoom.TabIndex = 23;
            btnUpdateRoom.Text = "Update";
            btnUpdateRoom.UseVisualStyleBackColor = false;
            btnUpdateRoom.Click += btnUpdateRoom_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.White;
            BtnClear.Cursor = Cursors.Hand;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.ForeColor = Color.FromArgb(108, 117, 125);
            BtnClear.Location = new Point(442, 222);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(70, 37);
            BtnClear.TabIndex = 24;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.White;
            btnAddRoom.Cursor = Cursors.Hand;
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.FromArgb(13, 110, 253);
            btnAddRoom.Location = new Point(139, 222);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(95, 37);
            btnAddRoom.TabIndex = 25;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(0, 123, 255);
            button1.Location = new Point(667, 36);
            button1.Name = "button1";
            button1.Size = new Size(25, 28);
            button1.TabIndex = 26;
            button1.Text = "@";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UC_Doctors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnUpdateRoom);
            Controls.Add(BtnClear);
            Controls.Add(btnAddRoom);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbSpecialty);
            Controls.Add(cmbGender);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label5);
            Name = "UC_Doctors";
            Size = new Size(705, 485);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private TextBox txtLastName;
        private Label label3;
        private ComboBox cmbGender;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox txtPhone;
        private Label label7;
        private ComboBox cmbSpecialty;
        private DataGridView dataGridView1;
        private Button btnDeleteRoom;
        private Button btnUpdateRoom;
        private Button BtnClear;
        private Button btnAddRoom;
        private Button button1;
    }
}
