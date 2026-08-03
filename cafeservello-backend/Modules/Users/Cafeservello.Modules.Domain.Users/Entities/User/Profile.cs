using Cafeservello.Common.Domain.Common.Bases;
using Cafeservello.Modules.Domain.Users.Enums;
using Cafeservello.Modules.Domain.Users.ObjectValues;

namespace Cafeservello.Modules.Domain.Users.Entities.User
{
    public sealed class Profile : BaseNamed
    {
        public Permissions? Permissions { get; private set; }
        public ProfileType ProfileType { get; private set; }
    }
}
