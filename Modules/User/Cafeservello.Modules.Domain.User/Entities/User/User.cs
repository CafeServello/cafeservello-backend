using Cafeservello.Common.Domain.Common.Bases;
using Cafeservello.Common.Domain.Common.ObjectValues;

namespace Cafeservello.Modules.Domain.User.Entities.User
{
    public class User : BasePerson
    {
        protected User() { }
        public User(Guid userId, string name, Address? address, Contact? contact) : base(userId, name, address, contact)
        {
        }
    }
}
