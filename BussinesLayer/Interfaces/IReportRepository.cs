using BussinesLayer.DTOs.Report;
using Model;

namespace BussinesLayer.Interfaces
{
    public interface IReportRepository
    {
        Task<List<ReportModel>> GetAllAsync();
        Task<ReportModel?> GetByIdAsync(int id); //FirstOrDefault CAN BE NULL
        Task<ReportModel> CreateAsync(ReportModel reportModel);
        Task<ReportModel?> UpdateAsync(int id, UpdateReportRequestDto updateDto);
        Task<ReportModel?> DeleteAsync(int id);
    }
}
