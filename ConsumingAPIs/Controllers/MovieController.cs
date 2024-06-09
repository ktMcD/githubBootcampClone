using Microsoft.AspNetCore.Mvc;
using ConsumingAPIs.Models;
using Flurl.Http;

namespace ConsumingAPIs.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            string apiUri = "https://imdb-top-100-movies.p.rapidapi.com/";
            var apiTask = apiUri.WithHeaders(new
            {
                x_rapidapi_host = "imdb-top-100-movies.p.rapidapi.com",
                x_rapidapi_key = "8100deed49msh72cb0917eb05701p1a969cjsn1e1525ec8735"

            }).GetJsonAsync<List<MovieApi>>();
            apiTask.Wait();
            List<MovieApi> movies = apiTask.Result;
            return View(movies);

        }

        public ActionResult Details(string id)
        {
            string apiUri = $"https://imdb-top-100-movies.p.rapidapi.com/{id}";
            var apiTask = apiUri.WithHeaders(new
            {
                x_rapidapi_host = "imdb-top-100-movies.p.rapidapi.com",
                x_rapidapi_key = "8100deed49msh72cb0917eb05701p1a969cjsn1e1525ec8735"

            }).GetJsonAsync<MovieApi>();
            apiTask.Wait();
            MovieApi movie = apiTask.Result;
            return View(movie);
        }


    }
}
