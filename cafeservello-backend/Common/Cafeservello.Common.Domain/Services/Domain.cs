using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.Interfaces.Repository;
using Cafeservello.Common.Domain.Interfaces.Service;

namespace Cafeservello.Common.Domain.Services
{
    public abstract class Domain<TEntity> : IDomain<TEntity> where TEntity : BaseEntity 
    {
        private readonly IRepository<TEntity> _repository;

        protected Domain(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }
    }
}
