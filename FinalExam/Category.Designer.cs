namespace FinalExam
{
    partial class Category
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
            label6 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            BtnClear = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            txtName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(118, 32);
            label6.TabIndex = 21;
            label6.Text = "Category";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(208, 297);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 37);
            btnDelete.TabIndex = 33;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(32, 201, 151);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(107, 297);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 37);
            btnUpdate.TabIndex = 34;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(108, 117, 125);
            BtnClear.Cursor = Cursors.Hand;
            BtnClear.FlatStyle = FlatStyle.Popup;
            BtnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.ForeColor = Color.White;
            BtnClear.Location = new Point(309, 297);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(70, 37);
            BtnClear.TabIndex = 35;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(13, 110, 253);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(6, 297);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 37);
            btnAdd.TabIndex = 36;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(356, 214);
            dataGridView1.TabIndex = 32;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(224, 224, 224);
            txtName.Cursor = Cursors.Hand;
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(79, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(300, 27);
            txtName.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 50);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 30;
            label2.Text = "Name: ";
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 349);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(BtnClear);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label6);
            Name = "Category";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Category";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btnDelete;
        private Button btnUpdate;
        private Button BtnClear;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private TextBox txtName;
        private Label label2;
    }
}