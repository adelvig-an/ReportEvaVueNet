using BussinesLayer.DTOs.Contract;
using Model;

namespace BussinesLayer.Interfaces
{
    public interface IContractRepository
    {
        Task<List<ContractsModel>> GetAllAsync();
        Task<ContractsModel?> GetByIdAsync(int id); //FirstOrDefault CAN BE NULL
        Task<ContractsModel> CreateAsync(ContractsModel contactModel);
        Task<ContractsModel?> UpdateAsync(int id, UpdateContractRequestDto updateDto);
        Task<ContractsModel?> DeleteAsync(int id);
    }
}
