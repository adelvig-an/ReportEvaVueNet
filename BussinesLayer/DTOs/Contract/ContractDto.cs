namespace BussinesLayer.DTOs.Contract
{
    public class ContractDto
    {
        public int Id { get; set; }
        public string ContractType { get; set; } = string.Empty;
        public string ContractName { get; set; } = string.Empty;
        public string ContractNumber { get; set; } = string.Empty;
        public DateTime DateContract { get; set; }
    }
}
