using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class InsurancePolicyModel : CounterpartyModel
    {
        public string PolicyNumber { get; set; } = string.Empty; //Номер полиса
        public DateTime IssueDate { get; set; } //Дата выдачи
        public DateTime ExpirationDate { get; set; } //Дата истечения срока действия
        [Column(TypeName = "decimal(18,2)")]
        public decimal InsuranceMoney { get; set; } //Страховое возмещение (Застрахованная сумма)
        public string PathImage { get; set; } = string.Empty; //Путь к изображениям стахового полиса в JSON
    }
}
