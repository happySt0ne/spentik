using FeedService.DataLayer.Interfaces;
using System.Linq.Expressions;

namespace FeedService.Logic.Interfaces {
	public interface ISearchService {
		public T Get<T>(Expression<Func<T, bool>> predicate) 
		where T : class, ITable;
		
		public List<T> GetList<T>(Expression<Func<T, bool>> predicate) 
		where T : class, ITable;
	}
}
