using Cafeservello.Common.Application.Interfaces.Service;
using Cafeservello.Modules.Domain.Users.Entities;
using Cafeservello.Modules.Domain.Users.Interfaces.Services;

namespace Cafeservello.Modules.Application.Users.Interfaces.Services
{
    public interface IUserApp : IApp<User, IUserService>
    {
    }
}
