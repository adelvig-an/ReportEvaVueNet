using BussinesLayer.DTOs.Contact;
using BussinesLayer.Interfaces;
using BussinesLayer.Mappers;
using BussinesLayer.Repository;
using DbLayer;
using Microsoft.AspNetCore.Mvc;

namespace CsharpVueJSPostgre.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IContactRepository _contactRepo;
        public ContactController(ApplicationDbContext dbContext, IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contacts = await _contactRepo.GetAllAsync();

            var contactDto = contacts.Select(s => s.ToContactDto());

            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var contact = await _contactRepo.GetByIdAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact.ToContactDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateContactRequestDto contactDto)
        {
            var contactModel = contactDto.ToReportFromCreateDto();

            await _contactRepo.CreateAsync(contactModel);

            return CreatedAtAction(nameof(GetById), new { id = contactModel.Id }, contactModel.ToContactDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateContactRequestDto updateDto)
        {
            var contactModel = await _contactRepo.UpdateAsync(id, updateDto);

            if (contactModel == null)
            { return NotFound(); }

            return Ok(contactModel.ToContactDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var contactModel = await _contactRepo.DeleteAsync(id);

            if (contactModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
