using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB_Restaurant_Management_System.Models;
using MenuItemModel = MongoDB_Restaurant_Management_System.Models.MenuItem;

namespace MongoDB_Restaurant_Management_System
{
    public static class DataSeeder
    {
        public static void SeedAll()
        {
            SeedMenuItems();
            SeedOrdersAndFeedback();
            SeedReservations();
        }

        private static void SeedMenuItems()
        {
            var col = MongoDBHelper.GetCollection<MenuItemModel>("MenuItems");
            if (col.CountDocuments(Builders<MenuItemModel>.Filter.Empty) > 0) return;

            col.InsertMany(new List<MenuItemModel>
            {
                new MenuItemModel { Name = "Caesar Salad",       Description = "Romaine, croutons, parmesan",       Price = 9.99m,  Category = "Appetizer" },
                new MenuItemModel { Name = "Tomato Soup",        Description = "Creamy tomato basil soup",          Price = 7.50m,  Category = "Appetizer" },
                new MenuItemModel { Name = "Garlic Bread",       Description = "Toasted bread with garlic butter",  Price = 4.99m,  Category = "Appetizer" },
                new MenuItemModel { Name = "Grilled Salmon",     Description = "Atlantic salmon with lemon sauce",  Price = 24.99m, Category = "Main Course" },
                new MenuItemModel { Name = "BBQ Burger",         Description = "Beef patty, cheddar, BBQ sauce",   Price = 16.99m, Category = "Main Course" },
                new MenuItemModel { Name = "Chicken Alfredo",    Description = "Pasta with creamy alfredo sauce",   Price = 18.50m, Category = "Main Course" },
                new MenuItemModel { Name = "Ribeye Steak",       Description = "12oz ribeye, medium rare",          Price = 34.99m, Category = "Main Course" },
                new MenuItemModel { Name = "Chocolate Lava Cake",Description = "Warm cake with molten center",      Price = 8.99m,  Category = "Dessert" },
                new MenuItemModel { Name = "Cheesecake",         Description = "New York style cheesecake",         Price = 7.99m,  Category = "Dessert" },
                new MenuItemModel { Name = "Lemonade",           Description = "Fresh squeezed lemonade",           Price = 3.99m,  Category = "Drink" },
                new MenuItemModel { Name = "Coffee",             Description = "Freshly brewed house blend",        Price = 2.99m,  Category = "Drink" },
            });
        }

        private static void SeedOrdersAndFeedback()
        {
            var orderCol = MongoDBHelper.GetCollection<Order>("Orders");
            if (orderCol.CountDocuments(Builders<Order>.Filter.Empty) > 0) return;

            var orders = new List<Order>
            {
                new Order
                {
                    UserId = "test_user_01",
                    OrderDate = DateTime.Now.AddHours(-3),
                    Status = "Served",
                    Items = new List<ItemOrder>
                    {
                        new ItemOrder { ItemName = "Caesar Salad",    Quantity = 1, Price = 9.99m },
                        new ItemOrder { ItemName = "Grilled Salmon",  Quantity = 1, Price = 24.99m },
                        new ItemOrder { ItemName = "Lemonade",        Quantity = 2, Price = 3.99m }
                    }
                },
                new Order
                {
                    UserId = "test_user_02",
                    OrderDate = DateTime.Now.AddHours(-1),
                    Status = "In Kitchen",
                    Items = new List<ItemOrder>
                    {
                        new ItemOrder { ItemName = "BBQ Burger",      Quantity = 2, Price = 16.99m },
                        new ItemOrder { ItemName = "Coffee",          Quantity = 2, Price = 2.99m }
                    }
                },
                new Order
                {
                    UserId = "test_user_03",
                    OrderDate = DateTime.Now.AddMinutes(-20),
                    Status = "Placed",
                    Items = new List<ItemOrder>
                    {
                        new ItemOrder { ItemName = "Ribeye Steak",        Quantity = 1, Price = 34.99m },
                        new ItemOrder { ItemName = "Chocolate Lava Cake", Quantity = 1, Price = 8.99m },
                        new ItemOrder { ItemName = "Garlic Bread",        Quantity = 2, Price = 4.99m }
                    }
                }
            };

            orderCol.InsertMany(orders);

            // Seed feedback linked to first order
            var feedbackCol = MongoDBHelper.GetCollection<Feedback>("Feedback");
            if (feedbackCol.CountDocuments(Builders<Feedback>.Filter.Empty) > 0) return;

            feedbackCol.InsertMany(new List<Feedback>
            {
                new Feedback { UserId = "test_user_01", OrderId = orders[0].OrderId, Rating = 5, Comment = "Excellent food and service!" },
                new Feedback { UserId = "test_user_02", OrderId = orders[1].OrderId, Rating = 4, Comment = "Burger was great, a bit slow" },
                new Feedback { UserId = "test_user_03", OrderId = orders[2].OrderId, Rating = 3, Comment = "Average experience overall" }
            });
        }

        private static void SeedReservations()
        {
            var col = MongoDBHelper.GetCollection<Reservation>("Reservations");
            if (col.CountDocuments(Builders<Reservation>.Filter.Empty) > 0) return;

            col.InsertMany(new List<Reservation>
            {
                new Reservation { UserId = "test_user_01", TableNumber = 3,  ReservationDate = DateTime.Now.AddDays(1),  NumberOfPeople = 2 },
                new Reservation { UserId = "test_user_02", TableNumber = 7,  ReservationDate = DateTime.Now.AddDays(2),  NumberOfPeople = 4 },
                new Reservation { UserId = "test_user_03", TableNumber = 12, ReservationDate = DateTime.Now.AddDays(3),  NumberOfPeople = 6 }
            });
        }
    }
}
