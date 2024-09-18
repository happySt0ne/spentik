namespace FeedService.Logic {

	public class MonthTable {
		public List<DateOnly> Dates { get; init; } = new();

		public Dictionary<string, List<int>> Sums;

		public MonthTable(MonthName monthName, int year, Dictionary<string, List<int>> sums) {
			for (int i = 1; i <= Months.GetMonthLength(monthName); ++i) {

				DateOnly date = new(year, (int)monthName, i);
				Dates.Add(date);
			}

			Sums = sums;
		}
	}
}
