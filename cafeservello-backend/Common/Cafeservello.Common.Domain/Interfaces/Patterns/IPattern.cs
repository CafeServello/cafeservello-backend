namespace Cafeservello.Common.Domain.Interfaces.Patterns
{
    public interface IPattern<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task CreateAsync(T entity);
        Task<T> UpdateAsync(T entity, Guid? id = null);
        Task<T> GetByIdAsync(Guid id);
    }
}
