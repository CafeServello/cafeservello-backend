using Cafeservello.Common.Domain.Entities;

namespace Cafeservello.Common.Domain.Interfaces.Patterns
{
    public interface IPattern<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
