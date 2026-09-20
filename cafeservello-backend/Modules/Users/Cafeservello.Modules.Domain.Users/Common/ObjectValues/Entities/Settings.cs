using Cafeservello.Modules.Domain.Users.Common.Enums;

namespace Cafeservello.Modules.Domain.Users.Common.ObjectValues.Entities
{
    public sealed class Settings
    {
        public Themes Themes { get; private set; }
        private Settings() { }
        public Settings(Themes themes)
        {
            Themes = themes;
        }
        public void Update(Themes themes)
        {
            Themes = themes;
        }
    }
}
