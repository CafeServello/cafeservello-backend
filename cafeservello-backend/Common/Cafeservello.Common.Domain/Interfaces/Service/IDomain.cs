using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.Interfaces.Patterns;

namespace Cafeservello.Common.Domain.Interfaces.Service
{
    public interface IDomain<TEntity> : IPattern<TEntity> where TEntity : BaseEntity
    {
    }
}
