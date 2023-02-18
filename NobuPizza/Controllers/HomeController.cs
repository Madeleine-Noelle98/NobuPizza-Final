﻿using Microsoft.AspNetCore.Mvc;
using NobuPizza.Models;
using System.Diagnostics;

namespace NobuPizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController>_logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Product()
        {
            return View();
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