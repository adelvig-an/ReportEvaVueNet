using System.ComponentModel;

namespace Model
{
    /// <summary>
    /// Модель "Задание на оценку".
    /// </summary>
    public class ValuationAssignment
    {
        public int Id { get; set; }
        // Информация из вводной части (о согласовании, заказчике, оценщике)
        /// <summary>
        /// Идентификатор или номер договора/соглашения, в рамках которого составляется задание.
        /// </summary>
        public ContractModel? ContractModel { get; set; }

        /// <summary>
        /// Идентификатор оценщика (может быть ссылкой на другую сущность).
        /// </summary>
        public ExpertModel? ExpertModel { get; set; }

        /// <summary>
        /// Идентификатор юридического лица, с которым оценщик заключил трудовой договор (если применимо).
        /// </summary>
        public ExpertOrganizationModel? ExpertOrganizationModel { get; set; }

        // Раздел 3: Обязательная информация

        /// <summary>
        /// 1) Объект оценки.
        /// </summary>
        public EvaluationObjectInfo? ObjectOfEvaluation { get; set; }

        /// <summary>
        /// 2) Цель оценки. Должна быть установлена однозначно.
        /// </summary>
        public string EvaluationPurpose { get; set; } = string.Empty;

        /// <summary>
        /// 2) Ссылки на конкретные положения нормативных правовых актов РФ, в связи с которыми возникла необходимость оценки (если применимо).
        /// </summary>
        public List<string>? RegulatoryActReferences { get; set; }

        /// <summary>
        /// 3) Указание на то, что оценка проводится в соответствии с Федеральным законом (например, текстовое подтверждение или флаг).
        /// public string? FederalLawComplianceConfirmation { get; set; } // Или string
        /// </summary>
        public bool IsFederalLawCompliant { get; set; }

        /// <summary>
        /// 4) Вид стоимости (например, "Рыночная стоимость").
        /// </summary>
        public ValueOfType ValueOfType { get; set; }

        /// <summary>
        /// 4) Предпосылки стоимости (если это необходимо).
        /// </summary>
        public string ValueAssumptions { get; set; } = string.Empty;

        /// <summary>
        /// 5) Дата оценки.
        /// </summary>
        public DateTime ValuationDate { get; set; }

        /// <summary>
        /// 6) Специальные допущения (если известны на момент составления).
        /// </summary>
        public List<string>? SpecialAssumptions { get; set; }

        /// <summary>
        /// 6) Иные существенные допущения (если известны на момент составления).
        /// </summary>
        public List<string>? OtherSignificantAssumptions { get; set; }

        /// <summary>
        /// 7) Ограничения оценки (если известны на момент составления).
        /// </summary>
        public List<string>? EvaluationLimitations { get; set; }

        /// <summary>
        /// 8) Ограничения на использование, распространение и публикацию отчета об оценке.
        /// </summary>
        public ReportRestrictionDetails? ReportRestrictions { get; set; }

        /// <summary>
        /// 9) Указание на форму составления отчета об оценке (например, "Электронный документ", "На бумажном носителе").
        /// </summary>
        public ReportFormat ReportFormat { get; set; }

        /// <summary>
        /// 10) Иная информация, предусмотренная федеральными стандартами оценки для отражения в задании на оценку.
        /// </summary>
        public List<string>? OtherInformationRequiredByFSO { get; set; }

        // Раздел 4: Дополнительная (необязательная) информация

        /// <summary>
        /// 1) Состав и объем документов и материалов, представляемых заказчиком оценки.
        /// </summary>
        public List<string>? CustomerProvidedDocumentsList { get; set; }

        /// <summary>
        /// 2) Необходимость привлечения внешних организаций и квалифицированных отраслевых специалистов.
        /// </summary>
        public bool RequiresExternalExperts { get; set; }

        /// <summary>
        /// 2) Детали по привлечению внешних экспертов (если RequiresExternalExperts = true).
        /// </summary>
        public string ExternalExpertDetails { get; set; } = string.Empty;

        /// <summary>
        /// 3) Сведения о предполагаемых пользователях результата оценки и отчета об оценке (помимо заказчика).
        /// </summary>
        public string IntendedUsersOfReport { get; set; } = string.Empty;

        /// <summary>
        /// 4) Формы представления итоговой стоимости (например, "В виде точного значения", "В виде интервала значений").
        /// </summary>
        public FinalValuePresentationForm FinalValuePresentationForm { get; set; }

        /// <summary>
        /// 4) Валюта, в которой должна быть представлена стоимость.
        /// </summary>
        public CurrencyOfValue CurrencyOfValue { get; set; }

        /// <summary>
        /// 5) Специфические требования к отчету об оценке (не противоречащие ФСО VI).
        /// </summary>
        public string SpecificReportRequirements { get; set; } = string.Empty;

        /// <summary>
        /// 6) Указание на необходимость проведения дополнительных исследований и определения иных расчетных величин.
        /// </summary>
        public bool RequiresAdditionalResearch { get; set; }

        /// <summary>
        /// 6) Детали по дополнительным исследованиям (если RequiresAdditionalResearch = true).
        /// </summary>
        public string AdditionalResearchDetails { get; set; } = string.Empty;

        // Метаданные для самого задания
        /// <summary>
        /// Дата создания записи задания на оценку.
        /// </summary>
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Дата последнего изменения задания на оценку.
        /// </summary>
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
    }

    public enum ValueOfType
    {
        [Description("Рыночная стоимость")]
        MarketValue = 0,
        [Description("Рыночная и ликвидационная стоимость")]
        MarketAndLiquidationValue = 1,
        [Description("Ликвидационная стоимость")]
        LiquidationValue = 2,
        [Description("Инвестиционная стоимость")]
        InvestmentValue = 3
    }

    public enum ReportFormat
    {
        [Description("Электронный документ")]
        ElectronicDocument = 0,
        [Description("На бумажном носителе")]
        PaperDocument = 1
    }

    public enum CurrencyOfValue
    {
        [Description("Российские рубли")]
        RUB = 0,
        [Description("Доллар США")]
        USD = 1,
        [Description("Евро")]
        EUR = 2
    }

    public enum FinalValuePresentationForm
    {
        [Description("В виде точного значения")]
        ExactValue = 0,
        [Description("В виде интервала значений")]
        IntervalOfValues = 1
    }
}
