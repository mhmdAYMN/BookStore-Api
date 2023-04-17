using Core;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Client : IClient<Book>
    {   private readonly IMongoCollection<Book> _Books;
        private const string CollectionName = "Book"; 
        public Client(IOptions<ConfigureMongoDB> configureMongoDB )   
        {  
            var client = new MongoClient( configureMongoDB.Value.CONNECTION_STRING );
            var database = client.GetDatabase(configureMongoDB.Value.Database_Name);
            _Books = database.GetCollection<Book>(CollectionName); 



        }
        public  IMongoCollection<Book> GetCollection0() => _Books;
       
       
    }
}
