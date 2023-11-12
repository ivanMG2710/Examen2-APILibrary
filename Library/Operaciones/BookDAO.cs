using Library.Context;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Operaciones
{
    public class BookDAO
    {
        public LibraryContext Context = new LibraryContext();
        //Add new book
        public bool addBook (int idAuthor, string title,int chapters, int pages, double price)
        {
            try
            {
                var author = Context.Authors.Where(a => a.Id == idAuthor).FirstOrDefault();
                if(author == null)
                {
                    return false;
                }
                else
                {
                    Book book = new Book();
                    book.IdAuthor = idAuthor;
                    book.Title = title;
                    book.Chapters = chapters;
                    book.Pages = pages;
                    book.Price = price;
                    Context.Books.Add(book);
                    Context.SaveChanges();
                    return true;
                }
            } catch(Exception) {
                return false;
              }
        }
        //Consulta de todos los libros
        public List<Book> GetAllBooks ()
        {
            var listBooks = Context.Books.ToList<Book>();
            return listBooks;
        }
        //Consultar un libro por un id
        public Book GetBook (int id)
        {
            var book = Context.Books.Where(a => a.Id == id).FirstOrDefault();
            return book;
        }
        //Method Book with Author
        public List<bookAuthor> GetBookAuthors ()
        {
            var query = from a in Context.Books
                        join m in Context.Authors on a.IdAuthor
                        equals m.Id
                        select new bookAuthor
                        {
                            titleBook = a.Title,
                            authorBook = m.Name,
                            chaptersBook = a.Chapters,
                            pagesBook = a.Pages,
                            priceBook = a.Price,
                        };
            return query.ToList();
        }
    }
}
