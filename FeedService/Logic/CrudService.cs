using FeedService.DataLayer;
using FeedService.DataLayer.Interfaces;
using FeedService.Logic.interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FeedService.Logic
{
    public class CrudService<T, TDto> : ICrudService<T, TDto>
			where T : class, ITable
			where TDto : IDto<T, TDto> {
		private FinlahContext _context;

		public CrudService(FinlahContext context) {
			_context = context;
		}

		public virtual void Create(T item) {
			_context.Set<T>().Add(item);
			_context.SaveChanges();
		}

		public void Delete(int id) {
			T? itemToRemove = _context.Set<T>().Find(id);
			if (itemToRemove is null) return;

			_context.Set<T>().Remove(itemToRemove);
		}

		public T? Get(int id) {
			return _context.Set<T>().Find(id);
		}

		public ICollection<T>? Get() {
			return _context.Set<T>().ToList();
		}

		public virtual void Update(int id, TDto changes) {
			T? itemToUpdate = _context.Set<T>().Find(id);

			if (itemToUpdate is null) return;

			T newItem = itemToUpdate + changes;

			_context.Entry<T>(itemToUpdate).CurrentValues.SetValues(newItem);
			_context.SaveChanges();
		}
	}
}
