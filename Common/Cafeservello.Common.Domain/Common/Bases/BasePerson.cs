using Cafeservello.Common.Domain.Common.ObjectValues;

namespace Cafeservello.Common.Domain.Common.Bases
{
    public abstract class BasePerson : BaseNamed
    {
        public Address? Address { get; private set; }
        public Contact? Contact { get; private set; }
        protected BasePerson() { }

        public BasePerson(Guid userId, string name, Address? address, Contact? contact) : base(userId, name)
        {
            Address = address;
            Contact = contact;
        }

        public virtual void Update(Guid userId, string name, string description, Address? address, Contact? contact)
        {
            Address = address;
            Contact = contact;
            base.Update(userId, name, description);
        }
    }
}
