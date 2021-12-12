using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDb
{
    public class Student
    {
       [BsonId]
       [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string firstname { get; set; }
        public string lastname { get; set; }
        public Major major { get; set; }
    }
}
