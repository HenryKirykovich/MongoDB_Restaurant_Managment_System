using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB_Restaurant_Management_System.Models;

namespace MongoDB_Restaurant_Management_System
{
    public partial class FeedbackForm : Form
    {
        private IMongoCollection<Feedback> collection = MongoDBHelper.GetCollection<Feedback>("Feedback");

        public FeedbackForm()
        {
            InitializeComponent();
            LoadFeedback();
        }

        private void LoadFeedback()
        {
            var filter = Builders<Feedback>.Filter.Eq(f => f.UserId, Session.CurrentUser.UserId);
            var list = collection.Find(filter).ToList();
            dgvFeedback.DataSource = list;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userId = Session.IsLoggedIn ? Session.CurrentUser.UserId : "guest";

            var feedback = new Feedback
            {
                UserId = userId,
                OrderId = txtOrderId.Text.Trim(),
                Rating = (int)nudRating.Value,
                Comment = txtComment.Text.Trim()
            };

            collection.InsertOne(feedback);
            MessageBox.Show("Feedback submitted. Thank you!");
            LoadFeedback();
            ClearFields();
        }

        private void ClearFields()
        {
            txtOrderId.Text = "";
            nudRating.Value = 5;
            txtComment.Text = "";
        }
    }
}
