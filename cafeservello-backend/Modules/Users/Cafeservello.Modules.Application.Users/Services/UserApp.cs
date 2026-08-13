using Cafeservello.Common.Application.Services;
using Cafeservello.Modules.Application.Users.Interfaces.Services;
using Cafeservello.Modules.Domain.Users.Entities;
using Cafeservello.Modules.Domain.Users.Interfaces.Repository;
using Cafeservello.Modules.Domain.Users.Interfaces.Services;

namespace Cafeservello.Modules.Application.Users.Services
{
    public class UserApp : App<User, IUserService>, IUserApp
    {
        public UserApp(IUserService userService) : base(userService)
        {
        }
    }
}
