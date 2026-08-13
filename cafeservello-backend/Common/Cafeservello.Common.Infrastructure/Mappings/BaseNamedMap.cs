using Cafeservello.Common.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafeservello.Common.Infrastructure.Mappings
{
    public abstract class BaseNamedMap<T> : BaseEntityMap<T> where T : BaseNamed
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder
                .Property(x => x.Name)
                .HasColumnName("NAME")
                .HasMaxLength(200)
                .IsRequired();

            builder 
                .Property(x => x.Description)
                .HasColumnName("DESCRIPTION")
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}
