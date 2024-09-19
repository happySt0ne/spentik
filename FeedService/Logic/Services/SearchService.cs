using FeedService.DataLayer;
using FeedService.DataLayer.Interfaces;
using FeedService.Logic.Interfaces;
using System.Linq.Expressions;

namespace FeedService.Logic.Services {
	public class SearchService : ISearchService {
		private static FinlahContext _dbContext = null!;

		public SearchService(FinlahContext context) {
			_dbContext = context;
		}

		public T Get<T>(Expression<Func<T, bool>> predicate) 
		where T: class, ITable {
			return _dbContext.Set<T>().First(predicate);
		}

		public List<T> GetList<T>(Expression<Func<T, bool>> predicate)
		where T: class, ITable {
			return _dbContext.Set<T>().Where(predicate).ToList();
		}
	}
}
