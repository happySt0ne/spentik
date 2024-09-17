using FeedService.DataLayer.Interfaces;
using FeedService.DataLayer.Models;

namespace FeedService.DataLayer.DTO {
	public class ProductDto: IDto<Product, ProductDto> {
		public double? Cost { get; set; }
		public int? ProductTypeId { get; set; }

		public static Product operator +(Product baseType, ProductDto dtoType) {
			Product result = new();

			result.Id = baseType.Id;
			result.ProductTypeId = dtoType.ProductTypeId ?? baseType.ProductTypeId;
			result.Cost = dtoType.Cost ?? baseType.Cost;

			return result;
		}
	}
}
