using System.ComponentModel.DataAnnotations;

namespace FeedService.DataLayer.DataModels {
	public class Item {
		[Key]
		public int ItemId { get; private set; }

		public string Name { get; init; }

		public double Cost { get; private set; }

		public Item(string name, double cost) {
			Name = name;
			Cost = cost;
		}

		public virtual Day Table { get; set; }
	}
}
