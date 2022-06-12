namespace OwlParser.Api.Models
{
    public class HomeModel
    {
        public IFormFile? OwlFile { get; set; }
        public string? ExceptionMessage { get; set; }
        public string? BpmnXmlString { get; set; }
    }
}