using Cafeservello.Common.Domain.Entities;
using Cafeservello.Common.Domain.ObjectValues;
using Cafeservello.Modules.Domain.Users.Common.Enums;
using Cafeservello.Modules.Domain.Users.Common.ObjectValues;

namespace Cafeservello.Modules.Domain.Users.Entities
{
    public sealed class User : BasePerson
    {
        public Privacy Privacy { get; private set; } = new Privacy();
        public Guid ProfileId { get; private set; }
        public Profile Profile { get; private set; }  = new Profile();
        public Settings? Settings { get; private set; }
        private User() { }
        public User(
            Guid userId, 
            string name, 
            Address? address, 
            Contact? contact, 
            Personal? personal, 
            Privacy privacy, 
            Profile profile, 
            Settings? settings = null) : 
            base(userId, name, address, contact, personal)
        {
            Privacy = privacy;
            ProfileId = profile.Id;
            Profile = profile;
            Settings = settings ?? new Settings(Themes.Classic);
        }
    }
}
