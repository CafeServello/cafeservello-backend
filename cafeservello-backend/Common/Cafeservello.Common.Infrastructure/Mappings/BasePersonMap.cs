using Cafeservello.Common.Domain.Entities;
using Microsoft.EntityFrameworkCore;
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
                       .HasColumnName("LAST_NAME")
                       .HasMaxLength(200)
                       .IsRequired();

                   personal
                       .Property(x => x.DateOfBirth)
                       .HasColumnName("DATE_OF_BIRTH")
                       .IsRequired();

                   personal
                       .Property(x => x.Cpf)
                       .HasColumnName("CPF")
                       .HasMaxLength(20)
                       .IsRequired();

                   personal
                       .Property(x => x.Gender)
                       .HasColumnName("GENDER")
                       .IsRequired();
               });

            builder
                .ComplexProperty(x => x.Address, address =>
                {
                    address
                        .Property(x => x.City)
                        .HasColumnName("CITY")
                        .HasMaxLength(100)
                        .IsRequired();

                    address
                        .Property(x => x.Street)
                        .HasColumnName("STREET")
                        .HasMaxLength(150)
                        .IsRequired();

                    address
                        .Property(x => x.State)
                        .HasColumnName("STATE")
                        .HasMaxLength(2)
                        .IsRequired();

                    address
                        .Property(x => x.Number)
                        .HasColumnName("NUMBER")
                        .HasMaxLength(20)
                        .IsRequired();

                    address
                        .Property(x => x.Country)
                        .HasColumnName("COUNTRY")
                        .HasMaxLength(50)
                        .IsRequired();

                    address
                        .Property(x => x.ZipCode)
                        .HasColumnName("ZIPCODE")
                        .HasMaxLength(10)
                        .IsRequired();

                    address
                        .Property(x => x.Neighborhood)
                        .HasColumnName("NEIGHBORHOOD")
                        .HasMaxLength(100);

                    address
                        .Property(x => x.Complement)
                        .HasColumnName("COMPLEMENT")
                        .HasMaxLength(100);
                });

            builder
                .ComplexProperty(x => x.Contact, contact =>
                {
                    contact
                        .Property(x => x.PrimaryEmail)
                        .HasColumnName("PRIMARY_EMAIL")
                        .HasMaxLength(255)
                        .IsRequired();

                    contact
                        .Property(x => x.SecondaryEmail)
                        .HasColumnName("SECONDADARY_EMAIL")
                        .HasMaxLength(255);

                    contact
                        .Property(x => x.CellPhone)
                        .HasColumnName("CELL_PHONE")
                        .HasMaxLength(20)
                        .IsRequired();

                    contact
                        .Property(x => x.Landline)
                        .HasColumnName("LANDLINE")
                        .HasMaxLength(20)
                        .IsRequired();

                });

           

        }
    }
}

