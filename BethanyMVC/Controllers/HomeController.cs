using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanyMVC.Models;
using BethanyMVC.ViewModels;
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
            var pies = _pieRepository.GetAllPies().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Bethany's pie shop",
                Pies = pies.ToList()
            };
            return View(homeViewModel);
        }
    }
}