namespace Cafeservello.Common.Domain.Entities
{
    public abstract class BaseNamed : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string? Description { get; private set; } = string.Empty;
        protected BaseNamed() { }
        public BaseNamed(Guid userId, string name, string? description) : base(userId)
        {
            Name = name;
            Description = description;
        }
        public virtual void Update(Guid userId, string name, string? description)
        { 
            Name = name;
            Description = description;
            base.Update(userId);
        }
    }
}
