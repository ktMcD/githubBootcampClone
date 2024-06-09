using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreatingApis.Models;

namespace CreatingApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookstoreController : ControllerBase
    {
        [HttpPost("add")]
        public Bookstore AddStore(string name, string category, string location)
        {
            return Bookstore.AddBookstore(name, category, location);
        }

        [HttpGet()]
        public List<Bookstore> GetAll()
        {
            return GetAll();
        }

        [HttpGet("{id}")]
        public Bookstore FindById(int id)
        {
            return Bookstore.FindById(id);
        }

        [HttpGet("locationsearch/{location}")]
        public List<Bookstore> FindByLocation(string location)
        {
            return Bookstore.FindbyLocation(location);
        }

        [HttpGet("namesearch/{name}")]
        public Bookstore FindByName(string name)
        {
            return Bookstore.FindByName(name);
        }


    }
}
