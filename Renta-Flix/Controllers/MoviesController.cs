using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Renta_Flix.Models;
using Renta_Flix.ViewModels;

namespace Renta_Flix.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
			var movie = new Movie() { Name = "The Predator" };

			var customers = new List<Customer>
			{
				new Customer { Name = "Customer 1" },
				new Customer { Name = "Customer 2" }
			};

			var viewModel = new RandomMovieViewModel
			{
				Movie = movie,
				Customer = customers
			};

		    return View(viewModel);
        }

    }
}