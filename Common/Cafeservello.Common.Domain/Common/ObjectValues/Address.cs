namespace Cafeservello.Common.Domain.Common.ObjectValues
{
    public class Address
    {
        public string City { get; private set; } = string.Empty;
        public string Street { get; private set; } = string.Empty;
        public string State { get; private set; } = string.Empty;
        public string Number { get; private set; } = string.Empty;
        public string Country { get; private set; } = string.Empty;
        public string ZipCode { get; private set; } = string.Empty;
        public string? Neighborhood { get; private set; } = string.Empty;
        public string? Complement { get; private set; } = string.Empty;
        protected Address() { }
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
    }
}
