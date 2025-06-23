namespace FinalExam.UserControls
{
    partial class UC_Medicine
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            cmbCategory = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            BtnClear = new Button();
            btnAdd = new Button();
            btnCategory = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 64);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 18;
            label2.Text = "Name: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 104);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 19;
            label1.Text = "Quantity: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(329, 64);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 19;
            label3.Text = "ExpiryDate: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(329, 116);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 19;
            label4.Text = "Price: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(329, 164);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 19;
            label5.Text = "Category: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(9, 13);
            label6.Name = "label6";
            label6.Size = new Size(119, 32);
            label6.TabIndex = 20;
            label6.Text = "Medicine";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Cursor = Cursors.Hand;
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(101, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 27);
            txtName.TabIndex = 21;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.White;
            txtQuantity.Cursor = Cursors.Hand;
            txtQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(101, 98);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(214, 27);
            txtQuantity.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.Cursor = Cursors.Hand;
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(426, 110);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(253, 27);
            txtPrice.TabIndex = 21;
            // 
            // cmbCategory
            // 
            cmbCategory.Cursor = Cursors.Hand;
            cmbCategory.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(426, 157);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(227, 28);
            cmbCategory.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(426, 60);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 265);
            dataGridView1.TabIndex = 24;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Brown;
            btnDelete.Location = new Point(167, 148);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 37);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.FromArgb(32, 201, 151);
            btnUpdate.Location = new Point(78, 148);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 37);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.White;
            BtnClear.Cursor = Cursors.Hand;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BtnClear.ForeColor = Color.FromArgb(108, 117, 125);
            BtnClear.Location = new Point(252, 148);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(63, 37);
            BtnClear.TabIndex = 28;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(13, 110, 253);
            btnAdd.Location = new Point(9, 148);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(63, 37);
            btnAdd.TabIndex = 29;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.White;
            btnCategory.ForeColor = Color.FromArgb(0, 123, 255);
            btnCategory.Location = new Point(654, 157);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(25, 28);
            btnCategory.TabIndex = 30;
            btnCategory.Text = "@";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // UC_Medicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCategory);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "UC_Medicine";
            Size = new Size(705, 485);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private ComboBox cmbCategory;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button BtnClear;
        private Button btnAdd;
        private Button btnCategory;
    }
}
