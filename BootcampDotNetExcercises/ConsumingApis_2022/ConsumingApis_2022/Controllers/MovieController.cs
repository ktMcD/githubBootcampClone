using Microsoft.AspNetCore.Mvc;
using Flurl.Http;
using ConsumingApis_2022.Models;

namespace ConsumingApis_2022.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            string apiUri = "https://imdb-top-100-movies.p.rapidapi.com/";
            var apiTask = apiUri.WithHeaders(new
            {
                x_rapidapi_host = "imdb-top-100-movies.p.rapidapi.com",
                x_rapidapi_key = "15728bb747mshb12d9318d06a090p16bcc7jsnf46cf1933827"

            }).GetJsonAsync<List<MovieApi>>();
            apiTask.Wait();
            List<MovieApi> movies = apiTask.Result;
            return View(movies);

        }

        public ActionResult Details(string id)
        {
            // https://imdb-top-100-movies.p.rapidapi.com/top85
            string apiUri = $"https://imdb-top-100-movies.p.rapidapi.com/{id}";
            var apiTask = apiUri.WithHeaders(new
            {
                x_rapidapi_host = "imdb-top-100-movies.p.rapidapi.com",
                x_rapidapi_key = "15728bb747mshb12d9318d06a090p16bcc7jsnf46cf1933827"

            }).GetJsonAsync<MovieApi>();
            apiTask.Wait();
            MovieApi movie = apiTask.Result;
            return View(movie);
        }

    }
}
