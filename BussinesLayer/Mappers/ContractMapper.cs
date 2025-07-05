using BussinesLayer.DTOs.Contract;
using Model;

namespace BussinesLayer.Mappers
{
    public static class ContractMapper
    {
        public static ContractDto ToContractDto(this ContractsModel contractModel)
        {
            return new ContractDto
            {
                Id = contractModel.Id,
                ContractType = contractModel.ContractType,
                ContractName = contractModel.ContractName,
                ContractNumber = contractModel.ContractNumber,
                DateContract = DateTime.SpecifyKind(contractModel.DateContract, DateTimeKind.Utc),
            };
        }

        public static ContractsModel ToContractFromCreateDto(this CreateContractRequestDto contractModel)
        {
            return new ContractsModel
            {
                ContractType = contractModel.ContractType,
                ContractName = contractModel.ContractName,
                ContractNumber = contractModel.ContractNumber,
                DateContract = DateTime.SpecifyKind(contractModel.DateContract, DateTimeKind.Utc),
            };
        }
    }
}
