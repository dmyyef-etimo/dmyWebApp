using System.Collections.Generic;
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
            var customers = context.Customers.ToList();
            return View(customers);
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    var customers = new List<Customer>
        //    {
        //        new Customer {Id = 1, Name = "John Smith"},
        //        new Customer {Id = 2, Name = "Mary Williams"}
        //    };
        //    return customers;
        //}

        public ActionResult Details(int id)
        {
            var customer = context.Customers.SingleOrDefault(c => c.Id == id) ?? new Customer {Name = "Unknown", Id = 0};
            return View(customer);
        }
    }
}