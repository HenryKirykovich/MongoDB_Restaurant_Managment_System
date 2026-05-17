using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB_Restaurant_Management_System.Models
{
    public class Feedback
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FeedbackId { get; set; }

        public string UserId { get; set; }
        public string OrderId { get; set; }
        public int Rating { get; set; }   // 1-5
        public string Comment { get; set; }
    }
}
