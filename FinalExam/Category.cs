using FinalExam.Object;
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
    public partial class Category : Form
    {
        private int? selectedCategoryId = null;
        public Category()
        {
            InitializeComponent();
            LoadCategory();
        }
        private void LoadCategory()
        {

            using (AppContext context = new AppContext())
            {
                var category = context.medCategories
                    .Select(c => new
                    {
                        c.Id,
                        c.Name,
                    }).ToList();

                dataGridView1.DataSource = category;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext context = new AppContext())
            {
                MedCategory category = new MedCategory();
                category.Name = txtName.Text;
                context.Add(category);
                context.SaveChanges();
            }
            MessageBox.Show("Added Successfully!");
            LoadCategory();
            txtName.Text = "";

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = dataGridView1.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[hit.RowIndex];

                selectedCategoryId = Convert.ToInt32(row.Cells["Id"].Value);

                txtName.Text = row.Cells["Name"].Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Double Click The Data Row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext context = new AppContext())
            {
                var category = context.medCategories.FirstOrDefault(s => s.Id == selectedCategoryId.Value);
                if (category != null)
                {
                    category.Name = txtName.Text;
                    context.SaveChanges();

                    MessageBox.Show("Category Updated Successfully!");
                    LoadCategory();
                    txtName.Text = "";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Double Click The Data Row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this Category?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            using (AppContext context = new AppContext())
            {
                var category = context.medCategories.FirstOrDefault(c => c.Id == selectedCategoryId.Value);
                if (category != null)
                {
                    context.medCategories.Remove(category);
                    context.SaveChanges();
                    MessageBox.Show("Category Deleted successfully!");
                    LoadCategory();
                    txtName.Text = "";
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
    }
}
