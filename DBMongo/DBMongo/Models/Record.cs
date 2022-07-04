using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBMongo.Models
{
    public class  Record
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public RecordType RecordType { get; set; }
        public byte[] StrRecordByte { get; set; }



    }

    public enum RecordType
    {
        Text,
        //Binary,
        Image
    }
}

