using Cafeservello.Common.Application.Services;
using Cafeservello.Common.Domain.ObjectValues.DTOs;
using Cafeservello.Common.Domain.ObjectValues.Entities;
using Cafeservello.Modules.Application.Users.Interfaces;
using Cafeservello.Modules.Domain.Users.Common.ObjectValues;
using Cafeservello.Modules.Domain.Users.Common.ObjectValues.DTOs;
using Cafeservello.Modules.Domain.Users.Common.ObjectValues.Entities;
using Cafeservello.Modules.Domain.Users.DTOs;
using Cafeservello.Modules.Domain.Users.Entities;
using Cafeservello.Modules.Domain.Users.Interfaces.Repository;

namespace Cafeservello.Modules.Application.Users.Services
{
    public class UserApp : App<User, UserDTO, IUserRepository>, IUserApp
    {
        public UserApp(IUserRepository userRepository) : base(userRepository)
        {
        }

        protected override UserDTO MapRead(User entity)
        {
            return new UserDTO
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,

                AddressDTO = entity.Address != null
                    ? new AddressDTO
                    {
                        City = entity.Address.City,
                        Street = entity.Address.Street,
                        State = entity.Address.State,
                        Number = entity.Address.Number,
                        Country = entity.Address.Country,
                        ZipCode = entity.Address.ZipCode,
                        Neighborhood = entity.Address.Neighborhood,
                        Complement = entity.Address.Complement
                    }
                    : null,

                ContactDTO = entity.Contact != null
                    ? new ContactDTO
                    {
                        PrimaryEmail = entity.Contact.PrimaryEmail,
                        CellPhone = entity.Contact.CellPhone,
                        SecondaryEmail = entity.Contact.SecondaryEmail,
                        Landline = entity.Contact.Landline
                    }
                    : null,

                PersonalDTO = entity.Personal != null
                    ? new PersonalDTO
                    {
                        DateOfBirth = entity.Personal.DateOfBirth,
                        Cpf = entity.Personal.Cpf,
                        Gender = entity.Personal.Gender,
                        LastName = entity.Personal.LastName
                    }
                    : null,

                PrivacyDTO = entity.Privacy != null
                    ? new PrivacyDTO
                    {
                        UserName = entity.Privacy.UserName,
                        Password = entity.Privacy.Password
                    }
                    : null!,

                ProfileDTO = entity.Profile != null
                    ? new ProfileDTO
                    {
                        Id = entity.Profile.Id,
                        Name = entity.Profile.Name,
                        ProfileType = entity.Profile.ProfileType
                    }
                    : null
            };
        }
        protected override User MapCreate(UserDTO dto)
        {
            return new User(
                dto.Id,
                dto.Name,
                dto.Description,

                dto.AddressDTO != null ? new Address(
                    dto.AddressDTO.City,
                    dto.AddressDTO.Street,
                    dto.AddressDTO.State,
                    dto.AddressDTO.Number,
                    dto.AddressDTO.Country,
                    dto.AddressDTO.ZipCode,
                    dto.AddressDTO.Neighborhood,
                    dto.AddressDTO.Complement
                ) : null!,

                dto.ContactDTO != null ? new Contact(
                    dto.ContactDTO.PrimaryEmail,
                    dto.ContactDTO.CellPhone,
                    dto.ContactDTO.SecondaryEmail ?? string.Empty,
                    dto.ContactDTO.Landline ?? string.Empty
                ) : null!,

                dto.PersonalDTO != null ? new Personal(
                    dto.PersonalDTO.DateOfBirth,
                    dto.PersonalDTO.Cpf ?? string.Empty,
                    dto.PersonalDTO.Gender,
                    dto.PersonalDTO.LastName
                ) : null!,

                dto.PrivacyDTO != null ? new Privacy(
                    dto.PrivacyDTO.UserName,
                    dto.PrivacyDTO.Password
                ) : null!,

                dto.ProfileDTO != null ? new Profile(
                    dto.ProfileDTO.Id,
                    dto.ProfileDTO.Name,
                    dto.ProfileDTO.Description ?? string.Empty,
                    dto.ProfileDTO.ProfileType

                ) : null!,

                dto.SettingsDTO != null ? new Settings(
                    dto.SettingsDTO.Themes
                ) : null!
            );
        }
       

        protected override User MapUpdate(UserDTO dto, User id)
        {
            id.Update(
                dto.Id,
                dto.Name,
                dto.Description,

                dto.PrivacyDTO != null ? new Privacy(
                    dto.PrivacyDTO.UserName,
                    dto.PrivacyDTO.Password
                ) : null!,

                dto.SettingsDTO != null ? new Settings(
                    dto.SettingsDTO.Themes
                ) : null!,

                dto.AddressDTO != null ? new Address(
                    dto.AddressDTO.City,
                    dto.AddressDTO.Street,
                    dto.AddressDTO.State,
                    dto.AddressDTO.Number,
                    dto.AddressDTO.Country,
                    dto.AddressDTO.ZipCode,
                    dto.AddressDTO.Neighborhood,
                    dto.AddressDTO.Complement
                ) : null!,

                dto.ContactDTO != null ? new Contact(
                    dto.ContactDTO.PrimaryEmail ?? string.Empty,
                    dto.ContactDTO.CellPhone ?? string.Empty,
                    dto.ContactDTO.SecondaryEmail,
                    dto.ContactDTO.Landline
                ) : null!,

                dto.PersonalDTO != null ? new Personal(
                    dto.PersonalDTO.DateOfBirth,
                    dto.PersonalDTO.Cpf ?? string.Empty,
                    dto.PersonalDTO.Gender
                ) : null!
            );

            return id;
        }
    }
}
