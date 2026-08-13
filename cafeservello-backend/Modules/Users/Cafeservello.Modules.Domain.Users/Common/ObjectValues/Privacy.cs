namespace Cafeservello.Modules.Domain.Users.Common.ObjectValues
{
    public sealed class Privacy
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Privacy() { }
        public Privacy(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

    }
}
