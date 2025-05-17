using Model;

namespace BussinesLayer.DTOs.Report
{
    public class ReportDto
    {
        public int Id { get; set; }
        public ReportType ReportType { get; set; }
        public string Number { get; set; } = string.Empty;
        public DateTime CreateOn { get; set; }
    }
}
