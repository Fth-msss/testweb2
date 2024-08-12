using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using testweb2.Models;

namespace testweb2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.ClickCount = 0; // Initialize the click count

            var model = new UserInputViewModel();
            return View(model);
        }

        //// New action for the new page
        //public IActionResult TestPage()
        //{
        //    return View();
        //}

        // This action handles the button click to increment the counter
        [HttpPost]
        public IActionResult Increment(int clickCount)
        {
            clickCount++;
            ViewBag.ClickCount = clickCount;
            return View("Index"); // Return the Index view with the updated click count
        }

        [HttpPost]
        public JsonResult ProcessInput(string userInput)
        {
            var processedOutput = $"{userInput}1";
            return Json(new { ProcessedOutput = processedOutput });
        }

        public IActionResult Privacy()
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
