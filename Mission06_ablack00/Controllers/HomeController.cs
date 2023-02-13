using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_ablack00.Models;

namespace Mission06_ablack00.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private FilmContext FilmContext { get; set; }

        public HomeController(ILogger<HomeController> logger, FilmContext filmyFilm)
        {
            _logger = logger;
            FilmContext = filmyFilm;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        // Post MovieForm checks to see if the submission was valid, if so saves it and returns the user to a success screen. If not, it reloads the page and tells the user what is missing.
        [HttpPost]
        public IActionResult MovieForm(Film film)
        {
            if (ModelState.IsValid)
            {
                FilmContext.Add(film);
                FilmContext.SaveChanges();
                return View("Success", film);
            }
            return View();
        }
        
        public IActionResult Podcasts()
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