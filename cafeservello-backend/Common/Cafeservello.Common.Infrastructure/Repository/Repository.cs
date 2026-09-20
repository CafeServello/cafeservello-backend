using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.Interfaces.Patterns;
using Cafeservello.Common.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
namespace Cafeservello.Common.Infrastructure.Repository
{
    public abstract class Repository<TEntity, TContext> : IRepository<TEntity> where TEntity : BaseEntity where TContext : DbContext
    {
        protected readonly TContext _context;
        protected readonly DbSet<TEntity> Entity;

        public Repository(TContext context)
        {
            _context = context;
            Entity = context.Set<TEntity>();
        }
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Entity.ToListAsync();
        }
        public virtual async Task CreateAsync(TEntity entity)
        {
            await Entity.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity, Guid? id)
        {
            Entity.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await Entity.FirstOrDefaultAsync(x => x.Id == id && x.IsActive);
        }
    }
}
