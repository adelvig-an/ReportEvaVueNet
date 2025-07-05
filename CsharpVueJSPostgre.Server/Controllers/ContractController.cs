using BussinesLayer.DTOs.Contract;
using BussinesLayer.Interfaces;
using BussinesLayer.Mappers;
using DbLayer;
using Microsoft.AspNetCore.Mvc;

namespace CsharpVueJSPostgre.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IContractRepository _contractRepo;

        public ContractController(ApplicationDbContext dbContext, IContractRepository contractRepository)
        {
            _dbContext = dbContext;
            _contractRepo = contractRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var contracts = await _contractRepo.GetAllAsync();

            var contractDtos = contracts.Select(c => c.ToContractDto());

            return Ok(contracts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var contract = await _contractRepo.GetByIdAsync(id);
            if (contract == null)
            {
                return NotFound();
            }
            return Ok(contract.ToContractDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateContractRequestDto contractDto)
        {
            var contractModel = contractDto.ToContractFromCreateDto();
            
            await _contractRepo.CreateAsync(contractModel);
            
            return CreatedAtAction(nameof(GetById), new { id = contractModel.Id }, contractModel.ToContractDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateContractRequestDto updateDto)
        {
            var contractModel = await _contractRepo.UpdateAsync(id, updateDto);
            if (contractModel == null)
            {
                return NotFound();
            }
            return Ok(contractModel.ToContractDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var contractModel = await _contractRepo.DeleteAsync(id);
            if (contractModel == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
