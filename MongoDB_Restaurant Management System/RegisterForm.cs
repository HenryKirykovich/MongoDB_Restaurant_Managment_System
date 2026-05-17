using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB_Restaurant_Management_System.Models;

namespace MongoDB_Restaurant_Management_System
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString() ?? "customer";

            var collection = MongoDBHelper.GetCollection<User>("Users");

            // Check if username already exists
            var existing = collection.Find(u => u.Username == username).FirstOrDefault();
            if (existing != null)
            {
                MessageBox.Show("Username already exists.", "Registration Failed");
                return;
            }

            var newUser = new User
            {
                Username = username,
                Password = password,
                Email = email,
                Role = role
            };

            collection.InsertOne(newUser);
            MessageBox.Show($"User '{username}' registered successfully!", "Success");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
