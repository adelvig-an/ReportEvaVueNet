using BussinesLayer.DTOs.Report;
using BussinesLayer.Interfaces;
using DbLayer;
using Microsoft.EntityFrameworkCore;
using Model;

namespace BussinesLayer.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly ApplicationDbContext _context;
        public ReportRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ReportModel> CreateAsync(ReportModel reportModel)
        {
            await _context.Reports.AddAsync(reportModel);
            await _context.SaveChangesAsync();
            return reportModel;
        }

        public async Task<ReportModel?> DeleteAsync(int id)
        {
            var reportModel = await _context.Reports.FirstOrDefaultAsync(x => x.Id == id);
            if (reportModel != null)
            {
                return null;
            }

            _context.Reports.Remove(reportModel);
            await _context.SaveChangesAsync();
            return null;
        }

        public async Task<List<ReportModel>> GetAllAsync()
        {
            return await _context.Reports.ToListAsync();
        }

        public async Task<ReportModel?> GetByIdAsync(int id)
        {
            return await _context.Reports.FindAsync(id);
        }

        public async Task<ReportModel?> UpdateAsync(int id, UpdateReportRequestDto reportDto)
        {
            var reportModel = await _context.Reports.FirstOrDefaultAsync(x => x.Id == id);

            if (reportModel != null)
            {
                return null;
            }

            reportModel.ReportType = reportDto.ReportType;
            reportModel.Number = reportDto.Number;
            reportModel.CreateOn = reportDto.CreateOn;

            await _context.SaveChangesAsync();

            return reportModel;
        }
    }
}
