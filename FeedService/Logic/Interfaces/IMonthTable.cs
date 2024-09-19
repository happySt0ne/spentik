namespace FeedService.Logic.Interfaces {
	public interface IMonthTableService {
		public MonthTable GetTable(int year, MonthName month);

		public MonthTable GetTable(int year, int month) {
			return GetTable(year, (MonthName)month);
		}
	}
}
