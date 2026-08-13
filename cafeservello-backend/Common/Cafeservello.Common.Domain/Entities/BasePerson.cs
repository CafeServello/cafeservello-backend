using Cafeservello.Common.Domain.ObjectValues;

namespace Cafeservello.Common.Domain.Entities
{
    public abstract class BasePerson : BaseNamed
    {
        public Address? Address { get; private set; }
        public Contact? Contact { get; private set; }
        public Personal? Personal { get; private set; }
        protected BasePerson() { }

        public BasePerson(Guid userId, string name, Address? address, Contact? contact, Personal? personal) : base(userId, name)
        {
            Address = address;
            Contact = contact;
            Personal = personal;
        }

        public virtual void Update(Guid userId, string name, string description, Address? address, Contact? contact, Personal? personal)
        {
            Address = address;
            Contact = contact;
            Personal = personal;    
            base.Update(userId, name, description);
        }
    }
}
