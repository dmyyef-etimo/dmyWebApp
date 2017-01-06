using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using dmyWebApp.Models;
using dmyWebApp.ViewModels;

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

        public ActionResult Edit(int id)
        {
            var customer = context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            var membershipTypes = context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel {Customer = customer, MembershipTypes = membershipTypes};
            return View(viewName: "CustomerForm", model: viewModel);
        }

        public ActionResult New()
        {
            var membershipTypes = context.MembershipTypes.ToList();
            var viewMobel = new CustomerFormViewModel {MembershipTypes = membershipTypes};
            return View(viewName: "CustomerForm", model: viewMobel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Birthday = customer.Birthday;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
            }
            context.SaveChanges();
            return RedirectToAction(actionName: "Index");
        }
    }
}