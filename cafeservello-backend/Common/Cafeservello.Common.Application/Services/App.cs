using Cafeservello.Common.Application.Interfaces.Service;
using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.Interfaces.Service;

namespace Cafeservello.Common.Application.Services
{
    public abstract class App<TEntity, TContext> : IApp<TEntity, TContext> where TEntity : BaseEntity where TContext : IDomain<TEntity>
    {
        protected readonly TContext _context;

        protected App(TContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.GetAllAsync();
        }
    }
}
