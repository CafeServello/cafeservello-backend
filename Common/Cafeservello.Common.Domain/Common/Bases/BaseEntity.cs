namespace Cafeservello.Common.Domain.Common.Bases
{
    public abstract class BaseEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid CreatedBy { get; private set; }
        public Guid UpdatedBy { get; private set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
        public bool IsDeleted { get; private set; } = false;

        protected BaseEntity() { }

        public BaseEntity(Guid userId)
        {
            CreatedBy = userId;
            UpdatedBy = userId;
        }

        public virtual void Update(Guid userId)
        {
            UpdatedBy = userId;
            UpdatedAt = DateTime.UtcNow;
        }

        public virtual void Delete(Guid userId)
        {
            IsDeleted = true;
            Update(userId);
        }

    }
}
