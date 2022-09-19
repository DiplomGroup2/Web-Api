using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace DBMongo
{

    public class DBService
    {

        private string _connectionString;
        private MongoClient _client;
        protected IMongoDatabase _database;
        protected const string COLLECTION_USER = "users";
        protected const string COLLECTION_RECORD = "records";
        protected const string COLLECTION_PAGE = "Page";
        protected IGridFSBucket _gridFS;

        //public DBService(string connectionString = "mongodb://uktclp9d1e9pwejmuzhz:tcebGcGcW8wwXA4LIXBO@n1-c2-mongodb-clevercloud-customers.services.clever-cloud.com:27017,n2-c2-mongodb-clevercloud-customers.services.clever-cloud.com:27017/bqmv36yvlevov6u?replicaSet=rs0")
        public DBService()
        //(string connectionString = "mongodb://localhost:27017")
        {

            //_connectionString = connectionString;
            _connectionString = "mongodb://uktclp9d1e9pwejmuzhz:tcebGcGcW8wwXA4LIXBO@n1-c2-mongodb-clevercloud-customers.services.clever-cloud.com:27017,n2-c2-mongodb-clevercloud-customers.services.clever-cloud.com:27017/bqmv36yvlevov6u?replicaSet=rs0";
            _client = new MongoClient(_connectionString);
            _database = _client.GetDatabase("bqmv36yvlevov6u");
            _gridFS = new GridFSBucket(_database);
        }
    }

}

