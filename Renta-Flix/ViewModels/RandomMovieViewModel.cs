using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Renta_Flix.Models;

namespace Renta_Flix.ViewModels
{
	public class RandomMovieViewModel
	{
		public Movie Movie { get; set; }
		public List<Customer> Customer { get; set; }
	}
}