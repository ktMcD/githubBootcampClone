using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIWithEF.Models;
using APIWithEF.DAL;

namespace APIWithEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FishController : ControllerBase
    {
        FishRepository repo = new FishRepository();
        [HttpPost("spawn")]
        public Fish AddFish(string name, string classification, bool fresh, bool salt)
        {
            Fish newFish = new Fish()
            {
                Name = name,
                Classification = classification,
                Freshwater = fresh,
                Saltwater = salt
            };
            return repo.AddFish(newFish);
        }
    }
}
