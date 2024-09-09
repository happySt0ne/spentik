using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedService.DataLayer.DataModels {
	[Table("Days")]
	public class Day {
		[Key]
		public int DayId { get; set; }

		public int ColumnId { get; set; }
		public Column Column { get; set; }

		public int ItemId { get; set; } 
		public Item Item { get; set; }

		public DateOnly Date { get; set; }
	}
}
