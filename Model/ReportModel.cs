using System.ComponentModel;

namespace Model
{
    public class ReportModel
    {
        public int Id { get; set; }
        public ReportType ReportType { get; set; } //Тип отчета
        public string Number { get; set; } = string.Empty; //Номер отчета
        public DateTime CreateOn { get; set; } //Дата составления
        public int? TechnicalSpecificationId { get; set; }
        public TechnicalSpecificationModel? TechnicalSpecification { get; set; }
        public int? ExpertId { get; set; }
        public ExpertModel? Expert { get; set; }
    }

    public enum ReportType
    {
        [Description("Отчет о рыночной стоимости")]
        MarketValueReport = 0,
        [Description("Досудебное заключение эксперта")]
        PreTrialExpertOpinion = 1,
        [Description("Судебное заключение эксперта")]
        CourtExpertOpinion = 2
    }
}
