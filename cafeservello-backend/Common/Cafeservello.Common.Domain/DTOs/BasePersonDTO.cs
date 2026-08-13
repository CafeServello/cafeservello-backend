using Cafeservello.Common.Domain.ObjectValues;

namespace Cafeservello.Common.Domain.DTOs
{
    public abstract class BasePersonDTO : BaseNamedDTO
    {
        public Address? AddressDTO { get; set; }
        public Contact? ContactDTO { get; set; }
        public Personal? PersonalDTO { get; set; }
    }
}
