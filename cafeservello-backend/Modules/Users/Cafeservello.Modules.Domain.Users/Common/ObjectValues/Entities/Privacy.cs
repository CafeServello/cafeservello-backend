namespace Cafeservello.Modules.Domain.Users.Common.ObjectValues.Entities
{
    public sealed class Privacy
    {
        public string UserName { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;
        private Privacy(){}
        public Privacy(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public void Update(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
