﻿using CondominioInteligente.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CondominioInteligente.Controllers
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
        public IActionResult Sindico()
        {
            return View();
        }
        public IActionResult Proprietario()
        {
            return View();
        }
        public IActionResult Porteiro()
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
    }
}