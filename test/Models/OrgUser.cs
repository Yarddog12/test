using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models {
	public class OrgUser {
		public List<Organization> Organization { get; set; }
		public List<Users> Users { get; set; }
	}
}
