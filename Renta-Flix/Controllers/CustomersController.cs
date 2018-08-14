using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Renta_Flix.Models;
using Renta_Flix.ViewModels;

namespace Renta_Flix.Controllers
{
    public class CustomersController : Controller
    {
		private ApplicationDbContext _context;

		public CustomersController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		public ActionResult New()
		{
			var membershipTypes = _context.MembershipType.ToList();
			var viewModel = new CustomerFormViewModel
			{
				MembershipTypes = membershipTypes
			};

			return View("CustomerForm", viewModel);
		}

		[HttpPost]
		public ActionResult Create(Customer customer)
		{
			_context.Customers.Add(customer);
			_context.SaveChanges();

			return RedirectToAction("Index", "Customers");
		}

		public ViewResult Index()
        {
			var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

		public ActionResult Edit(int id)
		{
			var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customer == null)
				return HttpNotFound();

			var viewModel = new CustomerFormViewModel
			{
				Customer = customer,
				MembershipTypes = _context.MembershipType.ToList()
			};

			return View("CustomerForm", viewModel);
		}
    }
}