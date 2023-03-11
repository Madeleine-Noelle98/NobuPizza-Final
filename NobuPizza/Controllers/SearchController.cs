using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NobuPizza.Models;
using NobuPizza.Views.Home;
using System.Text.Json;

namespace NobuPizza.Controllers
{
    public class SearchController : Controller
    {
        //private readonly string _apiKey = "aad78ec888msha261c0479bdf8bfp122aabjsn03ca29c5ef32";
        //private readonly string _apiUrl = "https://pizza-and-desserts.p.rapidapi.com/pizzas/1";

   //     public async Task<IActionResult> Search1(string query)
   //     {
   //         using var client = new HttpClient();
   //         //client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
			//client.DefaultRequestHeaders.Add("X-RapidAPI-Key", $"{_apiKey}");
			//client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "pizza-and-desserts.p.rapidapi.com");
			//var response = await client.GetAsync($"{_apiUrl}{query}");
   //         var responseBody = await response.Content.ReadAsStringAsync();

			//var results = JsonSerializer.Deserialize<RapidProduct>(responseBody);
			//return RedirectToAction("SearchResults",results);
   //     }
    }
}
