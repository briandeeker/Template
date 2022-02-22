﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Template.Models;

namespace Template.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // return the views
        public IActionResult Index() { return View(); }
        public IActionResult AboutUs() { return View(); }
        public IActionResult Error404() { return View(); }
        public IActionResult Blog() { return View(); }
        public IActionResult Contact() { return View(); }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}