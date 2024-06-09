using Microsoft.AspNetCore.Mvc;
using Flurl;
using ConsumingAPIs;
using ConsumingAPIs.Models;
using Flurl.Http;

namespace ConsumingAPIs.Controllers
{
    public class FishController : Controller
    {
        // GET: FishController
        public ActionResult Index()
        {
            var apiUri = "https://fish-species.p.rapidapi.com/fish_api/fishes";
            var apiTask = apiUri.WithHeaders(new
            {
                x_rapidapi_host = "fish-species.p.rapidapi.com",
                x_rapidapi_key = "8100deed49msh72cb0917eb05701p1a969cjsn1e1525ec8735"

            }).GetJsonAsync<List<FishApi>>();
            apiTask.Wait();
            List<FishApi> fishes = apiTask.Result;
            return View(fishes);
        }

        // GET: FishController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FishController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FishController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FishController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FishController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FishController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FishController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
