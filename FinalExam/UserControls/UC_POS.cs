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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FinalExam.UserControls
{
    public partial class UC_POS : UserControl
    {
        private List<BillingItem> cart = new List<BillingItem>();
        private int? selectedCartIndex = null;

        private int userId;
        public UC_POS(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            LoadPatient();
            LoadMedicin();     
        }

        private void LoadPatient()
        {
            using (AppContext app = new AppContext())
            {
                var patient = app.Patients.ToList();
                cmbPatient.DataSource = patient;
                cmbPatient.DisplayMember = "LastName";
                cmbPatient.ValueMember = "Id";
            }
        }

        private void LoadMedicin()
        {
            using (AppContext app = new AppContext())
            {
                var medicine = app.medicines.ToList();
                cmbMedicine.DataSource = medicine;
                cmbMedicine.DisplayMember = "Name";
                cmbMedicine.ValueMember = "Id";
            }
        }

        private void RefreshCart()
        {
            using (var context = new AppContext())
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cart.Select(c => new
                {
                    Medicine = context.medicines.FirstOrDefault(m => m.Id == c.MedicineId)?.Name,
                    Quantity = c.QuantityUsed,
                    Price = c.UnitPrice,
                    Total = c.QuantityUsed * c.UnitPrice
                }).ToList();
            }

            UpdateTotal();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int medicineId = (int)cmbMedicine.SelectedValue;
            int quantity = (int)numericUpDown1.Value;

            using (var context = new AppContext())
            {
                var med = context.medicines.FirstOrDefault(m => m.Id == medicineId);
                if (med == null || med.Quantity < quantity)
                {
                    MessageBox.Show("Invalid or insufficient stock.");
                    return;
                }

                cart.Add(new BillingItem
                {
                    MedicineId = medicineId,
                    QuantityUsed = quantity,
                    UnitPrice = med.Price
                });

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = cart.Select(c => new
                {
                    Medicine = context.medicines.FirstOrDefault(m => m.Id == c.MedicineId)?.Name,
                    Quantity = c.QuantityUsed,
                    Price = c.UnitPrice,
                    Total = c.QuantityUsed * c.UnitPrice
                }).ToList();
            }
            UpdateTotal();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            if (cmbPatient.SelectedValue == null)
            {
                MessageBox.Show("Please select a patient.");
                return;
            }

            using (var context = new AppContext())
            {
                try
                {
                    Billing billing = new Billing
                    {
                        DateTime = DateTime.Now,
                        PatientId = (int)cmbPatient.SelectedValue,
                        UserId = userId,
                        MedicineCharge = cart.Sum(c => c.QuantityUsed * c.UnitPrice)
                    };

                    context.Billings.Add(billing);
                    context.SaveChanges();

                    foreach (var item in cart)
                    {
                        var billingItem = new BillingItem
                        {
                            BillingId = billing.Id,
                            MedicineId = item.MedicineId,
                            QuantityUsed = item.QuantityUsed,
                            UnitPrice = item.UnitPrice
                        };

                        var med = context.medicines.FirstOrDefault(m => m.Id == billingItem.MedicineId);
                        if (med != null)
                        {
                            med.Quantity -= billingItem.QuantityUsed;
                        }

                        context.BillingItems.Add(billingItem);
                    }

                    context.SaveChanges();
                    MessageBox.Show("Transaction complete.");
                    cart.Clear();
                    dataGridView1.DataSource = null;
                    UpdateTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.InnerException?.Message ?? ex.Message);
                }
            }
        }
        private void UpdateTotal()
        {
            decimal total = cart.Sum(c => c.QuantityUsed * c.UnitPrice);
            label4.Text = $"Total: {total:C}";
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedCartIndex == null || selectedCartIndex < 0 || selectedCartIndex >= cart.Count)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            cart.RemoveAt(selectedCartIndex.Value);
            selectedCartIndex = null;

            RefreshCart();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedCartIndex = e.RowIndex;
            }
        }
    }
}
