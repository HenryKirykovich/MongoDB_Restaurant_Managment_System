using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB_Restaurant_Management_System.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }  // "staff" or "customer"
    }
}
