namespace SurveyBlazor.Web.Models
{
    public class SurveyResult
    {
        public int Id { get; set; }

        // Stores the user's answers as a JSON string
        public string SurveyData { get; set; } = string.Empty;

        // Stores the survey's structure (questions) as a JSON string
        public string SurveyStructure { get; set; } = string.Empty;
    }
}