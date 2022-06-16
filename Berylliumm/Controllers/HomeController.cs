using Berylliumm.DAL;
using Berylliumm.Models;
using Berylliumm.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Berylliumm.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; set; }
        public HomeController(AppDbContext Context)
        {
            _context = Context;
        }

        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel
            {
                WorkPlaces = _context.WorkPlaces.ToList(),
                Slides = _context.Slides.ToList()
            };
            return View(home);
        }

    }
}
