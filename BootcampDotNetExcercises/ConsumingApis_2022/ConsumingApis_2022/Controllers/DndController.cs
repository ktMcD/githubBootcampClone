﻿using Microsoft.AspNetCore.Mvc;
using ConsumingApis_2022.Models;
using Flurl.Http;

namespace ConsumingApis_2022.Controllers
{
    public class DndController : Controller
    {
        public IActionResult Index()
        {
            string apiUri = "https://www.dnd5eapi.co/api/classes";
            var apiTask = apiUri.GetJsonAsync<ClassListApi>();
            apiTask.Wait();
            ClassListApi result = apiTask.Result;
            return View(result.results);
        }

        public ActionResult ClassDetails(string index)
        {
            string apiUri = $"https://www.dnd5eapi.co/api/classes/{index}";
            var apiTask = apiUri.GetJsonAsync<ClassDetailsApi>();
            apiTask.Wait();
            ClassDetailsApi result = apiTask.Result;
            return View(result);
        }

    }
}
