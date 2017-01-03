using System.Web.Mvc;
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

            return Content($"page index = {pageIndex}, sort by = {sortBy}");
        }

        [Route(template: "movies/released/{year:regex(\\d{4}):range(1900,2050)}/{month:regex(\\d{1,2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month:00}");
        }
    }
}