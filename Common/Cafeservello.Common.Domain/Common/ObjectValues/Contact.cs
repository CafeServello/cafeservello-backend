namespace Cafeservello.Common.Domain.Common.ObjectValues
{
    public class Contact
    {
        public string Email { get; private set; } = string.Empty;
        public string? SecondaryEmail { get; private set; } = string.Empty;
        public string CellPhone { get; private set; } = string.Empty;
        public string? Landline { get; private set; } = string.Empty;

        public Contact(
            string email, 
            string cellPhone, 
            string? secondaryEmail = null, 
            string? landline = null)
        {
            Email = email;
            CellPhone = cellPhone;
            SecondaryEmail = secondaryEmail;
            Landline = landline;

        }
    }
}
