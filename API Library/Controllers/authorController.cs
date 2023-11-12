using Library.Models;
using Library.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Library.Controllers
{
    [Route("api")]
    [ApiController]
    public class authorController : ControllerBase
    {
        private AuthorDAO authorDAO = new AuthorDAO();

        //First API
        [HttpPost("author")]
        public bool addAuthor([FromBody] Author author)
        {
            return authorDAO.addAuthor(author.Name);
        }
        //
        [HttpGet("author")]
        public List<Author> getAuthors()
        {
            return authorDAO.GetAllAuthors();
        }
    }
}
