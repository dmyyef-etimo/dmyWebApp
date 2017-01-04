using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using dmyWebApp.Models;

namespace dmyWebApp.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            return View(GetCustomers());
        }

        private IEnumerable<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "John Smith"},
                new Customer {Id = 2, Name = "Mary Williams"}
            };
            return customers;
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id) ?? new Customer {Name = "Unknown", Id = 0};
            return View(customer);
        }
    }
}