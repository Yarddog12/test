using System;
using Microsoft.EntityFrameworkCore;

namespace test.Models {
	public class DatabaseContext : DbContext {
		public DatabaseContext() { }
		public DbSet<OrganizationModel> Organization { get; set; }
		public DbSet<UserModel> User { get; set; }
	}
}
