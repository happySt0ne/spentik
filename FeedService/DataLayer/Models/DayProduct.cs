using FeedService.DataLayer.Interfaces;
using System.Text.Json.Serialization;

namespace FeedService.DataLayer.Models {
	public class DayProduct: ITable {
		[JsonIgnore]
		public int Id { get; set; }
		public int DayId { get; set; }
		public int ProductId { get; set; }

		public virtual Day Day { get; set; } = null!;
		public virtual Product Product { get; set; } = null!;
	}
}
