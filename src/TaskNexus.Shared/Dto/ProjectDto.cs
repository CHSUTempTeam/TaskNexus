namespace TaskNexus.WebApi
{
    public class ProjectDto
    {
        public string IdProject { get; set; }
        public string Id { get; set; }
        public List<string> Messages { get; set; }
        public string Board { get; set; }
        public List<string> Members { get; set; }
    }
}
