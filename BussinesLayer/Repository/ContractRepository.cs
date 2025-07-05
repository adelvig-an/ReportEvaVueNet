using BussinesLayer.DTOs.Contract;
using BussinesLayer.Interfaces;
using DbLayer;
using Microsoft.EntityFrameworkCore;
using Model;

namespace BussinesLayer.Repository
{
    public class ContractRepository : IContractRepository
    {
        private readonly ApplicationDbContext _context;
        public ContractRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ContractsModel> CreateAsync(ContractsModel contactModel)
        {
            await _context.Contracts.AddAsync(contactModel);
            await _context.SaveChangesAsync();
            return contactModel;
        }

        public async Task<ContractsModel?> DeleteAsync(int id)
        {
            var contractModel = _context.Contracts.FirstOrDefault(x => x.Id == id);
            if (contractModel == null)
            {
                return null;
            }

            _context.Contracts.Remove(contractModel);
            await _context.SaveChangesAsync();
            return contractModel;
        }

        public async Task<List<ContractsModel>> GetAllAsync()
        {
            return await _context.Contracts.ToListAsync();
        }

        public async Task<ContractsModel?> GetByIdAsync(int id)
        {
            return await _context.Contracts.FindAsync(id);
        }

        public async Task<ContractsModel?> UpdateAsync(int id, UpdateContractRequestDto contractDto)
        {
            var contractModel = _context.Contracts.FirstOrDefault(x => x.Id == id);

            if (contractModel == null)
            {
                return null;
            }

            contractModel.ContractType = contractDto.ContractType;
            contractModel.ContractName = contractDto.ContractName;
            contractModel.ContractNumber = contractDto.ContractNumber;
            contractModel.DateContract = contractDto.DateContract;

            await _context.SaveChangesAsync();
            return contractModel;
        }
    }
}
