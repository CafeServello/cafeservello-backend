namespace Cafeservello.Common.Domain.ObjectValues.DTOs
{
    public sealed class ContactDTO
    {
        public string PrimaryEmail { get; set; } = string.Empty;
        public string? SecondaryEmail { get; set; } = string.Empty;
        public string CellPhone { get; set; } = string.Empty;
        public string? Landline { get; set; } = string.Empty;

    }
}
