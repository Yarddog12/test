using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test.Models;

namespace test.Controllers {
	public class HomeController : Controller {

		public IActionResult Index() {

			

			return View();
		}

		public IActionResult Demo() {
			OrgUser org = new OrgUser();

			using (var ctx = new lodsContext()) {
				org = new OrgUser();
				org.Organization = ctx.Organization.ToList();
				org.Users = ctx.Users.ToList();
			}
			return View(org);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error() {
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
