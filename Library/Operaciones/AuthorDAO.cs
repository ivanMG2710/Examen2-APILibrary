using Library.Context;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Operaciones
{
    public class AuthorDAO
    {
        public LibraryContext Context = new LibraryContext();
        //
        public bool addAuthor(string name)
        {
            try
            {
                var authorA = Context.Authors.Where(a => a.Name == name).FirstOrDefault();
                if(authorA == null)
                {
                    Author author = new Author();
                    author.Name = name;
                    Context.Authors.Add(author);
                    Context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                return false;
            }
        }
        //Obtener todos los autores
        public List<Author> GetAllAuthors()
        {
            var listAuthors = Context.Authors.ToList<Author>();
            return listAuthors;
        }
    }
}
