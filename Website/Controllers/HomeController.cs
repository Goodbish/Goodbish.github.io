using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Website.Models;

namespace Website.Controllers
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

        public IActionResult redirect()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class portfolioController : Controller

    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult solo()
        {
            return View();
        }

        public IActionResult love_story()
        {
            return View();
        }

        public IActionResult events()
        {
            return View();
        }

        public IActionResult family()
        {
            return View();
        }


    }

    public class PriceController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PriceController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }

    public class contactController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public contactController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }




}
