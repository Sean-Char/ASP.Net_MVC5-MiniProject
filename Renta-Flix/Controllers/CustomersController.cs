using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Renta_Flix.Models;

namespace Renta_Flix.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
			var customers = GetCustomer();

            return View(customers);
        }

		public ActionResult Details(int id)
		{
			var customer = GetCustomer().SingleOrDefault(c => c.Id == id);

			if (customer == null)
				return HttpNotFound();

			return View(customer);
		}

		private IEnumerable<Customer> GetCustomer()
		{
			return new List<Customer>
			{
				new Customer { Id = 1, Name = "Dak Prescott" },
				new Customer { Id = 2, Name = "Zeke Elliot" }
			};
		}
    }
}