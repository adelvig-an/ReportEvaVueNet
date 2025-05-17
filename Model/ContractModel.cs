using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class ContractModel
    {
        public int Id { get; set; }
        public ContractType ContractType { get; set; }
        public string Number { get; set; } = string.Empty; //Номер договора
        public DateTime CreateOn { get; set; } //Дата договора
        public int DueDate { get; set; } //Срок выполнения
        public int? CustomerId { get; set; }
        public CustomerModel? Customer { get; set; }
        public int? ExpertOrganizationId { get; set; }
        public ExpertOrganizationModel? ExpertOrganization { get; set; }
        public int? ExpertId { get; set; }
        public ExpertModel? Expert { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } //Стоимость услуг
        public StatusType StatusContract { get; set; }
        public PaymentStatusType PaymentStatusContract { get; set; }
    }

    public enum ContractType
    {
        [Description("Договор")]
        Agreement = 0,
        [Description("Муниципальный контракт")]
        MunicipalContract = 1,
        [Description("Государственный контракт")]
        GovernmentContract = 2,
        [Description("Определение суда")]
        CourtRuling = 3
    }

    public enum StatusType
    {
        [Description("Не обработан")]
        NotProcessed = 0,
        [Description("Выбран исполнитель")]
        PerformerSelected = 1,
        [Description("Работа с документами")]
        WorkingDocuments = 2,
        [Description("Назначен осмотр")]
        InspectionScheduled = 3,
        [Description("Выполняется расчет")]
        CalculationPerformed = 4,
        [Description("Готово")]
        Done = 5,
        [Description("Успешно закрыта")]
        SuccessfullyClosed = 6,
        [Description("Отменена")]
        Cancelled = 7
    }

    public enum PaymentStatusType
    {
        [Description("Не оплачено")]
        NotPaid = 0,
        [Description("Оплачено")]
        Paid = 1
    }
}
