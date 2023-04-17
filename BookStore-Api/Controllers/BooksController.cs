using Core;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_Api.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices _bookServices; 
        public BooksController(IBookServices bookServices) { _bookServices = bookServices; }
        
        [HttpGet]
        public IActionResult GetAll()
        {

            var books = _bookServices.GetBooks();
            return Ok(books);
        }

        [HttpGet("Getbyname")] 
        public IActionResult Getbyname(string name) 
        {
            var book = _bookServices.Get_By_Name(name); 
           
            return Ok(book); 
        }
        [HttpGet("GetbyAuther")]
        public IActionResult GetbyAuther(string Auther)
        {
            var books = _bookServices.Get_By_Auther(Auther); 

            return Ok(books);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(string id) 
        {
            var book = _bookServices.Get_By_Id(id); 
            return Ok(book);
        }
        [HttpPost]
        public IActionResult Create(Book book )
        {
            var Book = _bookServices.AddBook(book); 
            return Ok(book); 

        }
        [HttpDelete]
        public IActionResult Delete(string id) 
        {
             _bookServices.DeleteBook(id);
             return Ok("book deleted succussfully !!!");  
        }
        [HttpPut]
        public IActionResult Update(Book book)
        {
            _bookServices.Update(book);
            return Ok(book);
        }



    }
}