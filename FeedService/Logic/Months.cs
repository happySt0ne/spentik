using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FeedService.Logic {
	public static class Months {
		private static Dictionary<MonthName, int> _monthLength = new(12);

		static Months() {
			_monthLength[MonthName.January] = 31;
			_monthLength[MonthName.February] = 28;
			_monthLength[MonthName.March] = 31;
			_monthLength[MonthName.April] = 30;
			_monthLength[MonthName.May] = 31;
			_monthLength[MonthName.June] = 30;
			_monthLength[MonthName.July] = 31;
			_monthLength[MonthName.August] = 31;
			_monthLength[MonthName.September] = 30;
			_monthLength[MonthName.October] = 31;
			_monthLength[MonthName.November] = 30;
			_monthLength[MonthName.December] = 31;
		}

		public static int GetMonthLength(int monthNumber) {
			return _monthLength[(MonthName)monthNumber];
		}

		public static int GetMonthLength(MonthName monthName) {
			return _monthLength[monthName];
		}
	}
}
