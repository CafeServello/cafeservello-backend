using Cafeservello.Common.Domain.DTOs;
using Cafeservello.Modules.Domain.Users.Common.Enums;
using Cafeservello.Modules.Domain.Users.Common.ObjectValues;

namespace Cafeservello.Modules.Domain.Users.DTOs
{
    public sealed class ProfileDTO : BaseNamedDTO
    {
        public Permissions? Permissions { get; set; }
        public ProfileType ProfileType { get; set; }
    }
}
