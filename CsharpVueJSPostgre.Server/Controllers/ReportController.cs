using BussinesLayer.DTOs.Report;
using BussinesLayer.Interfaces;
using BussinesLayer.Mappers;
using DbLayer;
using Microsoft.AspNetCore.Mvc;

namespace CsharpVueJSPostgre.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IReportRepository _reportRepo;
        public ReportController(ApplicationDbContext dbContext, IReportRepository reportRepo)
        {
            _reportRepo = reportRepo;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var reports = await _reportRepo.GetAllAsync();

            var reportDto = reports.Select(s => s.ToReportDto());

            return Ok(reports);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var report = await _reportRepo.GetByIdAsync(id);

            if (report == null)
            {
                return NotFound();
            }

            return Ok(report.ToReportDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateReportRequestDto reportDto)
        {
            var reportModel = reportDto.ToReportFromCreateDto();

            await _reportRepo.CreateAsync(reportModel);

            return CreatedAtAction(nameof(GetById), new { id = reportModel.Id }, reportModel.ToReportDto());
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateReportRequestDto updateDto)
        {
            var reportModel = await _reportRepo.UpdateAsync(id, updateDto);

            if (reportModel == null)
            { return NotFound(); }

            return Ok(reportModel.ToReportDto());
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var reportModel = await _reportRepo.DeleteAsync(id);

            if (reportModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
