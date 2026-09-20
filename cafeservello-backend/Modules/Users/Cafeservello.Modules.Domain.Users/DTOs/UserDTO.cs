using Cafeservello.Common.Domain.DTOs;
using Cafeservello.Modules.Domain.Users.Common.ObjectValues.DTOs;

namespace Cafeservello.Modules.Domain.Users.DTOs
{
    public sealed class UserDTO : BasePersonDTO
    {
        public PrivacyDTO PrivacyDTO { get;  set; } = new PrivacyDTO();
        public Guid ProfileId { get; set; } 
        public ProfileDTO? ProfileDTO { get; set; } = new ProfileDTO();
        public SettingsDTO SettingsDTO { get; set; } = new SettingsDTO();
    }
}
