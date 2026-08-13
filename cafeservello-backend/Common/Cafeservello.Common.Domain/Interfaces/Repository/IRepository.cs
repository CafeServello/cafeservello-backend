using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.Interfaces.Patterns;

namespace Cafeservello.Common.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IPattern<TEntity> where TEntity : BaseEntity
    {
    }
}
