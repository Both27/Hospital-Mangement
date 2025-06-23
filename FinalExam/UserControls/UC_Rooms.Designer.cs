namespace FinalExam.UserControls
{
    partial class UC_Rooms
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
            btnDeleteRoom = new Button();
            btnUpdateRoom = new Button();
            cmbRoomType = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            BtnClear = new Button();
            btnAddRoom = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtRTName = new TextBox();
            dataGridView2 = new DataGridView();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button11 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.White;
            btnDeleteRoom.Cursor = Cursors.Hand;
            btnDeleteRoom.FlatStyle = FlatStyle.Flat;
            btnDeleteRoom.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteRoom.ForeColor = Color.Brown;
            btnDeleteRoom.Location = new Point(372, 248);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(95, 37);
            btnDeleteRoom.TabIndex = 10;
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
            btnUpdateRoom.Location = new Point(268, 248);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(95, 37);
            btnUpdateRoom.TabIndex = 12;
            btnUpdateRoom.Text = "Update";
            btnUpdateRoom.UseVisualStyleBackColor = false;
            btnUpdateRoom.Click += btnUpdateRoom_Click;
            // 
            // cmbRoomType
            // 
            cmbRoomType.Cursor = Cursors.Hand;
            cmbRoomType.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(126, 196);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(174, 28);
            cmbRoomType.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 203);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 8;
            label4.Text = "RoomType: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 93);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 6;
            label2.Text = "Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 143);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 6;
            label3.Text = "Bed: ";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Cursor = Cursors.Hand;
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(126, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 27);
            txtName.TabIndex = 7;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.White;
            BtnClear.Cursor = Cursors.Hand;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.ForeColor = Color.FromArgb(108, 117, 125);
            BtnClear.Location = new Point(473, 248);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(70, 37);
            BtnClear.TabIndex = 13;
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
            btnAddRoom.Location = new Point(170, 248);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(95, 37);
            btnAddRoom.TabIndex = 13;
            btnAddRoom.Text = "Add";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(329, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(362, 184);
            dataGridView1.TabIndex = 14;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 12);
            label5.Name = "label5";
            label5.Size = new Size(81, 32);
            label5.TabIndex = 15;
            label5.Text = "Room";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 295);
            label6.Name = "label6";
            label6.Size = new Size(142, 32);
            label6.TabIndex = 15;
            label6.Text = "Room Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 378);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 6;
            label8.Text = "Name: ";
            // 
            // txtRTName
            // 
            txtRTName.BackColor = Color.White;
            txtRTName.Cursor = Cursors.Hand;
            txtRTName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRTName.Location = new Point(126, 372);
            txtRTName.Name = "txtRTName";
            txtRTName.Size = new Size(174, 27);
            txtRTName.TabIndex = 7;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(329, 334);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(362, 94);
            dataGridView2.TabIndex = 16;
            dataGridView2.MouseDoubleClick += dataGridView2_MouseDoubleClick;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Cursor = Cursors.Hand;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(13, 110, 253);
            button7.Location = new Point(170, 445);
            button7.Name = "button7";
            button7.Size = new Size(95, 37);
            button7.TabIndex = 13;
            button7.Text = "Add";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Cursor = Cursors.Hand;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(108, 117, 125);
            button8.Location = new Point(473, 445);
            button8.Name = "button8";
            button8.Size = new Size(70, 37);
            button8.TabIndex = 13;
            button8.Text = "Clear";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Cursor = Cursors.Hand;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.FromArgb(32, 201, 151);
            button9.Location = new Point(268, 445);
            button9.Name = "button9";
            button9.Size = new Size(95, 37);
            button9.TabIndex = 12;
            button9.Text = "Update";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.Cursor = Cursors.Hand;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.Brown;
            button11.Location = new Point(372, 445);
            button11.Name = "button11";
            button11.Size = new Size(95, 37);
            button11.TabIndex = 10;
            button11.Text = "Delete";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(126, 143);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(174, 27);
            numericUpDown1.TabIndex = 17;
            // 
            // UC_Rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numericUpDown1);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button11);
            Controls.Add(btnDeleteRoom);
            Controls.Add(button9);
            Controls.Add(btnUpdateRoom);
            Controls.Add(button8);
            Controls.Add(BtnClear);
            Controls.Add(button7);
            Controls.Add(btnAddRoom);
            Controls.Add(cmbRoomType);
            Controls.Add(label4);
            Controls.Add(txtRTName);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Cursor = Cursors.Hand;
            Name = "UC_Rooms";
            Size = new Size(705, 485);
            Load += UC_Rooms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeleteRoom;
        private Button btnUpdateRoom;
        private ComboBox cmbRoomType;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private Button BtnClear;
        private Button btnAddRoom;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox txtRTName;
        private DataGridView dataGridView2;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button11;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private NumericUpDown numericUpDown1;
    }
}
