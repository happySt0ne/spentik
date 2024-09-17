using FeedService.DataLayer.Interfaces;
using FeedService.DataLayer.Models;

namespace FeedService.DataLayer.DTO {
	public class ProductTypeDto : IDto<ProductType, ProductTypeDto> {
		public string? Name { get; set; }

		public static ProductType operator +(ProductType baseType, ProductTypeDto dtoType) {
			ProductType result = new();

			result.Id = baseType.Id;
			result.Name = dtoType.Name ?? baseType.Name;

			return result;
		}
	}
}
