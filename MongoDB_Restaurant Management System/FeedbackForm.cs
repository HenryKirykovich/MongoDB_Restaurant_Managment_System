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
            var list = collection.Find(Builders<Feedback>.Filter.Empty).ToList();
            dgvFeedback.DataSource = list;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var feedback = new Feedback
            {
                UserId = txtUserId.Text.Trim(),
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
            txtUserId.Text = "";
            txtOrderId.Text = "";
            nudRating.Value = 5;
            txtComment.Text = "";
        }
    }
}
