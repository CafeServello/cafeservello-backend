namespace Cafeservello.Common.Domain.ObjectValues.Entities
{
    public sealed class Contact
    {
        public string PrimaryEmail { get; set; } = string.Empty;
        public string? SecondaryEmail { get; set; } = string.Empty;
        public string CellPhone { get; set; } = string.Empty;
        public string? Landline { get; set; } = string.Empty;
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

        public void Update(
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
