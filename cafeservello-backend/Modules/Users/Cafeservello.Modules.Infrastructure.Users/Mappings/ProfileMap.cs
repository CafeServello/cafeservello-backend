using Cafeservello.Common.Infrastructure.Mappings;
using Cafeservello.Modules.Domain.Users.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafeservello.Modules.Infrastructure.Users.Mappings
{
    public sealed class ProfileMap : BaseNamedMap<Profile>
    {
        public override void Configure(EntityTypeBuilder<Profile> builder)
        {
            base.Configure(builder);

            //builder.ComplexProperty(x => x.Permissions, permissions =>
            //{
            //});

            builder
                .Property(x => x.ProfileType)
                .HasColumnName("PROFILE_TYPE")
                .IsRequired();
        }
    }
}
