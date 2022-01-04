using Microsoft.EntityFrameworkCore;
using StartBootstrap_Asp.Models;

namespace StartBootstrap_Asp.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions options) : base(options){ }


		public DbSet<Settings> settings { get; set; }
		public DbSet<SosialMedia> sosialMedias { get; set; }
		public DbSet<ContactMessage> contactMessages { get; set; }
		public DbSet<Portfolio> portfolios { get; set; }
	}
}
