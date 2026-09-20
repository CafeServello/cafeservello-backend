using Cafeservello.Common.Infrastructure.Mappings;
using Cafeservello.Modules.Domain.Users.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafeservello.Modules.Infrastructure.Users.Mappings
{
    public sealed class UserMap : BasePersonMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.ComplexProperty(x => x.Privacy, privacy =>
            {
                privacy
                    .Property(x => x.UserName)
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(200)
                    .IsRequired();

                privacy
                    .Property(x => x.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(200)
                    .IsRequired();
            });

            builder.ComplexProperty(x => x.Settings, settings =>
            {
                settings
                    .Property(x => x.Themes)
                    .HasColumnName("THEME")
                    .IsRequired();
            });

            builder.Property(x => x.ProfileId)
                .HasColumnName("ID_PROFILE")
                .IsRequired();

            builder.HasOne(x => x.Profile)
                .WithMany()
                .HasForeignKey(x => x.ProfileId)
                .HasConstraintName("FK_USER_PROFILE")
                .IsRequired();
        }
    }
}
