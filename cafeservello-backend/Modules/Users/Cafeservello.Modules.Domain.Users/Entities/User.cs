using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.ObjectValues.Entities;
using Cafeservello.Modules.Domain.Users.Common.Enums;
using Cafeservello.Modules.Domain.Users.Common.ObjectValues.Entities;

namespace Cafeservello.Modules.Domain.Users.Entities
{
    public sealed class User : BasePerson
    {
        public Guid ProfileId { get; private set; }
        public Profile Profile { get; private set; }
        public Privacy Privacy { get; private set; }
        public Settings Settings { get; private set; } = new Settings(Themes.Classic);
        private User(){}
        public User(
            Guid userId, 
            string name, 
            string? description,
            Address address, 
            Contact contact, 
            Personal personal, 
            Privacy privacy, 
            Profile profile, 
            Settings settings): 
            base(userId, name, description, address, contact, personal)
        {
            Privacy = privacy;
            ProfileId = profile.Id;
            Profile = profile;
            Settings = settings;
        }

        
        public void UpdateProfile(Guid userId, Profile profile)
        {
            Profile?.Update(
                profile.ProfileType,
                profile.Permissions,
                userId,
                profile.Name,
                profile.Description
            );
            base.Update(userId);
        }

        public void UpdatePrivacy(Guid userId, Privacy privacy)
        {
            Privacy?.Update(
                privacy.UserName,
                privacy.Password
            );

            base.Update(userId);
        }

        public void UpdateSettings(Guid userId, Settings settings)
        {
            Settings?.Update(
                settings.Themes
            );
            base.Update(userId);
        }

        public void Update(Guid userId, string name, string? description, Privacy privacy, Settings settings, Address address, Contact contact, Personal personal)
        {

            Privacy.Update(
                privacy.UserName,
                privacy.Password
            );

            Settings.Update(
                settings.Themes
            );

            base.Update(userId);
        }
    }
}
