using Cafeservello.Common.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cafeservello.Common.Infrastructure.Mappings
{
    public abstract class BasePersonMap<T> : BaseNamedMap<T> where T : BasePerson
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder
               .ComplexProperty(x => x.Personal, personal =>
               {
                   personal
                       .Property(x => x.LastName)
                       .HasMaxLength(200)
                       .IsRequired();

                   personal
                       .Property(x => x.DateOfBirth)
                       .IsRequired();

                   personal
                       .Property(x => x.Cpf)
                       .HasMaxLength(20)
                       .IsRequired();

                   personal
                       .Property(x => x.Gender)
                       .IsRequired();
               });

            builder
                .ComplexProperty(x => x.Address, address =>
                {
                    address
                        .Property(x => x.City)
                        .HasMaxLength(100)
                        .IsRequired();

                    address
                        .Property(x => x.Street)
                        .HasMaxLength(150)
                        .IsRequired();

                    address
                        .Property(x => x.State)
                        .HasMaxLength(2)
                        .IsRequired();

                    address
                        .Property(x => x.Number)
                        .HasMaxLength(20)
                        .IsRequired();

                    address
                        .Property(x => x.Country)
                        .HasMaxLength(50)
                        .IsRequired();

                    address
                        .Property(x => x.ZipCode)
                        .HasMaxLength(10)
                        .IsRequired();

                    address
                        .Property(x => x.Neighborhood)
                        .HasMaxLength(100);

                    address
                        .Property(x => x.Complement)
                        .HasMaxLength(100);
                });

            builder
                .ComplexProperty(x => x.Contact, contact =>
                {
                    contact
                        .Property(x => x.PrimaryEmail)
                        .HasMaxLength(255)
                        .IsRequired();

                    contact
                        .Property(x => x.SecondaryEmail)
                        .HasMaxLength(255);

                    contact
                        .Property(x => x.CellPhone)
                        .HasMaxLength(20)
                        .IsRequired();

                    contact
                        .Property(x => x.Landline)
                        .HasMaxLength(20)
                        .IsRequired();

                });

           

        }
    }
}
