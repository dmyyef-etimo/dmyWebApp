using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using dmyWebApp.Models;
using dmyWebApp.ViewModels;

namespace dmyWebApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();

        // GET: /movies/random
        public ActionResult Random()
        {
            var movie = new Movie {Name = "Shrack!"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer One"},
                new Customer {Name = "Customer One"},
                new Customer {Name = "Customer One"},
                new Customer {Name = "Customer One"},
                new Customer {Name = "Customer One"},
                new Customer {Name = "Customer Two"}
            };
            var randomMovieViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(randomMovieViewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content($"id = {id}");
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue == false)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return View(context.Movies.Include(m => m.Genre));
        }

        [Route(template: "movies/released/{year:regex(\\d{4}):range(1900,2050)}/{month:regex(\\d{1,2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month:00}");
        }

        public ActionResult Details(int id)
        {
            var movie = context.Movies.Include(m => m.Genre).FirstOrDefault(m => m.Id == id);
            return Content(movie.Name ?? "No movies yet");
        }
    }
}