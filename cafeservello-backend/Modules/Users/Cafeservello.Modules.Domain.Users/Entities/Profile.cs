using Cafeservello.Common.Domain.Entities;
using Cafeservello.Modules.Domain.Users.Common.Enums;
using Cafeservello.Modules.Domain.Users.Common.ObjectValues;

namespace Cafeservello.Modules.Domain.Users.Entities
{
    public sealed class Profile : BaseNamed
    {
        //public Permissions? Permissions { get; private set; }
        public ProfileType ProfileType { get; private set; }
    }
}
