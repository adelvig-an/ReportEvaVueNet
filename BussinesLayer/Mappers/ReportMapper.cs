using BussinesLayer.DTOs.Report;
using Model;

namespace BussinesLayer.Mappers
{
    public static class ReportMapper
    {
        public static ReportDto ToReportDto(this ReportModel reportModel)
        {
            return new ReportDto
            {
                Id = reportModel.Id,
                ReportType = reportModel.ReportType,
                Number = reportModel.Number,
                CreateOn = reportModel.CreateOn,
            };
        }

        public static ReportModel ToReportFromCreateDto(this CreateReportRequestDto reportDto)
        {
            return new ReportModel
            {
                ReportType = reportDto.ReportType,
                Number = reportDto.Number,
                CreateOn = reportDto.CreateOn,
            };
        }
    }
}
