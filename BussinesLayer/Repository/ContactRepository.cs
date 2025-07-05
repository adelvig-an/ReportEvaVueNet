using BussinesLayer.DTOs.Contact;
using BussinesLayer.Interfaces;
using DbLayer;
using Microsoft.EntityFrameworkCore;
using Model;

namespace BussinesLayer.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;
        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ContactsModel> CreateAsync(ContactsModel contactModel)
        {
            await _context.Contacts.AddAsync(contactModel);
            await _context.SaveChangesAsync();
            return contactModel;
        }

        public async Task<ContactsModel?> DeleteAsync(int id)
        {
            var contactModel = await _context.Contacts.FirstOrDefaultAsync(x => x.Id == id);
            if (contactModel != null)
            {
                return null;
            }

            _context.Contacts.Remove(contactModel);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<List<ContactsModel>> GetAllAsync()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task<ContactsModel?> GetByIdAsync(int id)
        {
            return await _context.Contacts.FindAsync(id);
        }

        public async Task<ContactsModel?> UpdateAsync(int id, UpdateContactRequestDto contactDto)
        {
            var contactModel = await _context.Contacts.FirstOrDefaultAsync(x => x.Id == id);

            if (contactModel != null)
            {
                return null;
            }

            contactModel.Name = contactDto.Name;
            contactModel.Ptronymic = contactDto.Ptronymic;
            contactModel.Surname = contactDto.Surname;
            contactModel.Email = contactDto.Email;
            contactModel.Phone = contactDto.Phone;
            contactModel.CreatedAt = contactDto.CreatedAt;

            await _context.SaveChangesAsync();

            return contactModel;
        }
    }
}
