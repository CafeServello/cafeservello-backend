using Cafeservello.Common.Infrastructure.Repository;
using Cafeservello.Modules.Domain.Users.Entities;
using Cafeservello.Modules.Domain.Users.Interfaces.Repository;
using Cafeservello.Modules.Infrastructure.Users.Context;

namespace Cafeservello.Modules.Infrastructure.Users.Repository
{
    public sealed class UserRepository : Repository<User, DatabaseContext>, IUserRepository
    {
        public UserRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
