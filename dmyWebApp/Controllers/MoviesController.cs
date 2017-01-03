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
//            return View(movie);
            //  return Content(content: "Hello World!");
            // return HttpNotFound(statusDescription: "not found!");
            return new EmptyResult();
        }
    }
}