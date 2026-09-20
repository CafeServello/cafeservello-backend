using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.Interfaces.Patterns;
using Cafeservello.Common.Domain.Interfaces.Repository;

namespace Cafeservello.Common.Application.Interfaces
{
    public interface IApp<TEntity, TDTO, TContext> : IPattern<TDTO>
        where TEntity : BaseEntity
        where TDTO : class 
        where TContext : IRepository<TEntity>
    {

    }
}
