﻿namespace FeedService.DataLayer.Models {
	public class ProductType {
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual ICollection<Product> Products { get; set; }

		public ProductType(string name) {
			Name = name;
		}
	}
}
