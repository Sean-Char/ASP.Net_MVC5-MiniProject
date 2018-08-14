using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Renta_Flix.Models;

namespace Renta_Flix.ViewModels
{
	public class CustomerFormViewModel
	{
		public IEnumerable<MembershipType> MembershipTypes { get; set; }
		public Customer Customer { get; set; }
	}
}