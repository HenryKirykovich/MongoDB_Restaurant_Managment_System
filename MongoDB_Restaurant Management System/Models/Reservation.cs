using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB_Restaurant_Management_System.Models
{
    public class Reservation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ReservationId { get; set; }

        public string UserId { get; set; }
        public int TableNumber { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
