using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactWeb.Models
{
	public class Contact
	{
		public int Id { get; set; }
		public Guid UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime birthday { get; set; }
		public string contactPrim { get; set; }
		public string contactSec { get; set; }
		public string streetAddress1 { get; set; }
		public string streetAddress2 { get; set; }
		public string city { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }

	}
}