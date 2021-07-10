using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SoccerApp.Data.Entities;
using SoccerApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerApp.WebUI.Controllers
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
        [Route("api/controller")]
        [ApiController]
        public class MatchesController : ControllerBase
        {
            [HttpGet]
            public List<Match> Get()
            {
                return new List<Match>
                {
                    new Match{Id = 1}
                };
            }
        }
    }
}
