using FeedService.DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace FeedService.DataLayer {
	public class FinlahContext : DbContext {
		public FinlahContext(DbContextOptions<FinlahContext> options) 
			: base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductType> ProductTypes { get; set; }
	}
}
