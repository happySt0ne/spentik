using FeedService.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace FeedService.DataLayer {
	public class FinlahContext : DbContext {
		public FinlahContext(DbContextOptions<FinlahContext> options)
				: base(options) {
			ChangeTracker.LazyLoadingEnabled = true;
			Database.EnsureCreated();
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }
		public DbSet<Day> Day { get; set; }
		public DbSet<DayProduct> DayProduct { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			var dbUserName = Environment.GetEnvironmentVariable("DB_USER");
			var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");
			var dbName = Environment.GetEnvironmentVariable("DB_NAME");
		
			string connectionString = $"Server=db,1433;Database={dbName};User={dbUserName};"
				+ $"Password={dbPassword}$;TrustServerCertificate=True";
			
			optionsBuilder.UseSqlServer(connectionString);

			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseLazyLoadingProxies();
		}
	}
}
