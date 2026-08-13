namespace Cafeservello.Common.Domain.ObjectValues
{
    public sealed class Personal
    {
        public string? LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Cpf { get; set; } = string.Empty;
        public bool Gender { get; set; }
        public Personal() { }
        public Personal(DateTime dateOfBirth, string cpf, bool sex, string? lastName = null)
        {
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Cpf = cpf;
            Gender = sex;
        }
    }
}
