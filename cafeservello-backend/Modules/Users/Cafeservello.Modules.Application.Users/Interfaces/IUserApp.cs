using Cafeservello.Common.Application.Interfaces;
using Cafeservello.Modules.Domain.Users.DTOs;
using Cafeservello.Modules.Domain.Users.Entities;
using Cafeservello.Modules.Domain.Users.Interfaces.Repository;

namespace Cafeservello.Modules.Application.Users.Interfaces
{
    public interface IUserApp : IApp<User, UserDTO, IUserRepository>
    {
    }
}
