﻿using FeedService.DataLayer.Interfaces;
using System.Text.Json.Serialization;

namespace FeedService.DataLayer.Models {
	public class Product : ITable {
		[JsonIgnore]
		public int Id { get; set; }
		public int ProductTypeId { get; set; }

		public double Cost { get; set; }

		public virtual ICollection<DayProduct> DayProducts { get; set; } = null!;
		public virtual ProductType ProductType { get; set; } = null!;
	}
}
