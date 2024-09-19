using FeedService.DataLayer.DTO;
using FeedService.DataLayer.Models;
using FeedService.Logic.interfaces;
using FeedService.Logic.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FeedService.Logic.Services;

public class MonthTableService : IMonthTableService {
	private ICrudService<DayProduct, DayProductDto> _dayProductCrud;
	private ISearchService _searchService;

	public MonthTableService(ICrudService<DayProduct, DayProductDto> crudService, ISearchService searchService) {
		_dayProductCrud = crudService;
		_searchService = searchService;
	}

	public MonthTable GetTable(int year, MonthName month) {
		Dictionary<string, List<double>> sums = new(Months.GetMonthLength(month));

		List<DayProduct> dayProducts = GetDayProducts(year, month);
		HashSet<string> productTypeNames = GetProductTypeNames(dayProducts);

		foreach (var productTypeName in productTypeNames) {
			var sumsList = dayProducts
				.Where(dp => dp.Product.ProductType?.Name == productTypeName)
				.GroupBy(dp => dp.Day.Date)
				.OrderBy(g => g.Key)
				.Select(g => g.Sum(dp => dp.Product.Cost))
				.ToList();

			sums.Add(productTypeName, sumsList);
		}

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
}
