using System;
using System.ComponentModel.DataAnnotations;

namespace test.Models {
	public class UserModel {
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "Enter First Name")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "Enter Last Name")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Enter Email")]
		public string EmailAddress { get; set; }

		public string DateAdded { get; set; }
		public string DateUpdated { get; set; }
		public bool IsActive { get; set; }
	}
}
