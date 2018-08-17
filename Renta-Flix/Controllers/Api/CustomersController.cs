
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Renta_Flix.Models;

namespace Renta_Flix.Controllers.Api
{
	public class CustomersController : ApiController
	{
		private ApplicationDbContext _context;

		public CustomersController()
		{
			_context = new ApplicationDbContext();
		}

		// GET /api/customers
		public IEnumerable<Customer> GetCustomers()
		{
			return _context.Customers.ToList();
		}

		// GET /api/customers/1
		public Customer GetCustomer(int id)
		{
			var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customer == null)
				throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

			return customer;
		}

		// POST /api/customers
		[HttpPost]
		public Customer CreateCustomer(Customer customer)
		{
			if (!ModelState.IsValid)
				throw new HttpResponseException(HttpStatusCode.BadRequest);

			_context.Customers.Add(customer);
			_context.SaveChanges();

			return customer;
		}

		// PUT /api/customers/1
		[HttpPut]
		public void UpdateCustomer(int id, Customer customer)
		{
			if (!ModelState.IsValid)
				throw new HttpResponseException(HttpStatusCode.BadRequest);

			var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
				throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

			customerInDb.Name = customer.Name;
			customerInDb.Birthdate = customer.Birthdate;
			customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
			customerInDb.MembershipTypeId = customer.MembershipTypeId;

			_context.SaveChanges();
		}

		// DELETE /api/customers/1
		[HttpDelete]
		public void DeleteCusomer(int id)
		{
			var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
				throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

			_context.Customers.Remove(customerInDb);
			_context.SaveChanges();
		}
    }
}
