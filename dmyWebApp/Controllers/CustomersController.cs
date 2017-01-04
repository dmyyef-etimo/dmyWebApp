using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using dmyWebApp.Models;

namespace dmyWebApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Index()
        {
            var customers = context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = context.Customers.SingleOrDefault(c => c.Id == id) ?? new Customer {Name = "Unknown", Id = 0};
            return View(customer);
        }
    }
}