namespace Cafeservello.Common.Domain.Common.ObjectValues
{
    public sealed class Contact
    {
        public string PrimaryEmail { get; private set; } = string.Empty;
        public string? SecondaryEmail { get; private set; } = string.Empty;
        public string CellPhone { get; private set; } = string.Empty;
        public string? Landline { get; private set; } = string.Empty;
        private Contact() { }
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
