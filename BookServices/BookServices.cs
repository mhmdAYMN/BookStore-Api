using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Core 
{
    public  class BookServices : IBookServices
    {
        private readonly IMongoCollection<Book> _books; 
        public BookServices(IClient<Book>  client)
        {
            _books = client.GetCollection0(); 

        }
        public List<Book> GetBooks() => _books.Find(_ => true).ToList();

        public Book Get_By_Name(string name) => _books.Find(O => O.Name == name).FirstOrDefault();
        public List<Book> Get_By_Auther(string Auther) => _books.Find(O => O.Author == Auther).ToList();
        public Book Get_By_Id(string Id) => _books.Find(O=> O.Id == Id).FirstOrDefault();

        public void DeleteBook(string Id) => _books.DeleteOne(O => O.Id == Id); 
        public Book Update (Book book) 
        {
            _books.ReplaceOne(O=>O.Id==book.Id, book);
            return book;

        }
        

        public Book AddBook(Book book)
        {
            _books.InsertOne(book);
            return book;

        } 


    }
}
