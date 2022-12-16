using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using caseStudy.Models;
using Contentful.Core;
using System.IO;

namespace caseStudy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IContentfulClient _client;

        public HomeController(ILogger<HomeController> logger, IContentfulClient client)
        {
            _client = client;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var dishTypes = await _client.GetEntriesByType<DishTypes>("dishType");
            return View(dishTypes);
        }

        public async Task<IActionResult> Appetizers()
        {
            var appetizers = await _client.GetEntriesByType<Appetizers>("appetizer");
            return View(appetizers);
        }

        public async Task<IActionResult> MainDishes()
        {
            var mainDishes = await _client.GetEntriesByType<MainDishes>("mainDish");
            return View(mainDishes);
        }

        public async Task<IActionResult> Desserts()
        {
            var desserts = await _client.GetEntriesByType<Desserts>("dessert");
            return View(desserts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult test()
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
