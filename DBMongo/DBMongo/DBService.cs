using DBMongo.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DBMongo
{

    public class DBService
    {

        private string _connectionString;
        private MongoClient _client;
        private IMongoDatabase _database;
        private const string COLLECTION_USER = "users";
        private const string COLLECTION_RECORD = "records";
        private const string COLLECTION_STICK = "stick";

        public DBService(string connectionString= "mongodb://localhost:27017")
        {

            _connectionString = connectionString;
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("test");
        }

        public User CreateUser(string login, string password)
        {
            IMongoCollection<User> col = _database.GetCollection<User>(COLLECTION_USER);
            var filter = new BsonDocument
                {
                    {"Login", login}
                };
            IFindFluent<User, User> cursor = col.Find(filter);
            var person = cursor.FirstOrDefault();
            if (person != null)
                return null;
            User us = new User { Login = login, Password = password };
            col.InsertOne(us);
            return us;
        }

        public User SearchUser(string login, string password)
        {
            IMongoCollection<User> col = _database.GetCollection<User>(COLLECTION_USER);
            var filter = new BsonDocument
                {
                    {"Login", login},
                    {"Password", password}
                };
            IFindFluent<User, User> cursor = col.Find(filter);
            var person = cursor.FirstOrDefault();
            return person;
        }

        public User SearchUser(string login)
        {
            IMongoCollection<User> col = _database.GetCollection<User>(COLLECTION_USER);
            var filter = new BsonDocument
                {
                    {"Login", login}
            };
            IFindFluent<User, User> cursor = col.Find(filter);
            var person = cursor.FirstOrDefault();
            return person;
        }
        public void DeleteUser( string userId)
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_USER);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(userId) } };
            col.DeleteOne(filter);
        }

        public Record CreateRecordUser(string userId, string record)
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            Record r = new Record { UserId = userId, Text = record };
            col.InsertOne(r);
            return r;
        }

        public Record EditRecordUser(string userId, string recordId, string newRecord )
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(recordId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var r = cursor.FirstOrDefault();
            if (r == null)
                return null;
            r.Text = newRecord;
            col.ReplaceOne(filter, r);
            return r;
        }

        public void DeleteRecordUser(string userId, string recordId)
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(recordId) }, { "UserId", userId } };
            col.DeleteOne(filter);
        }

        public Record GetRecordUser(string userId, string recordId)
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            ObjectId id;
            ObjectId.TryParse(recordId, out id);
            var filter = new BsonDocument { { "_id", id }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var r = cursor.FirstOrDefault();
            return r;
        }

        public List<Record> GetAllRecordUser(string userId)
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            var filter = new BsonDocument { { "UserId", userId } };
            var cursor = col.Find(filter);
            var r = cursor.ToList();
            return r;
        }

        public List<Record> GetTextRecordUser(string userId, string [] words)
        {
            var builder = Builders<Record>.Filter;
            FilterDefinition<Record> filter = builder.Empty;
            filter &= builder.Eq("UserId", userId);
            //var restWords = new string[] { "cotton", "spiderman" };
            var orReg = new System.Text.RegularExpressions.Regex(string.Join("|", words), RegexOptions.IgnoreCase);
            filter &= builder.Regex("Text", BsonRegularExpression.Create(orReg));

            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
          //  var filter = new BsonDocument { { "UserId", userId } };
            var cursor = col.Find(filter);
            var r = cursor.ToList();
            return r;
        }

        public Stick CreateStickUser(string userId, string name)
        {
            IMongoCollection<Stick> col = _database.GetCollection<Stick>(COLLECTION_STICK);
            Stick d = new Stick { UserId = userId, Name = name };
            col.InsertOne(d);
            return d;
        }

        public Stick RenameStickUser(string userId, string stickId, string newName )
        {
            IMongoCollection<Stick> col = _database.GetCollection<Stick>(COLLECTION_STICK);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(stickId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var d = cursor.FirstOrDefault();
            if (d == null)
                return null;
            d.Name = newName;
            col.ReplaceOne(filter, d);
            return d;
        }

        public Stick GetStickUser(string userId, string stickId)
        {
            IMongoCollection<Stick> col = _database.GetCollection<Stick>(COLLECTION_STICK);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(stickId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var d = cursor.FirstOrDefault();
            return d;
        }
        public List<Stick> GetAllStickUser(string userId)
        {
            IMongoCollection<Stick> col = _database.GetCollection<Stick>(COLLECTION_STICK);
            var filter = new BsonDocument { { "UserId", userId } };
            var cursor = col.Find(filter);
            var d = cursor.ToList();
            return d;
        }

        public List<Stick> GetNameStickUser(string userId, string[] words)
        {
            var builder = Builders<Stick>.Filter;
            FilterDefinition<Stick> filter = builder.Empty;
            filter &= builder.Eq("UserId", userId);
            //var restWords = new string[] { "cotton", "spiderman" };
            var orReg = new System.Text.RegularExpressions.Regex(string.Join("|", words), RegexOptions.IgnoreCase);
            filter &= builder.Regex("Name", BsonRegularExpression.Create(orReg));

            IMongoCollection<Stick> col = _database.GetCollection<Stick>(COLLECTION_STICK);
            //  var filter = new BsonDocument { { "UserId", userId } };
            var cursor = col.Find(filter);
            var r = cursor.ToList();
            return r;
        }
        public void DeleteStickUser(string userId,string stickId )
        {
            IMongoCollection<Stick> col = _database.GetCollection<Stick>(COLLECTION_STICK);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(stickId) }, { "UserId", userId } };
            col.DeleteOne(filter);
        }

        /// <summary>
        /// добавление записи/заметки на стик
        /// </summary>
        /// <param name="stickId"></param>
        /// <param name="userId"></param>
        /// <param name="recordId"></param>
        /// <returns></returns>
        public Stick AddRecordToStick(string stickId, string userId, string recordId)
        {
            IMongoCollection<Stick> col = _database.GetCollection<Stick>(COLLECTION_STICK);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(stickId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var d = cursor.FirstOrDefault();
            if (d != null)
            {
                if (d.RecordIds == null)
                    d.RecordIds = new List<string>();
                d.RecordIds.Add(recordId);
                col.ReplaceOne(filter, d);
            }
            return d;
        }
    }

}

