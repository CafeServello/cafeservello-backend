namespace Cafeservello.Common.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid CreatedBy { get; private set; }
        public Guid UpdatedBy { get; private set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
        public bool IsActive { get; private set; } = true;
        public BaseEntity(Guid userId)
        {
            CreatedBy = userId;
            UpdatedBy = userId;
        }

        protected BaseEntity(){}

        public virtual void Update(Guid userId)
        {
            UpdatedBy = userId;
            UpdatedAt = DateTime.UtcNow;
        }

        public virtual void Deactivate(Guid userId)
        {
            IsActive = false;
            Update(userId);
        }
        public virtual void Activate(Guid userId)
        {
            IsActive = true;
            Update(userId);
        }

    }
}
