using DBMongo.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DBMongo
{
    public class PageDBService : DBService
    {
        public PageDBService() : base() { }

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

        public List<Page> GetAllPageUser(string userId, string tag)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var builderPage = Builders<Page>.Filter;
            FilterDefinition<Page> filter = builderPage.Empty;
            filter &= builderPage.Eq("UserId", userId);
            filter &= builderPage.All("Group", new List<string>() { tag });
            var cursor = col.Find(filter);
            var d = cursor.ToList();
            return d;
        }

        public List<Page> GetPageUserUntagged(string userId)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var builderPage = Builders<Page>.Filter;
            FilterDefinition<Page> filter = builderPage.Empty;
            filter &= builderPage.Eq("UserId", userId);
            filter &= (builderPage.Eq(p => p.Group, null)) | (builderPage.Size("Group", 0));
            var cursor = col.Find(filter);
            var d = cursor.ToList();
            return d;
        }

        public List<Page> GetPageUserLast(string userId, int countLast)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var builderPage = Builders<Page>.Filter;
            FilterDefinition<Page> filter = builderPage.Empty;
            filter &= builderPage.Eq("UserId", userId);
            var cursor = col.Find(filter).SortByDescending(o => o.Id);
            var d = cursor.Limit(countLast).ToList();
            return d;
        }

        public List<string> GetAllTagUser(string userId)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter = new BsonDocument { { "UserId", userId } };
            var cursor = col.Find(filter).Project(p => p.Group);
            var d = cursor.ToList().Where(a => a != null).SelectMany(o => o).Distinct().OrderBy(o => o).ToList();
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

        public void DeleteAllPageUser(string userId)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter = new BsonDocument { { "UserId", userId } };
            col.DeleteMany(filter);
        }

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

        public Page AddTagPage(string userId, string PageId, string tag)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(PageId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var d = cursor.FirstOrDefault();
            if (d != null)
            {
                if (d.Group == null)
                    d.Group = new List<string>();
                if (d.Group.Count < 2)
                {
                    d.Group.Add(tag);
                    col.ReplaceOne(filter, d);
                }
            }
            return d;
        }

        public Page DeleteTagPage(string userId, string PageId, string tag)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(PageId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var d = cursor.FirstOrDefault();
            if (d != null)
            {
                if (d.Group == null)
                    return d;
                d.Group.Remove(tag);
                col.ReplaceOne(filter, d);
            }
            return d;
        }

    }

}

