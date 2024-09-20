using FeedService.DataLayer.DTO;
using FeedService.DataLayer.Models;
using FeedService.Logic.interfaces;
using FeedService.Logic.Interfaces;
using Microsoft.EntityFrameworkCore;

using CostsList = System.Collections.Generic.List<double>;

namespace FeedService.Logic.Services;

public class MonthTableService : IMonthTableService {
	private ISearchService _searchService;

	public MonthTableService(ISearchService searchService) {
		_searchService = searchService;
	}

	public MonthTable GetTable(int year, MonthName month) {
		List<DayProduct> dayProducts = GetDayProducts(year, month);
		HashSet<string> productTypeNames = GetProductTypeNames(dayProducts);
		Dictionary<string, CostsList> sums = GetSums(dayProducts, productTypeNames, month);

		return new MonthTable(month, year, sums);
	}

	private List<DayProduct> GetDayProducts(int year, MonthName month) {
		return _searchService
			.GetList<DayProduct>(dp =>
			dp.Day.Date.Month == (int)month
			&& dp.Day.Date.Year == year);
	}

	private HashSet<string> GetProductTypeNames(List<DayProduct> dayProducts) {
		HashSet<string> result = new();

		foreach (var dayProduct in dayProducts) {
			var productTypeName = dayProduct.Product.ProductType.Name;

			if (productTypeName is null) continue;

			result.Add(productTypeName);
		}

		return result;
	}

	private Dictionary<string, CostsList> GetSums(
			List<DayProduct> dayProducts, 
			HashSet<string> productTypeNames, 
			MonthName month) {
		int monthLength = Months.GetMonthLength(month);
		Dictionary<string, CostsList> result = new(monthLength);

		foreach (var productTypeName in productTypeNames) {
			var daySums = dayProducts
				.Where(dp => dp.Product.ProductType?.Name == productTypeName)
				.GroupBy(dp => dp.Day.Date)
				.OrderBy(g => g.Key)
				.Select(g => new { DayNumber = g.Key.Day, Sum = g.Sum(dp => dp.Product.Cost) })
				.ToDictionary(item => item.DayNumber, item => item.Sum);

			var costsColumn = Enumerable.Range(1, monthLength)
				.Select(dayNumber => daySums.TryGetValue(dayNumber, out var sum) ? sum : 0)
				.ToList();

			result.Add(productTypeName, costsColumn);
		}

		return result;
	}
}
