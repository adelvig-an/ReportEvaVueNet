using BussinesLayer.DTOs.Contact;
using Model;

namespace BussinesLayer.Mappers
{
    public static class ContactMapper
    {
        public static ContactDto ToContactDto(this ContactsModel contactModel)
        {
            return new ContactDto
            {
                Id = contactModel.Id,
                Name = contactModel.Name,
                Ptronymic = contactModel.Ptronymic,
                Surname = contactModel.Surname,
                Email = contactModel.Email,
                Phone = contactModel.Phone,
                CreatedAt = contactModel.CreatedAt,
            };
        }

        public static ContactsModel ToReportFromCreateDto(this CreateContactRequestDto reportDto)
        {
            return new ContactsModel
            {
                Name = reportDto.Name,
                Ptronymic = reportDto.Ptronymic,
                Surname = reportDto.Surname,
                Email = reportDto.Email,
                Phone = reportDto.Phone,
                CreatedAt = reportDto.CreatedAt,
            };
        }
    }
}
