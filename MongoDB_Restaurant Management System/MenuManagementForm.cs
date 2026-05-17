using System;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB_Restaurant_Management_System.Models;
using MenuItemModel = MongoDB_Restaurant_Management_System.Models.MenuItem;

namespace MongoDB_Restaurant_Management_System
{
    public partial class MenuManagementForm : Form
    {
        private IMongoCollection<MenuItemModel> collection = MongoDBHelper.GetCollection<MenuItemModel>("MenuItems");

        public MenuManagementForm()
        {
            InitializeComponent();
            LoadMenuItems();
        }

        private void LoadMenuItems()
        {
            var items = collection.Find(Builders<MenuItemModel>.Filter.Empty).ToList();
            dgvMenu.DataSource = items;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var item = new MenuItemModel
            {
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Price = decimal.Parse(txtPrice.Text.Trim()),
                Category = cmbCategory.SelectedItem.ToString()
            };
            collection.InsertOne(item);
            LoadMenuItems();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null) return;
            var selected = (MenuItemModel)dgvMenu.CurrentRow.DataBoundItem;

            var filter = Builders<MenuItemModel>.Filter.Eq(m => m.ItemId, selected.ItemId);
            var update = Builders<MenuItemModel>.Update
                .Set(m => m.Name, txtName.Text.Trim())
                .Set(m => m.Description, txtDescription.Text.Trim())
                .Set(m => m.Price, decimal.Parse(txtPrice.Text.Trim()))
                .Set(m => m.Category, cmbCategory.SelectedItem.ToString());

            collection.UpdateOne(filter, update);
            LoadMenuItems();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null) return;
            var selected = (MenuItemModel)dgvMenu.CurrentRow.DataBoundItem;
            collection.DeleteOne(Builders<MenuItemModel>.Filter.Eq(m => m.ItemId, selected.ItemId));
            LoadMenuItems();
            ClearFields();
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null) return;
            var selected = (MenuItemModel)dgvMenu.CurrentRow.DataBoundItem;
            txtName.Text = selected.Name;
            txtDescription.Text = selected.Description;
            txtPrice.Text = selected.Price.ToString();
            cmbCategory.SelectedItem = selected.Category;
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            cmbCategory.SelectedIndex = 0;
        }
    }
}
