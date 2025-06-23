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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.Load += RegisterForm_Load;
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (AppContext context = new AppContext())
            {
                User user = new User
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text
                };
                context.users.Add(user);
                context.SaveChanges();

                UserAuth auth = new UserAuth();
                auth.Username = txtUsername.Text;
                auth.Password = txtPassword.Text;
                auth.UserId = user.Id;
                context.Add(auth);
                context.SaveChanges();
            }

            MessageBox.Show("Register Successful!");
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            using (var context = new AppContext())
            {
                int nextId = context.users.Any()
                    ? context.users.Max(u => u.Id) + 1
                    : 1;

                txtId.Text = nextId.ToString();
                txtId.ReadOnly = true;
            }
        }
    }
}
