using FeedService.DataLayer.DTO;
using FeedService.DataLayer.Interfaces;
using System.Text.Json.Serialization;

namespace FeedService.DataLayer.Models {
	public class Product : ITable {
		[JsonIgnore]
		public int Id { get; set; }
		public int ProductTypeId { get; set; }

		public double Cost { get; set; }

		[JsonIgnore]
		public virtual ICollection<DayProduct>? DayProducts { get; set; } = null!;

		[JsonIgnore]
		public virtual ProductType? ProductType { get; set; } = null!;

		public static Product operator +(Product product, ProductDto productDto) {
			Product result = new();

			result.Id = product.Id;
			result.ProductTypeId = productDto.ProductTypeId ?? product.ProductTypeId;
			result.Cost = productDto.Cost ?? product.Cost;

			return result;
		}
	}
}
