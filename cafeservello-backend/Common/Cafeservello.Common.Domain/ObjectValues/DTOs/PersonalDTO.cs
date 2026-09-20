namespace Cafeservello.Common.Domain.ObjectValues.DTOs
{
    public sealed class PersonalDTO
    {
        public string? LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Cpf { get; set; } = string.Empty;
        public bool Gender { get; set; }
    }
}
