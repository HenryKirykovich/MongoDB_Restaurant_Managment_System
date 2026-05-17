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
            autoTimer.Start();
        }

        private void LoadOrders()
        {
            var filter = Builders<Order>.Filter.Eq(o => o.UserId, Session.CurrentUser.UserId);
            var orders = collection.Find(filter).ToList();
            dgvOrders.DataSource = orders;
        }

        private void autoTimer_Tick(object sender, EventArgs e)
        {
            var filter = Builders<Order>.Filter.And(
                Builders<Order>.Filter.Eq(o => o.UserId, Session.CurrentUser.UserId),
                Builders<Order>.Filter.Ne(o => o.Status, "Served")
            );
            var orders = collection.Find(filter).ToList();

            foreach (var order in orders)
            {
                int idx = Array.IndexOf(Statuses, order.Status);
                if (idx >= 0 && idx < Statuses.Length - 1)
                {
                    string nextStatus = Statuses[idx + 1];
                    var upFilter = Builders<Order>.Filter.Eq(o => o.OrderId, order.OrderId);
                    var update = Builders<Order>.Update.Set(o => o.Status, nextStatus);
                    collection.UpdateOne(upFilter, update);
                }
            }

            LoadOrders();
            lblStatus.Text = $"Auto-updated: {DateTime.Now:HH:mm:ss}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            autoTimer.Stop();
            base.OnFormClosing(e);
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
