using Cafeservello.Common.Application.Interfaces;
using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.Interfaces.Repository;

namespace Cafeservello.Common.Application.Services
{
    public abstract class App<TEntity, TDto, TContext> : IApp<TEntity, TDto, TContext> 
        where TEntity : BaseEntity
        where TDto : class
        where TContext : IRepository<TEntity>
    {
        protected readonly TContext _context;
        protected App(TContext context)
        {
            _context = context;
        }
        protected abstract TDto MapRead(TEntity entity);
        protected abstract TEntity MapCreate(TDto dto);
        protected abstract TEntity MapUpdate(TDto dto, TEntity entity);

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _context.GetAllAsync();
            return entities.Select(MapRead);
        }
        public async Task CreateAsync(TDto entity)
        {
            var entities = MapCreate(entity);
            await _context.CreateAsync(entities);
        }
        public async Task<TDto> UpdateAsync(TDto dto, Guid? id = null)
        {
            var userId = id ?? Guid.Empty;

            var existingUser = await _context.GetByIdAsync(userId);

            MapUpdate(dto, existingUser);

            var updatedEntity = await _context.UpdateAsync(existingUser, userId);
            return MapRead(updatedEntity);
        }
        public async Task<TDto> GetByIdAsync(Guid id)
        {
            var entity = await _context.GetByIdAsync(id);
            return MapRead(entity);
        }

        
    }
}
