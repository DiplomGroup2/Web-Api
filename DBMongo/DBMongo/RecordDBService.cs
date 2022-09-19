using DBMongo.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace DBMongo
{
    public class RecordDBService : DBService
    {
        public RecordDBService() : base() { }

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

        public Record CreateRecordYouTubeUser(string userId, string record)
        {
            Record r = new Record { UserId = userId, Text = record, RecordType = "YouTube" };
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
            }
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            col.InsertOne(r);
            return r;
        }

        public Record CreateRecordFileUser(string userId, string fileName, MemoryStream memoryStream)
        {
            Record r = new Record { UserId = userId, RecordType = "file", Text = fileName };
            if (fileName != null)
            {
                ObjectId id = _gridFS.UploadFromStream(fileName, memoryStream);
                r.ImageId = id.ToString();
            }
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            col.InsertOne(r);
            return r;
        }

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
            if (newRecord != "")
            {
                r.Text = newRecord;
                col.ReplaceOne(filter, r);
            }
            else
                col.DeleteOne(filter);


            IMongoCollection<Page> col2 = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter2 = new BsonDocument { { "_id", ObjectId.Parse(pageId) }, { "UserId", userId } };
            var cursor2 = col2.Find(filter2);
            var r2 = cursor2.FirstOrDefault();
            if (r2 == null)
                return null;
            var p = r2.Records.FirstOrDefault(o => o.Id == recordId);
            if (newRecord != "")
            {
                p.Text = newRecord;
            }
            else
                r2.Records.Remove(p);
            col2.ReplaceOne(filter2, r2);

            return r;
        }

        public void DeleteRecordUser(string userId, string recordId, string pageId)
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            var filter = new BsonDocument { { "_id", ObjectId.Parse(recordId) }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var r = cursor.FirstOrDefault();
            if (r == null)
                return;
            col.DeleteOne(filter);
            if (r.ImageId != null && r.ImageId != "")
            {
                _gridFS.Delete(ObjectId.Parse(r.ImageId));
            }

            IMongoCollection<Page> col2 = _database.GetCollection<Page>(COLLECTION_PAGE);
            var filter2 = new BsonDocument { { "_id", ObjectId.Parse(pageId) }, { "UserId", userId } };
            var cursor2 = col2.Find(filter2);
            var page = cursor2.FirstOrDefault();
            if (page == null)
                return;
            var recordPage = page.Records.FirstOrDefault(o => o.Id == recordId);
            if (recordPage != null)
                page.Records.Remove(recordPage);

            col2.ReplaceOne(filter2, page);
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

        public string GetFileName(string userId, string recordId)
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            ObjectId id;
            ObjectId.TryParse(recordId, out id);
            var filter = new BsonDocument { { "_id", id }, { "UserId", userId } };
            var cursor = col.Find(filter);
            var r = cursor.FirstOrDefault();
            return r.Text;
        }

        public string GetFileName(string imageId)
        {
            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var builderPage = Builders<Page>.Filter;
            var builderRecord = Builders<Record>.Filter;
            FilterDefinition<Page> filter = builderPage.Empty;
            filter &= builderPage.ElemMatch(p => p.Records, builderRecord.Eq(r => r.ImageId, imageId));
            var cursor = col.Find(filter);
            var r = cursor.FirstOrDefault().Records.FirstOrDefault(o => o.ImageId == imageId);
            return r.Text;
        }

        public List<Record> GetAllRecordUser(string userId)
        {
            IMongoCollection<Record> col = _database.GetCollection<Record>(COLLECTION_RECORD);
            var filter = new BsonDocument { { "UserId", userId } };
            var cursor = col.Find(filter);
            var r = cursor.ToList();
            return r;
        }

        public List<Page> GetTextRecordUser(string userId, string[] words)
        {
            var builderPage = Builders<Page>.Filter;
            var builderRecord = Builders<Record>.Filter;
            FilterDefinition<Page> filter = builderPage.Empty;
            filter &= builderPage.Eq("UserId", userId);
            var orReg = new System.Text.RegularExpressions.Regex(string.Join("|", words), RegexOptions.IgnoreCase);
            filter &= builderPage.ElemMatch(p => p.Records, builderRecord.Regex("Text", BsonRegularExpression.Create(orReg)));

            IMongoCollection<Page> col = _database.GetCollection<Page>(COLLECTION_PAGE);
            var cursor = col.Find(filter);
            var r = cursor.ToList();
            return r;
        }
    }

}

