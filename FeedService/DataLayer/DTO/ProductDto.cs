using FeedService.DataLayer.Interfaces;
using FeedService.DataLayer.Models;

namespace FeedService.DataLayer.DTO;

public class ProductDto : IDto<Product, ProductDto> {
	public double? Cost { get; set; }
	public int? ProductTypeId { get; set; }

	public Product CreateFromDto() {
		if (Cost is null || ProductTypeId is null) {
			throw new ArgumentNullException("Can't create Product bcz of null fields");
		}

		Product product = new Product() {
			Cost = Cost.Value,
			ProductTypeId = ProductTypeId.Value
		};

		return product;
	}

	public static Product operator +(Product baseType, ProductDto dtoType) {
		Product result = new();

		result.Id = baseType.Id;
		result.ProductTypeId = dtoType.ProductTypeId ?? baseType.ProductTypeId;
		result.Cost = dtoType.Cost ?? baseType.Cost;

		return result;
	}
}
