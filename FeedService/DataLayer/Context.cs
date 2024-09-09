using FeedService.DataLayer.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FeedService.DataLayer {
	public class Context : DbContext {

		public DbSet<Item> Items { get; set; }

		public DbSet<Column> Columns { get; set; }

		public DbSet<Day> Tables { get; set; }

		public Context(DbContextOptions<Context> options) : base(options) { }
	}
}
