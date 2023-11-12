using Library.Models;
using Library.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Library.Controllers
{
    [Route("api")]
    [ApiController]
    public class bookController : ControllerBase
    {
        private BookDAO bookDAO = new BookDAO();

        //First API
        [HttpPost("book")]
        public bool addBook([FromBody]Book book)
        {
            return bookDAO.addBook(book.IdAuthor, book.Title, book.Chapters, book.Pages,book.Price);
        }

        //GetBook
        [HttpGet("book")]
        public List<Book> getBooks()
        {
            return bookDAO.GetAllBooks();
        }
        //GetBook by Id
        [HttpGet("books")]
        public Book getBookId(int id)
        {
            return bookDAO.GetBook(id);
        }
        [HttpGet("booksAuthor")]
        public List<bookAuthor> getBookAuthor() 
        {
            return bookDAO.GetBookAuthors();
        }
    }
}
