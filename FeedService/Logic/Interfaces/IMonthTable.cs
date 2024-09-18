namespace FeedService.Logic.Interfaces {
	public interface IMonthTableService {
		public MonthTable GetTable(int year, MonthName month);
	}
}
