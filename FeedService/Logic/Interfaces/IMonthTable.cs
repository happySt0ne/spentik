namespace FeedService.Logic.Interfaces {
	public interface IMonthTableService {
		public MountTable GetTable(int year, MonthName month);
	}
}
