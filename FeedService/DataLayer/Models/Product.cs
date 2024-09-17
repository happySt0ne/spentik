﻿using FeedService.DataLayer.Interfaces;

namespace FeedService.DataLayer.Models
{
    public class Product : ITable {
		public int Id { get; set; }
		public int ProductTypeId { get; set; }
		public double Cost { get; set; }

		public virtual ProductType ProductType { get; set; }
	}
}
