namespace Cafeservello.Modules.Domain.Users.ObjectValues
{
    public sealed class Privacy
    {
        public string UserName { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;
        public Privacy() { }
        public Privacy(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

    }
}
