using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BalbDemoApp.Models;

namespace BalbDemoApp.Controllers
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
            return View();
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

        public IActionResult DoBadThing()
        {
            var x = 1;
            x--;
            var y = 1 / x;
            return Content("Hello " + y);
        }

        public IActionResult HtmxTest()
        {
            return View();
        }

        public IActionResult SimplePartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult EditPersonPartial(Person person)
        {
            if (person.Name != "Mark")
            {
                ModelState.AddModelError("Name", "I don't like your name");
                return PartialView();
            }

            return PartialView("ThanksPartial");
        }
    }
}
