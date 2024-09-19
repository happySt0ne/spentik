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
			base.OnConfiguring(optionsBuilder);
			optionsBuilder
				.UseLazyLoadingProxies();
		}
	}
}
