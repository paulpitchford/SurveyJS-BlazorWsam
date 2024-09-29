using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurveyBlazor.Api.Data;
using SurveyBlazor.Api.Models;

namespace SurveyBlazor.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        // Constructor injecting the database context
        public SurveyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Survey
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SurveyResult>>> GetSurveyResults()
        {
            // Retrieve all survey results from the database
            return await _context.SurveyResults.ToListAsync();
        }

        // POST: api/Survey
        [HttpPost]
        public async Task<ActionResult<SurveyResult>> PostSurveyResult(SurveyResult surveyResult)
        {
            // Add the survey result to the context and save changes
            _context.SurveyResults.Add(surveyResult);
            await _context.SaveChangesAsync();

            // Return the created survey result
            return CreatedAtAction(nameof(GetSurveyResult), new { id = surveyResult.Id }, surveyResult);
        }

        // GET: api/Survey/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SurveyResult>> GetSurveyResult(int id)
        {
            var surveyResult = await _context.SurveyResults.FindAsync(id);

            if (surveyResult == null)
            {
                return NotFound();
            }

            return surveyResult;
        }
    }
}
