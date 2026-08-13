using Cafeservello.Common.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafeservello.Common.Infrastructure.Mappings
{
    public abstract class BaseEntityMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder
                .Property(x => x.CreatedBy)
                .HasColumnName("CREATED_BY")
                .IsRequired();

            builder
                .Property(x => x.UpdatedBy)
                .HasColumnName("UPDATED_BY")
                .IsRequired();

            builder 
                .Property(x => x.CreatedAt)
                .HasColumnName("CREATED_AT")
                .IsRequired();

            builder
                .Property(x => x.UpdatedAt)
                .HasColumnName("UPDATED_AT")
                .IsRequired();

            builder
                .Property(x => x.IsActive)
                .HasColumnName("IS_ACTIVE")
                .IsRequired();
        }
    }
}