using System;
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

        public ActionResult Edit(int id)
        {
            var movie = context.Movies.Single(m => m.Id.Equals(id));
            var genres = context.Genres.ToList();
            var viewModel = new MovieFormViewModel {Movie = movie, Genres = genres, ActionName = "Edit Movie"};
            return View(viewName: "MovieForm", model: viewModel);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex.HasValue == false)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            var movies = context.Movies.Include(m => m.Genre);
            return View(movies);
        }

        [Route(template: "movies/released/{year:regex(\\d{4}):range(1900,2050)}/{month:regex(\\d{1,2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(content: $"{year}/{month:00}");
        }

        public ActionResult Create()
        {
            var genres = context.Genres.ToList();
            var viewModel = new MovieFormViewModel {Genres = genres, Movie = new Movie(), ActionName = "New Movie"};
            return View(viewName: "MovieForm", model: viewModel);
        }

        [HttpPost]
        public ActionResult Update(Movie movie)
        {
            movie.AddedDate = DateTime.Now;
            movie.Genre = context.Genres.Single(g => g.Id == movie.GenreId);
            if (movie.Id == 0)
            {
                context.Movies.Add(movie);
            }
            else
            {
                var movieDb = context.Movies.Single(m => m.Id == movie.Id);
                TryUpdateModel(movieDb);
            }

            context.SaveChanges();
            return RedirectToAction(actionName: "Index", controllerName: "Movies");
        }
    }
}