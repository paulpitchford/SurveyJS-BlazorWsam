using System.Text.Json;

namespace SurveyBlazor.Web.Models
{
    public class SurveyStructure
    {
        public string Title { get; set; }
        public string ShowProgressBar { get; set; }
        public List<SurveyPage> Pages { get; set; }
    }

    public class SurveyPage
    {
        public List<SurveyElement> Elements { get; set; }
    }

    public class SurveyElement
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public bool IsRequired { get; set; }
        public string MinRateDescription { get; set; }
        public string MaxRateDescription { get; set; }
    }
}
