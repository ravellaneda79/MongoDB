using System.Runtime.CompilerServices;
using MongoCRUD;
using MongoDB.Driver;

namespace MongoDbAccess
{
    public abstract class MongoContext<T> where T : MModel
    {
        private readonly IMongoDatabase db;
        private readonly string collection;

        protected MongoContext(string database, string collection)
        {
            var client = new MongoClient();
            this.db = client.GetDatabase(database);
            this.collection = collection;
        }

        public IMongoCollection<T> Collection => this.db.GetCollection<T>(this.collection);
    }
}
