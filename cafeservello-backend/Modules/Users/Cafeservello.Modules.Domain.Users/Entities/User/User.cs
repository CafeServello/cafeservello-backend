using Cafeservello.Common.Domain.Common.Bases;
using Cafeservello.Common.Domain.Common.ObjectValues;
using Cafeservello.Modules.Domain.Users.Enums;
using Cafeservello.Modules.Domain.Users.ObjectValues;

namespace Cafeservello.Modules.Domain.Users.Entities.User
{
    public class User : BasePerson
    {
        public Privacy Privacy { get; private set; } = new Privacy();
        public Profile Profile { get; private set; }  = new Profile();
        public Settings? Settings { get; private set; }
        
        protected User() { }
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
            Profile = profile;
            Settings = settings ?? new Settings(Themes.Classic);
        }
    }
}
