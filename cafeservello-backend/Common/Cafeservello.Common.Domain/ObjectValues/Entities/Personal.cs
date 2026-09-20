namespace Cafeservello.Common.Domain.ObjectValues.Entities
{
    public sealed class Personal
    {
        public string? LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Cpf { get; set; } = string.Empty;
        public bool Gender { get; set; }
        private Personal() { }
        public Personal(
            DateTime dateOfBirth, 
            string cpf, 
            bool sex, string? 
            lastName = null)
        {
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Cpf = cpf;
            Gender = sex;
        }
        public void Update(
            DateTime dateOfBirth, 
            bool gender, 
            string? lastName)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
            LastName = lastName;
        }
    }
}
