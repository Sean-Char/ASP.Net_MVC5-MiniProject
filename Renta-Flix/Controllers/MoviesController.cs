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
			//return Content("Hello World");
			//return HttpNotFound();
			//return new EmptyResult();
			//return RedirectToAction("Index","Home", new { page = 1, sortBy = "name"});
        }
    }
}