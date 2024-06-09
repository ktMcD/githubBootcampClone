using CreatingApis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreatingApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // this is a query string with a question mark and stuff 
        [HttpPost("add")]
        public Book AddBook(string title, string category)
        {
            return Book.AddBook(title, category);
        }

        [HttpGet()]
        public List<Book> GetAll()
        {
            return Book.GetAll();
        }

        // if a variable is in curly braces, user must add the valuke in the url call
        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            return Book.FindById(id);
        }

        [HttpGet("category/{catname}")]
        public List<Book> GetByCategory(string catname)
        {
            return Book.FindByCategory(catname);
        }


    }
}
