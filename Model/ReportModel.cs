using System.ComponentModel;

namespace Model
{
    public class ReportModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Тип отчета.
        /// </summary>
        public ReportType ReportType { get; set; } //Тип отчета
        /// <summary>
        /// Номер отчета.
        /// </summary>
        public string Number { get; set; } = string.Empty; //Номер отчета
        /// <summary>
        /// Дата составления отчета.
        /// </summary>
        public DateTime CreateOn { get; set; } = DateTime.UtcNow; //Дата составления
        /// <summary>
        /// Идентификатор Задания на оценку.
        /// Для других типов отчетов Техническое задание.
        /// </summary>
        public ValuationAssignment? ValuationAssignment { get; set; }
    }

    public enum ReportType
    {
        [Description("Отчет об оценке объекта оценки")]
        MarketValueReport = 0,
        [Description("Исследование специалиста")]
        SpecialistResearch = 1,
        [Description("Судебное заключение")]
        CourtExpertOpinion = 2
    }
}
