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
using System.Xml.Linq;

namespace FinalExam.UserControls
{
    public partial class UC_Doctors : UserControl
    {
        private int? selectedDocId = null;
        public UC_Doctors()
        {
            InitializeComponent();
            LoadDocList();
            LoadSpecialtyList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpecialtyForm specialtyForm = new SpecialtyForm();
            specialtyForm.ShowDialog();
            LoadSpecialtyList();
            LoadDocList();
        }
        private void LoadDocList()
        {
            using (AppContext context = new AppContext())
            {
                var doctor = context.doctors
                    .Include(d => d.DocSpecialtys)
                    .Select(d => new
                    {
                        d.Id,
                        d.FirstName,
                        d.LastName,
                        d.Gender,
                        d.Phone,
                        d.DateOfBirth,
                        DocSpecialty = d.DocSpecialtys.SpecialtyName
                    }).ToList();

                dataGridView1.DataSource = doctor;
            }

        }

        private void LoadSpecialtyList()
        {
            using (AppContext app = new AppContext())
            {
                var specailty = app.docSpecialties.ToList();
                cmbSpecialty.DataSource = specailty;
                cmbSpecialty.DisplayMember = "SpecialtyName";
                cmbSpecialty.ValueMember = "Id";
            }
        }

        private void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cmbGender.Text = "";
            txtPhone.Text = "";
            cmbSpecialty.Text = "";
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(cmbSpecialty.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext context = new AppContext())
            {
                Doctor doctor = new Doctor()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Gender = cmbGender.Text,
                    Phone = txtPhone.Text,
                    DateOfBirth = dateTimePicker1.Value,
                    SpecialtyId = (int)cmbSpecialty.SelectedValue
                };
                MessageBox.Show("Added Successfully!");
                context.doctors.Add(doctor);
                context.SaveChanges();
            }
            Clear();
            LoadDocList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
               string.IsNullOrWhiteSpace(txtLastName.Text) ||
               string.IsNullOrWhiteSpace(cmbGender.Text) ||
               string.IsNullOrWhiteSpace(cmbSpecialty.Text) ||
               string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Double Click The Data Row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext context = new AppContext())
            {
                var doctor = context.doctors.FirstOrDefault(d => d.Id == selectedDocId.Value);
                if (doctor != null)
                {
                    doctor.FirstName = txtFirstName.Text;
                    doctor.LastName = txtLastName.Text;
                    doctor.Gender = cmbGender.Text;
                    doctor.DateOfBirth = dateTimePicker1.Value;
                    doctor.Phone = txtPhone.Text;
                    doctor.SpecialtyId = (int)cmbSpecialty.SelectedValue;

                    context.SaveChanges();
                    Clear();
                    LoadDocList();
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = dataGridView1.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[hit.RowIndex];

                selectedDocId = Convert.ToInt32(row.Cells["Id"].Value);

                txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
                txtLastName.Text = row.Cells["LastName"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                cmbGender.Text = row.Cells["Gender"].Value?.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                cmbSpecialty.Text = row.Cells["DocSpecialty"].Value?.ToString();

            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
               string.IsNullOrWhiteSpace(txtLastName.Text) ||
               string.IsNullOrWhiteSpace(cmbGender.Text) ||
               string.IsNullOrWhiteSpace(cmbSpecialty.Text) ||
               string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Double Click The Data Row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete {txtFirstName.Text} {txtLastName.Text}?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            using (AppContext context = new AppContext())
            {
                var doctor = context.doctors.FirstOrDefault(d => d.Id == selectedDocId.Value);
                if (doctor != null)
                {
                    context.doctors.Remove(doctor);
                    context.SaveChanges();
                    MessageBox.Show("Deleted Successfully!");
                    Clear();
                    LoadDocList();
                }

            }
        }
    }
}
