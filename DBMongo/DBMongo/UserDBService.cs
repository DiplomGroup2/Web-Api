using DBMongo.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;

namespace DBMongo
{
    public class UserDBService : DBService
    {

        public UserDBService() : base() { }
        public User CreateUser(string email, string password)
        {
            IMongoCollection<User> col = _database.GetCollection<User>(COLLECTION_USER);
            var filter = new BsonDocument
                {
                    {"Email", email}
                };
            IFindFluent<User, User> cursor = col.Find(filter);
            var person = cursor.FirstOrDefault();
            if (person != null)
                return null;
            User us = new User { Email = email, Password = password };
            col.InsertOne(us);
            return us;
        }

        public User SearchUser(string email, string password)
        {
            IMongoCollection<User> col = _database.GetCollection<User>(COLLECTION_USER);
            var filter = new BsonDocument
                {
                    {"Email", email},
                    {"Password", password}
                };
            IFindFluent<User, User> cursor = col.Find(filter);
            var person = cursor.FirstOrDefault();
            return person;
        }

        public User SearchUser(string email)
        {
            IMongoCollection<User> col = _database.GetCollection<User>(COLLECTION_USER);
            var filter = new BsonDocument
                {
                    {"Email", email}
            };
            IFindFluent<User, User> cursor = col.Find(filter);
            var person = cursor.FirstOrDefault();
            return person;
        }

        public void DeleteUser(string userId)
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_USER);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(userId) } };
            col.DeleteOne(filter);

            IMongoCollection<Record> colRecord = _database.GetCollection<Record>(COLLECTION_RECORD);
            var filterRecord = new BsonDocument { { "UserId", userId } };
            colRecord.DeleteOne(filterRecord);

            IMongoCollection<Record> colPage = _database.GetCollection<Record>(COLLECTION_RECORD);
            var filterPage = new BsonDocument { { "UserId", userId } };
            colPage.DeleteOne(filterPage);

        }
    }

}

