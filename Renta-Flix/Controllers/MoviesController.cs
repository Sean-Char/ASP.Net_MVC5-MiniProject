using System.Collections.Generic;
using System.Web.Mvc;
using Renta_Flix.Models;
using Renta_Flix.ViewModels;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{
		public ViewResult Index()
		{
			var movies = GetMovies();

			return View(movies);
		}

		private IEnumerable<Movie> GetMovies()
		{
			return new List<Movie>
			{
				new Movie { Id = 1, Name = "The Predator" },
				new Movie { Id = 2, Name = "Ready Player One" }
			};
		}

		// GET: Movies/Random
		public ActionResult Random()
		{
			var movie = new Movie() { Name = "Shrek!" };
			var customers = new List<Customer>
			{
				new Customer { Name = "Customer 1" },
				new Customer { Name = "Customer 2" }
			};

			var viewModel = new RandomMovieViewModel
			{
				Movie = movie,
				Customers = customers
			};

			return View(viewModel);
		}
	}
}