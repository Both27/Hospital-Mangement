namespace FinalExam.UserControls
{
    partial class UC_POS
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
            cmbPatient = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            cmbMedicine = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnAdd = new Button();
            btnRemove = new Button();
            label4 = new Label();
            BtnCheckout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 90);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 23;
            label2.Text = "Patient: ";
            // 
            // cmbPatient
            // 
            cmbPatient.Cursor = Cursors.Hand;
            cmbPatient.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPatient.FormattingEnabled = true;
            cmbPatient.Location = new Point(147, 81);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new Size(155, 33);
            cmbPatient.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(66, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(603, 198);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 85);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 26;
            label1.Text = "Medicine: ";
            // 
            // cmbMedicine
            // 
            cmbMedicine.Cursor = Cursors.Hand;
            cmbMedicine.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMedicine.FormattingEnabled = true;
            cmbMedicine.Location = new Point(423, 73);
            cmbMedicine.Name = "cmbMedicine";
            cmbMedicine.Size = new Size(246, 33);
            cmbMedicine.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 26);
            label6.Name = "label6";
            label6.Size = new Size(60, 32);
            label6.TabIndex = 28;
            label6.Text = "POS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 158);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 29;
            label3.Text = "Quantity: ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(147, 146);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(155, 33);
            numericUpDown1.TabIndex = 30;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(13, 110, 253);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(337, 142);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 37);
            btnAdd.TabIndex = 31;
            btnAdd.Text = "Add To Cart";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Brown;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(506, 142);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(163, 37);
            btnRemove.TabIndex = 32;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(436, 416);
            label4.Name = "label4";
            label4.Size = new Size(94, 40);
            label4.TabIndex = 33;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // BtnCheckout
            // 
            BtnCheckout.BackColor = Color.LimeGreen;
            BtnCheckout.Cursor = Cursors.Hand;
            BtnCheckout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            BtnCheckout.ForeColor = Color.White;
            BtnCheckout.Location = new Point(66, 424);
            BtnCheckout.Name = "BtnCheckout";
            BtnCheckout.Size = new Size(163, 37);
            BtnCheckout.TabIndex = 34;
            BtnCheckout.Text = "Check Out";
            BtnCheckout.UseVisualStyleBackColor = false;
            BtnCheckout.Click += BtnCheckout_Click;
            // 
            // UC_POS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnCheckout);
            Controls.Add(label4);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(cmbMedicine);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(cmbPatient);
            Controls.Add(label2);
            Name = "UC_POS";
            Size = new Size(705, 485);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox cmbPatient;
        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox cmbMedicine;
        private Label label6;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button btnAdd;
        private Button btnRemove;
        private Label label4;
        private Button BtnCheckout;
    }
}
