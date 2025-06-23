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
    public partial class UC_Billing : UserControl
    {
        public UC_Billing()
        {
            InitializeComponent();
            LoadBilling();
            
        }

        private void LoadBilling()
        {
            using (AppContext context = new AppContext())
            {
                var bill = context.Billings
                    .Select(b => new
                    {
                        b.Id,
                        Patient = b.Patients.LastName,
                        b.MedicineCharge,
                        User = b.User.LastName,
                        b.DateTime
                    }).ToList();

                dataGridView1.DataSource = bill;
            }
        }
        
    }
}
