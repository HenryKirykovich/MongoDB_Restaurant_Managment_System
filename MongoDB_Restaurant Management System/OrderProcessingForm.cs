using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB_Restaurant_Management_System.Models;
using MenuItemModel = MongoDB_Restaurant_Management_System.Models.MenuItem;

namespace MongoDB_Restaurant_Management_System
{
    public partial class OrderProcessingForm : Form
    {
        private IMongoCollection<MenuItemModel> menuCollection = MongoDBHelper.GetCollection<MenuItemModel>("MenuItems");
        private IMongoCollection<Order> orderCollection = MongoDBHelper.GetCollection<Order>("Orders");

        public OrderProcessingForm()
        {
            InitializeComponent();
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            var items = menuCollection.Find(Builders<MenuItemModel>.Filter.Empty).ToList();
            dgvMenu.DataSource = items;
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null) return;

            var selected = (MenuItemModel)dgvMenu.CurrentRow.DataBoundItem;
            int qty = (int)nudQuantity.Value;

            lstOrder.Items.Add($"{selected.Name} x{qty} = ${selected.Price * qty}");

            // Store in tag list
            var orderItem = new ItemOrder
            {
                ItemId = selected.ItemId,
                ItemName = selected.Name,
                Quantity = qty,
                Price = selected.Price
            };

            if (lstOrder.Tag == null)
                lstOrder.Tag = new List<ItemOrder>();

            ((List<ItemOrder>)lstOrder.Tag).Add(orderItem);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (lstOrder.Items.Count == 0)
            {
                MessageBox.Show("Add items to the order first.");
                return;
            }

            var items = (List<ItemOrder>)lstOrder.Tag;

            var order = new Order
            {
                UserId = txtUserId.Text.Trim(),
                Items = items,
                OrderDate = DateTime.Now,
                Status = "Placed"
            };

            orderCollection.InsertOne(order);
            MessageBox.Show($"Order placed! Status: Placed\nOrder ID: {order.OrderId}");

            lstOrder.Items.Clear();
            lstOrder.Tag = null;
            txtUserId.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
            lstOrder.Tag = null;
        }
    }
}
