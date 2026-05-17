using System;
using System.Windows.Forms;

namespace MongoDB_Restaurant_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }

        private void btnMenuManagement_Click(object sender, EventArgs e)
        {
            new MenuManagementForm().ShowDialog();
        }

        private void btnOrderProcessing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Processing form - coming soon!");
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reservations form - coming soon!");
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feedback form - coming soon!");
        }

        private void btnOrderTracking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Tracking form - coming soon!");
        }
    }
}
