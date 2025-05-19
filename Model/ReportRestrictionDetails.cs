namespace Model
{
    public class ReportRestrictionDetails
    {
        public int Id { get; set; }
        /// <summary>
        /// Ограничения на использование отчета.
        /// </summary>
        public List<string>? UsageRestrictions { get; set; }

        /// <summary>
        /// Ограничения на распространение отчета.
        /// </summary>
        public List<string>? DistributionRestrictions { get; set; }

        /// <summary>
        /// Ограничения на публикацию отчета.
        /// </summary>
        public List<string>? PublicationRestrictions { get; set; }

        /// <summary>
        /// Иные общие ограничения, если не покрыты выше.
        /// </summary>
        public string? GeneralRestrictions { get; set; }

    }
}
