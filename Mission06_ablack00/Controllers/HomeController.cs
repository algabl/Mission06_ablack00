﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_ablack00.Models;

namespace Mission06_ablack00.Controllers
{
    public class HomeController : Controller
    {
        
        private FilmContext FilmContext { get; set; }

        public HomeController(FilmContext filmyFilm)
        {
            FilmContext = filmyFilm;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            // Ensures categories are populated
            ViewBag.Categories = FilmContext.Categories.ToList();
            // Dynamically sets the title in the view
            ViewData["Title"] = "Add Movie";
            return View(new Film());
        }

        // Post MovieForm checks to see if the submission was valid, if so saves it and returns the user to a success screen. If not, it reloads the page and tells the user what is missing.
        [HttpPost]
        public IActionResult MovieForm(Film film)
        {
            if (ModelState.IsValid)
            {
                FilmContext.Add(film);
                FilmContext.SaveChanges();
                // Uses an alert system that displays on the MovieList view
                TempData["Alert"] = film.Title + " has been successfully added.";
                return RedirectToAction("MovieList");
            }
            ViewBag.Categories = FilmContext.Categories.ToList();
            return View(new Film());
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var films = FilmContext.Films
                .Include(x => x.Category)
                .OrderBy(x => x.FilmId)
                .ToList();
            return View(films);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = FilmContext.Categories.ToList();
            ViewData["Title"] = "Edit Movie";
            var film = FilmContext.Films.Single(x => x.FilmId == id);
            return View("MovieForm",film);
        }

        [HttpPost]
        public IActionResult Edit(Film film)
        {
            if (ModelState.IsValid)
            {
                FilmContext.Update(film);
                FilmContext.SaveChanges();
                TempData["Alert"] = film.Title + " has been updated.";
                return RedirectToAction("MovieList");
            }
            ViewBag.Categories = FilmContext.Categories.ToList();
            return View("MovieForm",film);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var film = FilmContext.Films.Single(x => x.FilmId == id);
            return View(film);
        }

        [HttpPost]
        public IActionResult Delete(Film film)
        {
            // In order for the alert to display the name of the deleted film,
            // the film needs to be repopulated with all of its information based on the id grabbed by the delete form 
            film = FilmContext.Films.Single(x => x.FilmId == film.FilmId);
            TempData["Alert"] = film.Title + " has been deleted.";
            FilmContext.Films.Remove(film);
            FilmContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        
        public IActionResult Podcasts()
        {
            return View();
        }
    }
}