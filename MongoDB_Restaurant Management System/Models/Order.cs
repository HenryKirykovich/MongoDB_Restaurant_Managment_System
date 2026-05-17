using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB_Restaurant_Management_System.Models
{
    public class ItemOrder
    {
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string OrderId { get; set; }

        public string UserId { get; set; }
        public List<ItemOrder> Items { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }  // "Placed", "In Kitchen", "Ready to Serve", "Served"
    }
}
