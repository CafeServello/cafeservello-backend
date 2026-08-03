namespace Cafeservello.Common.Domain.Common.ObjectValues
{
    public sealed class Personal
    {
        public string? LastName { get; private set; } = string.Empty;
        public DateTime DateOfBirth { get; private set; }
        public string CPF { get; private set; } = string.Empty;
        public bool Sex { get; private set; }
        private Personal() { }
        public Personal(DateTime dateOfBirth, string cpf, bool sex, string? lastName = null)
        {
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            CPF = cpf;
            Sex = sex;
        }
    }
}
