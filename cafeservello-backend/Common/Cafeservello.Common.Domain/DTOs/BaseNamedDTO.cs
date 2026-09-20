namespace Cafeservello.Common.Domain.DTOs
{
    public abstract class BaseNamedDTO : BaseEntityDTO
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
    }
}
