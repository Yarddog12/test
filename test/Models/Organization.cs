using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace test.Models {
	public class OrganizationModel {

		public List<UserModel> User { get; set; }

		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Enter Organization")]
		public string OrganizationName { get; set; }
		[Required(ErrorMessage = "Enter Address")]
		public string Address { get; set; }
		[Required(ErrorMessage = "Enter City")]
		public string City { get; set; }
		[Required(ErrorMessage = "Enter State")]
		public string State { get; set; }
		[Required(ErrorMessage = "Enter ZipCode")]
		public string ZipCode { get; set; }

		public string DateAdded { get; set; }
		public string DateUpdated { get; set; }
		public bool IsActive { get; set; }
	}
}
