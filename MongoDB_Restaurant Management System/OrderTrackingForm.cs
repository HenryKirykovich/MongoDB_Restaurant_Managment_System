using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB_Restaurant_Management_System.Models;

namespace MongoDB_Restaurant_Management_System
{
    public partial class OrderTrackingForm : Form
    {
        private IMongoCollection<Order> collection = MongoDBHelper.GetCollection<Order>("Orders");

        private static readonly string[] Statuses = { "Placed", "In Kitchen", "Ready to Serve", "Served" };

        public OrderTrackingForm()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            var orders = collection.Find(Builders<Order>.Filter.Empty).ToList();
            dgvOrders.DataSource = orders;
        }

        private void btnAdvanceStatus_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;
            var selected = (Order)dgvOrders.CurrentRow.DataBoundItem;

            int currentIndex = Array.IndexOf(Statuses, selected.Status);
            if (currentIndex >= Statuses.Length - 1)
            {
                MessageBox.Show("Order is already Served.");
                return;
            }

            string nextStatus = Statuses[currentIndex + 1];
            var filter = Builders<Order>.Filter.Eq(o => o.OrderId, selected.OrderId);
            var update = Builders<Order>.Update.Set(o => o.Status, nextStatus);
            collection.UpdateOne(filter, update);

            MessageBox.Show($"Order status updated to: {nextStatus}");
            LoadOrders();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
