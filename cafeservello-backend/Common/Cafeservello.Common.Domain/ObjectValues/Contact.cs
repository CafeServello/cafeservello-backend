namespace Cafeservello.Common.Domain.ObjectValues
{
    public sealed class Contact
    {
        public string PrimaryEmail { get; set; } = string.Empty;
        public string? SecondaryEmail { get; set; } = string.Empty;
        public string CellPhone { get; set; } = string.Empty;
        public string? Landline { get; set; } = string.Empty;
        public Contact() { }
        public Contact(
            string email, 
            string cellPhone, 
            string? secondaryEmail = null, 
            string? landline = null)
        {
            PrimaryEmail = email;
            CellPhone = cellPhone;
            SecondaryEmail = secondaryEmail;
            Landline = landline;

        }

    }
}
