using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.Interfaces.Patterns;
using Cafeservello.Common.Domain.Interfaces.Service;

namespace Cafeservello.Common.Application.Interfaces.Service
{
    public interface IApp<TEntity, TContext> : IPattern<TEntity> where TEntity : BaseEntity where TContext : IDomain<TEntity>
    {
    }
}
