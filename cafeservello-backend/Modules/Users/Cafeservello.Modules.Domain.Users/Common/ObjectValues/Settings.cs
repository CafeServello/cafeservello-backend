using Cafeservello.Modules.Domain.Users.Common.Enums;

namespace Cafeservello.Modules.Domain.Users.Common.ObjectValues
{
    public sealed class Settings
    {
        public Themes Themes { get; set; }
        public Settings() { }
        public Settings(Themes themes)
        {
            Themes = themes;
        }
    }
}
