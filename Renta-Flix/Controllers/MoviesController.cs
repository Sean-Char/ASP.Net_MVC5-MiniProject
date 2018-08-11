using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Renta_Flix.Models;

namespace Renta_Flix.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
			var movie = new Movie() { Name = "The Predator" };

		    return View(movie);
        }

		public ActionResult Edit(int id)
		{
			return Content("id=" + id);
		}

		// movies
		public ActionResult Index(int? pageIndex, string sortBy)
		{
			if (pageIndex.HasValue)
				pageIndex = 1;

			if (string.IsNullOrWhiteSpace(sortBy))
				sortBy = "Name";

			return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
		}
    }
}