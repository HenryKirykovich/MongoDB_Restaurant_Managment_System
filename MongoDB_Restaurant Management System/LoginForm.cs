using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB_Restaurant_Management_System.Models;

namespace MongoDB_Restaurant_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var collection = MongoDBHelper.GetCollection<User>("Users");
            var user = collection.Find(u => u.Username == username && u.Password == password).FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.Username}! Role: {user.Role}", "Login Successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
