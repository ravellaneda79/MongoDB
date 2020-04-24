using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbAccess;

namespace MongoCRUD
{
    public abstract class MongoCRUD<T> where T : MModel
    {
        private IMongoDatabase db;
        private readonly string collectionName;

        public MongoCRUD(MongoSettings settings)
        {
            var client = new MongoClient();
            this.db = client.GetDatabase(settings.DataBaseName);
            this.collectionName = settings.CollectionName;
        }

        public void Insert<T>(T record)
        {
            var collection = this.db.GetCollection<T>(this.collectionName);
            collection.InsertOne(record);
        }

        public IEnumerable<T> Read<T>()
        {
            var collection = this.db.GetCollection<T>(this.collectionName);
            return collection.Find(new BsonDocument()).ToEnumerable();
        }

        public IEnumerable<T> Read<T>(Expression<Func<T, bool>> predicate)
        {
            var collection = this.db.GetCollection<T>(this.collectionName);
            var filter = Builders<T>.Filter.Where(predicate);

            return collection.Find(filter).ToEnumerable();
        }

        public void UpdateOrInsert<T>(T record) where T : MModel
        {
            var collection = this.db.GetCollection<T>(this.collectionName);
            var filter = Builders<T>.Filter.Where(x => x.Id == record.Id);

            collection.ReplaceOne(filter, record, OptionInsertIfDoNotFind());
        }

        public void Delete<T>(T record) where T : MModel
        {
            var collection = this.db.GetCollection<T>(this.collectionName);
            var filter = Builders<T>.Filter.Where(x => x.Id == record.Id);

            collection.DeleteOne(filter);
        }

        private static ReplaceOptions OptionInsertIfDoNotFind()
        {
            return new ReplaceOptions{ IsUpsert = true };
        }
    }
}
