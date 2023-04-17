using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Core 
{
    public interface IBookServices
    { 

        List<Book> GetBooks();
        Book AddBook(Book book);
        Book Get_By_Name(string name);
        List<Book> Get_By_Auther(string Auther);
        Book Get_By_Id (string Id);
        void DeleteBook(string Id); 
        Book Update (Book book); 

         

    }
}
