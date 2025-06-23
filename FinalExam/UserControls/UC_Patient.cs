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
    public partial class UC_Patient : UserControl
    {
        private int? selectedPatientId = null;
        public UC_Patient()
        {
            InitializeComponent();
            LoadPatientList();
            LoadRoomList();
            LoadDoctorList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoadPatientList()
        {
            using (AppContext context = new AppContext())
            {
                var patient = context.Patients
                    .Include(p => p.Doctors)
                    .Include(p => p.Rooms)
                    .Select(p => new
                    {
                        p.Id,
                        p.FirstName,
                        p.LastName,
                        p.Gender,
                        p.phone,
                        p.DateOfBirth,
                        Rooms = p.Rooms.Name,
                        Doctors = p.Doctors.LastName
                    }).ToList();

                dataGridView1.DataSource = patient;
            }
        }

        private void LoadDoctorList()
        {
            using (AppContext app = new AppContext())
            {
                var doctor = app.doctors.ToList();
                cmbDoctor.DataSource = doctor;
                cmbDoctor.DisplayMember = "LastName";
                cmbDoctor.ValueMember = "Id";
            }
        }

        private void LoadRoomList()
        {
            using (AppContext app = new AppContext())
            {
                var room = app.rooms.ToList();
                cmbRoom.DataSource = room;
                cmbRoom.DisplayMember = "Name";
                cmbRoom.ValueMember = "Id";
            }
        }

        private void Clear()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            cmbGender.Text = "";
            cmbDoctor.Text = "";
            cmbRoom.Text = "";
            dtDob.Value = DateTime.Now;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(cmbDoctor.Text) ||
                string.IsNullOrWhiteSpace(cmbRoom.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext context = new AppContext())
            {
                Patient patient = new Patient()
                {
                    FirstName = txtFirstname.Text,
                    LastName = txtLastname.Text,
                    phone = txtPhone.Text,
                    RoomId = (int)cmbRoom.SelectedValue,
                    DoctorId = (int)cmbDoctor.SelectedValue,
                    Gender = cmbGender.Text,
                    DateOfBirth = dtDob.Value
                };

                var room = context.rooms.FirstOrDefault(r => r.Id == patient.RoomId);

                if (room.Bed <= 0)
                {
                    MessageBox.Show("No available beds in this room.");
                    return;
                }

                if (room != null && room.Bed > 0)
                {
                    room.Bed -= 1;
                }
                context.Patients.Add(patient);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Added Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.InnerException?.Message ?? ex.Message);
                }

            }
            Clear();
            LoadPatientList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(cmbDoctor.Text) ||
                string.IsNullOrWhiteSpace(cmbRoom.Text))
            {
                MessageBox.Show("Double click on row to data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete this Patient?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            using (AppContext context = new AppContext())
            {
                var patient = context.Patients.FirstOrDefault(p => p.Id == selectedPatientId);
                if (patient != null)
                {
                    var room = context.rooms.FirstOrDefault(r => r.Id == patient.RoomId);
                    if (room != null)
                    {
                        room.Bed += 1;
                    }
                    context.Patients.Remove(patient);
                    context.SaveChanges();
                    MessageBox.Show("Deleted Successfully!");
                    Clear();
                    LoadPatientList();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) ||
                string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(cmbDoctor.Text) ||
                string.IsNullOrWhiteSpace(cmbRoom.Text))
            {
                MessageBox.Show("Double click on row to data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext context = new AppContext())
            {
                var patient = context.Patients.FirstOrDefault(p => p.Id == selectedPatientId.Value);
                if (patient != null)
                {
                    patient.FirstName = txtFirstname.Text;
                    patient.LastName = txtLastname.Text;
                    patient.phone = txtPhone.Text;
                    patient.Gender = cmbGender.Text;
                    patient.DateOfBirth = dtDob.Value;
                    patient.RoomId = (int)cmbRoom.SelectedValue;

                    context.SaveChanges();
                    Clear();
                    LoadPatientList();
                }
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            var hit = dataGridView1.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[hit.RowIndex];

                selectedPatientId = Convert.ToInt32(row.Cells["Id"].Value);

                txtFirstname.Text = row.Cells["FirstName"].Value?.ToString();
                txtLastname.Text = row.Cells["LastName"].Value?.ToString();
                cmbGender.Text = row.Cells["Gender"].Value?.ToString();
                txtPhone.Text = row.Cells["Phone"].Value?.ToString();
                cmbDoctor.Text = row.Cells["Doctors"].Value?.ToString();
                cmbRoom.Text = row.Cells["Rooms"].Value?.ToString();
                dtDob.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoom.SelectedValue is int roomId)
            {
                using (var context = new AppContext())
                {
                    var room = context.rooms.FirstOrDefault(r => r.Id == roomId);
                    if (room != null)
                    {
                        if (room.Bed > 0)
                        {
                            label6.Text = "Available";
                            label6.ForeColor = Color.Green;
                        }
                        else
                        {
                            label6.Text = "Unavailable";
                            label6.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }
    }
}
