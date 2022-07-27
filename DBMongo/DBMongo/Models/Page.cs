using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBMongo.Models
{
    public class Page
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
      
        public string UserId { get; set; }
        public List<Record> Records { get; set; }
        //public List<string> RecordIds { get; set; }

    }
}
