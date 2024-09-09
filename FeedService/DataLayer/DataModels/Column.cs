using System.ComponentModel.DataAnnotations;

namespace FeedService.DataLayer.DataModels {
	public class Column {
		[Key]
		public int ColumnId { get; set; }

		public string Name { get; set; }

		public Column(string name) {
			Name = name;
		}

		public virtual Day Table { get; set; }
	}
}
