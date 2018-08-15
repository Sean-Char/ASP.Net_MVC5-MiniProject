using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Renta_Flix.Models;

namespace Renta_Flix.ViewModels
{
	public class MovieFormViewModel
	{
		public IEnumerable<Genre> Genres { get; set; }
		public Movie Movie { get; set; }
		public string Title
		{
			get
			{
				if (Movie != null && Movie.Id != 0)
					return "Edit Movie";

				return "New Movie";
			}
		}
	}
}