using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NobuPizza.Data;
using NobuPizza.Models;
using System.Diagnostics;
using System.Text.Json;

namespace NobuPizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController>_logger;
		private readonly ApplicationDbContext _context;

		public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
           
            return View();
        }


        public IActionResult Product()
        {
            try {  return  View( _context.Product.ToList());} 
            catch { return View(); }
        }
        public IActionResult Wishlist()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult SearchResults()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
		private readonly string _apiKey = "aad78ec888msha261c0479bdf8bfp122aabjsn03ca29c5ef32";
		private readonly string _apiUrl = "https://pizza-and-desserts.p.rapidapi.com/pizzas/1";
		public async Task<IActionResult> Search1(string query)
		{
			using var client = new HttpClient();
			//client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiKey}");
			client.DefaultRequestHeaders.Add("X-RapidAPI-Key", $"{_apiKey}");
			client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "pizza-and-desserts.p.rapidapi.com");
			var response = await client.GetAsync($"{_apiUrl}{query}");
			var responseBody = await response.Content.ReadAsStringAsync();

			var results = JsonSerializer.Deserialize<RapidProduct>(responseBody);
			return RedirectToAction("SearchResults", results);
		}
	}
}