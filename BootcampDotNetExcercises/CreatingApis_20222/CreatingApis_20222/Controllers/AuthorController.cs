using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreatingApis_20222.Models;

namespace CreatingApis_20222.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpPost("add")]
        public Author AddAuthor(string firstName, string lastName, int titleCount)
        {
            return Author.AddAuthor(firstName, lastName, titleCount);
        }

        [HttpGet()]
        public List<Author> GetAll()
        {
            return Author.GetAll();
        }

        [HttpGet("{titleCount}")]
        public List<Author> AuthorGetByTitleCount(int titleCount)
        {
            return Author.GetByTitleCount(titleCount);
        }

        [HttpGet("searchString/{searchString}")]
        public List<Author> GetBySearchString(string searchString)
        {
            return Author.FindByString(searchString);
        }
    }
}