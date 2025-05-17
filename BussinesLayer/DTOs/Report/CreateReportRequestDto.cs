using Model;

namespace BussinesLayer.DTOs.Report
{
    public class CreateReportRequestDto
    {
        public ReportType ReportType { get; set; }
        public string Number { get; set; } = string.Empty;
        public DateTime CreateOn { get; set; }
    }
}
