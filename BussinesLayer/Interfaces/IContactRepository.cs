using BussinesLayer.DTOs.Contact;
using Model;

namespace BussinesLayer.Interfaces
{
    public interface IContactRepository
    {
        Task<List<ContactsModel>> GetAllAsync();
        Task<ContactsModel?> GetByIdAsync(int id); //FirstOrDefault CAN BE NULL
        Task<ContactsModel> CreateAsync(ContactsModel contactModel);
        Task<ContactsModel?> UpdateAsync(int id, UpdateContactRequestDto updateDto);
        Task<ContactsModel?> DeleteAsync(int id);
    }
}
