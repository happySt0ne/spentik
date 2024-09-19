using FeedService.DataLayer.Interfaces;
using Microsoft.Identity.Client;
using System.Text.Json.Serialization;

namespace FeedService.DataLayer.Models {
	public class Day: ITable {
		[JsonIgnore]
		public int Id { get; set; }
		public DateOnly Date { get; set; }

		[JsonIgnore]
		public virtual ICollection<DayProduct>? DayProducts { get; set; } = null!;
	}
}
