using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NobuPizza.Data;
using NobuPizza.Models;
using System.Diagnostics;

namespace NobuPizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController>_logger;
		private readonly ApplicationDbContext _context;

		public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context= context;
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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}