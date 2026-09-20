using Cafeservello.Common.Domain.ObjectValues.DTOs;

namespace Cafeservello.Common.Domain.DTOs
{
    public abstract class BasePersonDTO : BaseNamedDTO
    {
        public AddressDTO? AddressDTO { get; set; }
        public ContactDTO? ContactDTO { get; set; }
        public PersonalDTO? PersonalDTO { get; set; }
    }
}
