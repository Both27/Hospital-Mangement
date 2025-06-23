using FinalExam.Object;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam.UserControls
{
    public partial class UC_Medicine : UserControl
    {
        private int? selectedMedId = null;
        public UC_Medicine()
        {
            InitializeComponent();
            LoadMedicineList();
            LoadCategoryList();

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
            LoadMedicineList();
            LoadCategoryList();
        }
        private void LoadMedicineList()
        {
            using (AppContext context = new AppContext())
            {
                var medicine = context.medicines
                    .Include(m => m.MedCategorys)
                    .Select(m => new
                    {
                        m.Id,
                        m.Name,
                        m.Quantity,
                        m.Price,
                        m.ExpiryDate,
                        MedCategory = m.MedCategorys.Name
                    }).ToList();

                dataGridView1.DataSource = medicine;
            }

        }
        private void LoadCategoryList()
        {
            using (AppContext app = new AppContext())
            {
                var category = app.medCategories.ToList();
                cmbCategory.DataSource = category;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
            }
        }

        private void Clear()
        {
            txtName.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cmbCategory.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Price number must be numeric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Quantity number must be numeric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (AppContext context = new AppContext())
            {
                Medicine medicine = new Medicine()
                {
                    Name = txtName.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    Price = decimal.Parse(txtPrice.Text),
                    ExpiryDate = dateTimePicker1.Value,
                    MedCategoryId = (int)cmbCategory.SelectedValue

                };
                context.medicines.Add(medicine);
                context.SaveChanges();
                MessageBox.Show("Added Successfully!");
            }
            Clear();
            LoadMedicineList();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Double Click the row of data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Price number must be numeric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out _))
            {
                MessageBox.Show("Quantity number must be numeric!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (AppContext context = new AppContext())
            {
                var medicine = context.medicines.FirstOrDefault(d => d.Id == selectedMedId.Value);
                if (medicine != null)
                {
                    medicine.Name = txtName.Text;
                    medicine.Quantity = int.Parse(txtQuantity.Text);
                    medicine.Price = decimal.Parse(txtPrice.Text);
                    medicine.ExpiryDate = dateTimePicker1.Value;
                    medicine.MedCategoryId = (int)cmbCategory.SelectedValue;

                    context.SaveChanges();
                    Clear();
                    LoadMedicineList();
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = dataGridView1.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[hit.RowIndex];

                selectedMedId = Convert.ToInt32(row.Cells["Id"].Value);

                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtPrice.Text = row.Cells["price"].Value?.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString();
                cmbCategory.Text = row.Cells["MedCategory"].Value?.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["ExpiryDate"].Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Double Click the row of data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete this Medicine?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            using (AppContext context = new AppContext())
            {
                var medicine = context.medicines.FirstOrDefault(m => m.Id == selectedMedId.Value);
                if (medicine != null)
                {
                    context.medicines.Remove(medicine);
                    context.SaveChanges();
                    MessageBox.Show("Deleted Successfully!");
                    Clear();
                    LoadMedicineList(); 
                }

            }
        }
    }
}
