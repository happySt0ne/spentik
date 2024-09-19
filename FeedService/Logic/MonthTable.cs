using System.Text.Json.Serialization;

namespace FeedService.Logic {

	public class MonthTable {
		public List<DateOnly> Dates { get; init; } = new();

		[JsonInclude]
		public Dictionary<string, List<double>> Sums;

		public MonthTable(MonthName monthName, int year, Dictionary<string, List<double>> sums) {
			for (int i = 1; i <= Months.GetMonthLength(monthName); ++i) {

				DateOnly date = new(year, (int)monthName, i);
				Dates.Add(date);
			}

			Sums = sums;
		}
	}
}
