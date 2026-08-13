using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
namespace Cafeservello.Common.Infrastructure.Repository
{
    public abstract class Repository<TEntity, TContext> : IRepository<TEntity> where TEntity : BaseEntity where TContext : DbContext
    {
        protected readonly TContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(TContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
