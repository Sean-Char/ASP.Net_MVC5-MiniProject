using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Renta_Flix.Models;
using System.ComponentModel.DataAnnotations;

namespace Renta_Flix.Dtos
{
	public class CustomerDto
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		public bool IsSubscribedToNewsletter { get; set; }

		public byte MembershipTypeId { get; set; }

		[Min18YearsIfAMember]
		public DateTime? Birthdate { get; set; }
	}
}