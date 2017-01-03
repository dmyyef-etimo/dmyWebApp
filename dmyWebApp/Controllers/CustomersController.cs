using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using dmyWebApp.Models;

namespace dmyWebApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> customers;

        public CustomersController()
        {
            customers = //new List<Customer>();
                Enumerable.Range(start: 1, count: 8)
                    .Select(id => new Customer {Id = id, Name = $"Customer-{id}"})
                    .ToList();
        }

        public ActionResult Index()
        {
            return View(customers);
        }

        public ActionResult Customer(int id)
        {
            var customer = customers.FirstOrDefault(c => c.Id == id) ?? new Customer {Name = "Unknown", Id = 0};
            return View(customer);
        }
    }
}