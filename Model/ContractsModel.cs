﻿namespace Model
{
    /// <summary>
    /// Данные договора
    /// </summary>
    public class ContractsModel
    {
        public int Id { get; set; }
        public string ContractType { get; set; } = string.Empty;
        public string ContractName { get; set; }= string.Empty;
        public string ContractNumber { get; set; } = string.Empty;
        public DateTime DateContract { get; set; }
    }
}
