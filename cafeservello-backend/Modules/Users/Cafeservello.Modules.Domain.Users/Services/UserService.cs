using Cafeservello.Common.Domain.Interfaces.Repository;
using Cafeservello.Common.Domain.Services;
using Cafeservello.Modules.Domain.Users.Entities;
using Cafeservello.Modules.Domain.Users.Interfaces.Repository;
using Cafeservello.Modules.Domain.Users.Interfaces.Services;

namespace Cafeservello.Modules.Domain.Users.Services
{
    public class UserService : Domain<User>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {
        }
    }
}
