using Cafeservello.Common.Domain.Entities;
using Cafeservello.Modules.Domain.Users.Common.Enums;
using Cafeservello.Modules.Domain.Users.Common.ObjectValues.Entities;

namespace Cafeservello.Modules.Domain.Users.Entities
{
    public sealed class Profile : BaseNamed
    {
        public Permissions Permissions { get; private set; }
        public ProfileType ProfileType { get; private set; }
        private Profile() { }

        public Profile(Guid userId, string name, string? description, ProfileType profileType, Permissions permissions) : base(userId, name, description)
        {
            ProfileType = profileType;
            Permissions = permissions;
        }

        public void Update(ProfileType profileType, Permissions permissions, Guid userId, string name, string? description)
        {
            ProfileType = profileType;
            Permissions = permissions;
            base.Update(userId, name, description);
        }
    }
}
