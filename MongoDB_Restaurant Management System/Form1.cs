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

        private bool CheckLogin()
        {
            if (!Session.IsLoggedIn)
            {
                MessageBox.Show(
                    "Access denied.\nPlease Login or Register first.",
                    "No Access",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
            if (!CheckLogin()) return;
            new MenuManagementForm().ShowDialog();
        }

        private void btnOrderProcessing_Click(object sender, EventArgs e)
        {
            if (!CheckLogin()) return;
            new OrderProcessingForm().ShowDialog();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            if (!CheckLogin()) return;
            new ReservationForm().ShowDialog();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            if (!CheckLogin()) return;
            new FeedbackForm().ShowDialog();
        }

        private void btnOrderTracking_Click(object sender, EventArgs e)
        {
            if (!CheckLogin()) return;
            new OrderTrackingForm().ShowDialog();
        }
    }
}
