using FeedService.DataLayer.Interfaces;
using FeedService.DataLayer.Models;
using Humanizer;

namespace FeedService.DataLayer.DTO {
	public class DayDto : IDto<Day, DayDto> {
		public DateOnly? Date { get; set; }

		public Day CreateFromDto() {
			if (Date is null) {
				throw new ArgumentNullException();
			}

			Day day = new() {
				Date = Date.Value
			};

			return day;
		}

		public static Day operator +(Day baseType, DayDto dtoType) {
			Day result = new();
			
			result.Id = baseType.Id;
			result.Date = dtoType.Date ?? baseType.Date;

			return result;
		}
	}
}
