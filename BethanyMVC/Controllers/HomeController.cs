using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanyMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanyMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            //ViewBag.Message = "Welcome to Bethany’s Pie Shop";
            return View();
        }
    }
}