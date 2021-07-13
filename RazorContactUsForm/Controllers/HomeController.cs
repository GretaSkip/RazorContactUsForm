using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorContactUsForm.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RazorContactUsForm.Controllers
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

        public IActionResult Contact()
        {
            ContactModel model = new ContactModel();
            return View(model);
        }

        public IActionResult GetInformation(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                return View("EntryFailed");
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
