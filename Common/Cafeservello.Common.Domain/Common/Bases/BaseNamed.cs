namespace Cafeservello.Common.Domain.Common.Bases
{
    public abstract class BaseNamed : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        protected BaseNamed() { }
        public BaseNamed(Guid userId, string name) : base(userId)
        {
            Name = name;
        }
        public virtual void Update(Guid userId, string name, string description)
        { 
            Name = name;
            Description = description;
            base.Update(userId);
        }
    }
}
