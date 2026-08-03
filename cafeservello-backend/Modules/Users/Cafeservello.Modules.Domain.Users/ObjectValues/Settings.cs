using Cafeservello.Modules.Domain.Users.Enums;

namespace Cafeservello.Modules.Domain.Users.ObjectValues
{
    public sealed class Settings
    {
        public Themes Themes { get; private set; }
        public Settings() { }
        public Settings(Themes themes)
        {
            Themes = themes;
        }
    }
}
