using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;

namespace Core
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; } 
        public string Name { get; set; } 
        public string Category { get; set; } 
        public double Price { get; set; } 
        public string Author { get; set; }  





    }
}