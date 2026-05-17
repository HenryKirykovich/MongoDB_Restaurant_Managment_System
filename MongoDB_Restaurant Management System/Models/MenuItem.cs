using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB_Restaurant_Management_System.Models
{
    public class MenuItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ItemId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }

        public string Category { get; set; }  // e.g., Appetizer, Main Course, Dessert
    }
}
