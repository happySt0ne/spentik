using FeedService.DataLayer.Interfaces;

namespace FeedService.Logic.interfaces
{
    public interface ICrudService<T, TDto> 
			where T: ITable
			where TDto: IDto<T, TDto> {
		public T? Get(int id);
		public ICollection<T>? Get();
		public void Create(T item);
		public void Update(int id, TDto changes);
		public void Delete(int id);
	}
}
