namespace Cafeservello.Modules.Domain.Users.Common.ObjectValues.Entities
{
    public sealed class Permissions
    {
        public bool CanCreate { get; private set; }
        public bool CanRead { get; private set; }
        public bool CanUpdate { get; private set; }
        public bool CanDelete { get; private set; }

        private Permissions() { }
        // Add properties for permissions as needed
    }
}
