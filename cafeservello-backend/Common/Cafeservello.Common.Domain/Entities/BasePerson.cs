using Cafeservello.Common.Domain.ObjectValues.Entities;

namespace Cafeservello.Common.Domain.Entities
{
    public abstract class BasePerson : BaseNamed
    {
        public Address Address { get; private set; }
        public Contact Contact { get; private set; }
        public Personal Personal { get; private set; }
        protected BasePerson(){}
        public BasePerson(
            Guid userId, 
            string name, 
            string? description,
            Address address, 
            Contact contact, 
            Personal personal
        ) : base(userId, name, description)
        {
            Address = address;
            Contact = contact;
            Personal = personal;
        }

        

        public void UpdateAddress(Guid userId, Address address)
        {
            Address?.Update(
                address.City,
                address.Street,
                address.State,
                address.Number,
                address.Country,
                address.ZipCode,
                address.Neighborhood,
                address.Complement
            );
            base.Update(userId);
        }
        public void UpdateContact(Guid userId, Contact contact) 
        {
            Contact.Update(
                contact.PrimaryEmail,
                contact.CellPhone,
                contact.SecondaryEmail,
                contact.Landline
            );
            base.Update(userId);
        }
        public void UpdatePersonal(Guid userId, Personal personal) 
        {
            Personal.Update(
                personal.DateOfBirth, 
                personal.Gender, 
                personal.LastName
            );
            base.Update(userId);
        }
        
        public void Update(Guid userId, string name, string? description, Address address, Contact contact, Personal personal)
        {
            if (address is not null){
                Address.Update(
                address.City,
                address.Street,
                address.State,
                address.Number,
                address.Country,
                address.ZipCode,
                address.Neighborhood,
                address.Complement
                );
            }

            if (contact is not null)
            {
                Contact.Update(
                contact.PrimaryEmail,
                contact.CellPhone,
                contact.SecondaryEmail,
                contact.Landline
                );
            }
               

            if (personal is not null)
                Personal.Update(
                personal.DateOfBirth,
                personal.Gender,
                personal.LastName
            );

            base.Update(userId, name, description);
        }
    }
}
