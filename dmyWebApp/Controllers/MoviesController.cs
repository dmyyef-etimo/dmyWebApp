﻿using System.Web.Mvc;
using dmyWebApp.Models;

namespace dmyWebApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /movies/random
        public ActionResult Random()
        {
            var movie = new Movie {Name = "Shrack!"};
            return View(movie);
        }
    }
}