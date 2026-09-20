using Cafeservello.Common.Domain.Interfaces.Patterns;

namespace Cafeservello.Common.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IPattern<TEntity> where TEntity : class
    {
    }
}
