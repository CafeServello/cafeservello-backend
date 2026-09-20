
namespace Cafeservello.Common.Domain.ObjectValues.Entities
{
    public sealed class Address
    {
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string? Neighborhood { get; set; } = string.Empty;
        public string? Complement { get; set; } = string.Empty;
        private Address() { }
        public Address(
            string city, 
            string street, 
            string state, 
            string number, 
            string country, 
            string zipCode, 
            string? neighborhood = null, 
            string? complement = null)
        {
            City = city;
            Street = street;
            State = state;
            Number = number;
            Country = country;
            ZipCode = zipCode;
            Neighborhood = neighborhood;
            Complement = complement;
        }

        public void Update(
            string city,
            string street,
            string state,
            string number,
            string country,
            string zipCode,
            string? neighborhood = null,
            string? complement = null) 
        {
            City = city;
            Street = street;
            State = state;
            Number = number;
            Country = country;
            ZipCode = zipCode;
            Neighborhood = neighborhood;
            Complement = complement;
        }
    }
}
