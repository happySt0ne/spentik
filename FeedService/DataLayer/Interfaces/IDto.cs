namespace FeedService.DataLayer.Interfaces {
	public interface IDto<T, TDto> where TDto: IDto<T, TDto> {
		public static abstract T operator +(T baseType, TDto dtoType);
	}
}
