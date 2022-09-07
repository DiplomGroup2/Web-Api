using DBMongo.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.Linq;
using System.Collections.Generic;
using System.IO;
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
        private const string COLLECTION_PAGE = "Page";
        private IGridFSBucket _gridFS;

        public DBService(string connectionString = "mongodb://uktclp9d1e9pwejmuzhz:tcebGcGcW8wwXA4LIXBO@n1-c2-mongodb-clevercloud-customers.services.clever-cloud.com:27017,n2-c2-mongodb-clevercloud-customers.services.clever-cloud.com:27017/bqmv36yvlevov6u?replicaSet=rs0")
        //(string connectionString = "mongodb://localhost:27017")
        {

            _connectionString = connectionString;
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("bqmv36yvlevov6u");
            _gridFS = new GridFSBucket(_database);
        }

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
        }


        public Record CreateRecordTextUser(string userId, string record)
        {
            Record r = new Record { UserId = userId, Text = record, RecordType = "text" };
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            col.InsertOne(r);
            return r;
        }

        public Record CreateRecordUrlUser(string userId, string record)
        {
            Record r = new Record { UserId = userId, Text = record, RecordType = "url" };
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            col.InsertOne(r);
            return r;
        }

        public Record CreateRecordImageUser(string userId, string fileName, MemoryStream memoryStream)
        {
            Record r = new Record { UserId = userId, RecordType = "image" };
            if (fileName != null)
            {
                ObjectId id = _gridFS.UploadFromStream(fileName, memoryStream);
                r.ImageId = id.ToString();
                // r.RecordType = RecordType.Image;
            }

            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            col.InsertOne(r);
            return r;
        }

        public Record CreateRecordFileUser(string userId, string fileName, MemoryStream memoryStream)
        {
            Record r = new Record { UserId = userId, RecordType = "file" };
            if (fileName != null)
            {
                ObjectId id = _gridFS.UploadFromStream(fileName, memoryStream);
                r.ImageId = id.ToString();
                // r.RecordType = RecordType.Image;
            }

            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            col.InsertOne(r);
            return r;
        }

        //public Record CreateRecordUser(string userId, string record, string fileName, MemoryStream memoryStream)
        //public Record CreateRecordUser(string userId, string record, string fileName=null, MemoryStream memoryStream=null)
        //{
        //    Record r = new Record { UserId = userId, Text = record };
        //    if (fileName != null)
        //    {
        //        ObjectId id = _gridFS.UploadFromStream(fileName, memoryStream);
        //        r.ImageId = id.ToString();
        //        r.RecordType = RecordType.Image;
        //    }

        //    IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
        //    col.InsertOne(r);
        //    return r;
        //}

        public MemoryStream GetImage(string imageId)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                _gridFS.DownloadToStream(ObjectId.Parse(imageId), ms);
                return ms;
            }
            catch { return null; }
        }


        public Record EditRecordUser(string userId, string recordId, string newRecord, string pageId)
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(recordId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var r = cursor.FirstOrDefault();
            if (r == null)
                return null;
            r.Text = newRecord;
            col.ReplaceOne(filter, r);

            IMongoCollection<Page> col2 = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter2 = new BsonDocument { { "_id", ObjectId.Parse(pageId) }, { "UserId", userId } };
            var cursor2 = col2.Find(filter2);
            var r2 = cursor2.FirstOrDefault();
            if (r2 == null)
                return null;
            var p = r2.Records.FirstOrDefault(o => o.Id == recordId);
            p.Text = newRecord;
            col2.ReplaceOne(filter2, r2);

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

        public List<Record> GetTextRecordUser(string userId, string[] words)
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

        public Page CreatePageUser(string userId, string name, List<string> group)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            Page d = new Page { UserId = userId, Name = name, Group = group };
            col.InsertOne(d);
            return d;
        }

        public Page RenamePageUser(string userId, string PageId, string newName, List<string> group)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(PageId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var d = cursor.FirstOrDefault();
            if (d == null)
                return null;
            d.Name = newName;
            d.Group = group;
            col.ReplaceOne(filter, d);
            return d;
        }

        public Page GetPageUser(string userId, string PageId)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(PageId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var d = cursor.FirstOrDefault();
            return d;
        }
        public List<Page> GetAllPageUser(string userId)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter = new BsonDocument { { "UserId", userId } };
            var cursor = col.Find(filter);
            var d = cursor.ToList();

            return d;
        }

        public List<string> GetAllTagUser(string userId)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter = new BsonDocument { { "UserId", userId } };
            var cursor = col.Find(filter).Project(p => p.Group);
            var d = cursor.ToList().Where(a => a != null).SelectMany(o => o).Distinct().ToList();

            return d;
        }

        public List<Page> GetNamePageUser(string userId, string[] words)
        {
            var builder = Builders<Page>.Filter;
            FilterDefinition<Page> filter = builder.Empty;
            filter &= builder.Eq("UserId", userId);
            //var restWords = new string[] { "cotton", "spiderman" };
            var orReg = new System.Text.RegularExpressions.Regex(string.Join("|", words), RegexOptions.IgnoreCase);
            filter &= builder.Regex("Name", BsonRegularExpression.Create(orReg));

            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            //  var filter = new BsonDocument { { "UserId", userId } };
            var cursor = col.Find(filter);
            var r = cursor.ToList();
            return r;
        }
        public void DeletePageUser(string userId, string PageId)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(PageId) }, { "UserId", userId } };
            col.DeleteOne(filter);
        }

        /// <summary>
        /// добавление записи/заметки на стик
        /// </summary>
        /// <param name="PageId"></param>
        /// <param name="userId"></param>
        /// <param name="recordId"></param>
        /// <returns></returns>
        public Page AddRecordToPage(string userId, string PageId, Record record)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(PageId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var d = cursor.FirstOrDefault();
            if (d != null)
            {
                if (d.Records == null)
                    d.Records = new List<Record>();
                d.Records.Add(record);
                col.ReplaceOne(filter, d);
            }
            return d;
        }
    }

}

