using FeedService.DataLayer.Interfaces;
using FeedService.DataLayer.Models;

namespace FeedService.DataLayer.DTO {
	public class DayProductDto : IDto<DayProduct, DayProductDto> {
		public int? DayId { get; set; }
		public int? ProductId { get; set; }

		public DayProduct CreateFromDto() {
			if (DayId == null || ProductId is null) {
				throw new ArgumentNullException("Can't create dayProduct bcz of null fields");
			}

			DayProduct dayProduct = new() {
				DayId = DayId.Value,
				ProductId = ProductId.Value
			};

			return dayProduct;
		}

		public static DayProduct operator +(DayProduct baseType, DayProductDto dtoType) {
			DayProduct result = new();

			result.Id = baseType.Id;
			result.ProductId = dtoType.ProductId ?? baseType.ProductId;
			result.DayId = dtoType.DayId ?? baseType.DayId;

			return result;
		}
	}
}
