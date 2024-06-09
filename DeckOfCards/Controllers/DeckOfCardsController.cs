using DeckOfCards.Models;
using Flurl.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Windows;
using static System.Net.WebRequestMethods;

namespace DeckOfCards.Controllers
{

    public class DeckOfCardsController : Controller
    {
        public IActionResult Index()
        {
            string apiUri = "https://www.deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            var apiTask = apiUri.GetJsonAsync<RootObject>();
            apiTask.Wait();
            RootObject result = apiTask.Result;
            return View(result);

        }

        public IActionResult List(string deckId)
        {
            string deckOfCardsApi = "https://www.deckofcardsapi.com/api/deck/" + deckId + "/draw/?count=5";
            var apiUri = deckOfCardsApi;
            var apiTask = apiUri.GetJsonAsync<RootObject>();
            apiTask.Wait();
            RootObject result = apiTask.Result;
            //List<Card> newHand = result.cards.ToList();

            return View(result.cards);
        }

    }


}
