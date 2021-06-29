using DDOS_Detection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DDOS_Detection.Controllers
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

        [HttpGet("Data/GetAll")]
        public ActionResult<IEnumerable<Person>> GetData()
        {
            return new[]
            {
            new Person { Name = "Seif" },
            new Person { Name = "Saleem" },
            new Person { Name = "Nada" },
            new Person { Name = "Ghoneim" }
        };
        }
    }


    public class Person
    {
        public string Name { get; set; }
    }

}
