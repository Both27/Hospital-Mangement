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
    public partial class SpecialtyForm : Form
    {
        private int? selectedSpecialId = null;
        public SpecialtyForm()
        {
            InitializeComponent();
            LoadSpecailty();
        }

        private void LoadSpecailty()
        {

            using (AppContext context = new AppContext())
            {
                var specailty = context.docSpecialties
                    .Select(s => new
                    {
                        s.Id,
                        s.SpecialtyName
                    }).ToList();

                dataGridView1.DataSource = specailty;
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
                DocSpecialty docSpecialty = new DocSpecialty();
                docSpecialty.SpecialtyName = txtName.Text;
                context.Add(docSpecialty);
                context.SaveChanges();
            }
            MessageBox.Show("Added Successfully!");
            LoadSpecailty();
            txtName.Text = "";
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
                var specailty = context.docSpecialties.FirstOrDefault(s => s.Id == selectedSpecialId.Value);
                if (specailty != null)
                {
                    specailty.SpecialtyName = txtName.Text;
                    context.SaveChanges();

                    MessageBox.Show("Specailty Updated Successfully!");
                    LoadSpecailty();
                    txtName.Text = "";
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = dataGridView1.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[hit.RowIndex];

                selectedSpecialId = Convert.ToInt32(row.Cells["Id"].Value);

                txtName.Text = row.Cells["SpecialtyName"].Value?.ToString();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Double Click The Data Row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this Specialty?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            using (AppContext context = new AppContext())
            {
                var specailty = context.docSpecialties.FirstOrDefault(rt => rt.Id == selectedSpecialId.Value);
                if (specailty != null)
                {
                    context.docSpecialties.Remove(specailty);
                    context.SaveChanges();
                    MessageBox.Show("Specialty Deleted successfully!");
                    LoadSpecailty();
                    txtName.Text = "";
                }
            }
        }
    }
}
