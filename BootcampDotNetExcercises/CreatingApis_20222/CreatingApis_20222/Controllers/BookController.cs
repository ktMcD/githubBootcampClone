using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreatingApis_20222.Models;

namespace CreatingApis_20222.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
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
