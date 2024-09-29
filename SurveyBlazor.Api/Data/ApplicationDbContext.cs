using Microsoft.EntityFrameworkCore;
using SurveyBlazor.Api.Models;

namespace SurveyBlazor.Api.Data
{
    // Database context for the application
    public class ApplicationDbContext : DbContext
    {
        // Constructor accepting DbContext options
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet representing the SurveyResults table
        public DbSet<SurveyResult> SurveyResults { get; set; } = null!;
    }
}
