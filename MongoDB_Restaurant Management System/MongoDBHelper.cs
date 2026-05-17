using MongoDB.Driver;

namespace MongoDB_Restaurant_Management_System
{
    public static class MongoDBHelper
    {
        private static readonly string ConnectionString = "mongodb://localhost:27017";
        private static readonly string DatabaseName = "RestaurantDB";

        private static IMongoDatabase _database;

        public static IMongoDatabase GetDatabase()
        {
            if (_database == null)
            {
                var client = new MongoClient(ConnectionString);
                _database = client.GetDatabase(DatabaseName);
            }
            return _database;
        }

        public static IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return GetDatabase().GetCollection<T>(collectionName);
        }

        // Creates all collections on first run if they don't exist
        public static void InitializeDatabase()
        {
            var db = GetDatabase();
            var existing = db.ListCollectionNames().ToList();

            string[] collections = { "Users", "MenuItems", "Orders", "Reservations", "Feedback" };
            foreach (var name in collections)
            {
                if (!existing.Contains(name))
                    db.CreateCollection(name);
            }
        }
    }
}
