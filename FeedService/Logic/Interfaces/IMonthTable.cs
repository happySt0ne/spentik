namespace FeedService.Logic.Interfaces {
	public interface IMonthTableService {
		public Table GetTable(int year, MonthName month);
	}
}
