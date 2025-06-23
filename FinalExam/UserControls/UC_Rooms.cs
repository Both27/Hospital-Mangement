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
    public partial class UC_Rooms : UserControl
    {
        private int? selectedRoomId = null;
        private int? selectedRoomTypeId = null;
        public UC_Rooms()
        {
            InitializeComponent();
            LoadRoomList();
            LoadRoomTypeList();


        }

        private void UC_Rooms_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(cmbRoomType.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext context = new AppContext())
            {

                Room room = new Room()
                {
                    Name = txtName.Text,
                    Bed = (int)numericUpDown1.Value,
                    RoomTypeId = (int)cmbRoomType.SelectedValue
                };
                context.rooms.Add(room);
                context.SaveChanges();
            }
            MessageBox.Show("Added Successfully!");
            Clear();
            LoadRoomList();
        }

        public void Clear()
        {
            txtName.Text = "";
            numericUpDown1.Value = 0;
            cmbRoomType.Text = "";
        }

        private void LoadRoomList()
        {
            using (AppContext context = new AppContext())
            {
                var rooms = context.rooms
                    .Include(r => r.RoomType)
                    .Select(r => new
                    {
                        r.Id,
                        r.Name,
                        r.Bed,
                        RoomType = r.RoomType.Name
                    }).ToList();

                dataGridView1.DataSource = rooms;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRTName.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext appContext = new AppContext())
            {
                RoomType roomtype = new RoomType();
                roomtype.Name = txtRTName.Text;
                appContext.Add(roomtype);
                appContext.SaveChanges();
            }

            MessageBox.Show("Add Successful!");
            txtRTName.Text = "";
            LoadRoomTypeList();
        }
        private void LoadRoomTypeList()
        {
            using (AppContext app = new AppContext())
            {
                var roomType = app.roomsType.ToList();
                cmbRoomType.DataSource = roomType;
                cmbRoomType.DisplayMember = "Name";
                cmbRoomType.ValueMember = "Id";

                dataGridView2.DataSource = roomType;
            }

            using (AppContext context = new AppContext())
            {
                var roomTypes = context.roomsType
                    .Select(rt => new
                    {
                        rt.Id,
                        rt.Name
                    }).ToList();

                dataGridView2.DataSource = roomTypes;
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtRTName.Text = "";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = dataGridView1.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[hit.RowIndex];

                selectedRoomId = Convert.ToInt32(row.Cells["Id"].Value);

                txtName.Text = row.Cells["Name"].Value?.ToString();
                numericUpDown1.Value = Convert.ToInt32(row.Cells["Bed"].Value);
                cmbRoomType.Text = row.Cells["RoomType"].Value?.ToString();


            }
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var hit = dataGridView2.HitTest(e.X, e.Y);

            if (hit.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[hit.RowIndex];

                selectedRoomTypeId = Convert.ToInt32(row.Cells["Id"].Value);

                txtRTName.Text = row.Cells["Name"].Value?.ToString();
            }
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(cmbRoomType.Text))
            {
                MessageBox.Show("Double Click The Data Row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext context = new AppContext())
            {
                var room = context.rooms.FirstOrDefault(r => r.Id == selectedRoomId.Value);
                if (room != null)
                {
                    room.Name = txtName.Text;
                    room.RoomTypeId = (int)cmbRoomType.SelectedValue;
                    room.Bed = (int)numericUpDown1.Value;
                    context.SaveChanges();

                    MessageBox.Show("Room Updated Successfully!");
                    LoadRoomList();
                    Clear();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtRTName.Text))
            {
                MessageBox.Show("Double Click The Data Row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext context = new AppContext())
            {
                var roomType = context.roomsType.FirstOrDefault(r => r.Id == selectedRoomTypeId.Value);
                if (roomType != null)
                {
                    roomType.Name = txtRTName.Text;

                    context.SaveChanges();

                    MessageBox.Show("RoomType Updated Successfully!");
                    LoadRoomTypeList();
                    txtRTName.Text = "";
                }
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
               string.IsNullOrWhiteSpace(cmbRoomType.Text))
            {
                MessageBox.Show("Double Click The Data Row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            using (AppContext context = new AppContext())
            {
                var room = context.rooms.FirstOrDefault(r => r.Id == selectedRoomId.Value);
                if(room != null)
                {
                    context.rooms.Remove(room); 
                    context.SaveChanges();
                    MessageBox.Show("Room Deleted successfully!");
                    LoadRoomList();
                    Clear();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRTName.Text))
            {
                MessageBox.Show("Double Click The Data Row!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this room type?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }

            using (AppContext context = new AppContext())
            {
                var roomType = context.roomsType.FirstOrDefault(rt => rt.Id == selectedRoomTypeId.Value);
                if (roomType != null)
                {
                    context.roomsType.Remove(roomType);
                    context.SaveChanges();
                    MessageBox.Show("Room Type Deleted successfully!");
                    LoadRoomList();
                    LoadRoomTypeList();
                    txtRTName.Text = "";
                }
            }
        }
    }
}
