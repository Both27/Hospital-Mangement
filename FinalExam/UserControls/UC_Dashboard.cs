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
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void LoadDashboard()
        {
            using (var context = new AppContext())
            {
                label6.Text = context.Patients.Count().ToString();
                label7.Text = context.doctors.Count().ToString();
                label8.Text = context.medicines.Count().ToString();
                label9.Text = context.rooms.Count(r => r.Bed > 0).ToString();
                label10.Text = context.Billings
                    .Where(b => b.DateTime.Date == DateTime.Today)
                    .Sum(b => (decimal?)b.MedicineCharge)
                    ?.ToString("C") ?? "$0.00";
            }
        }

    }


}
