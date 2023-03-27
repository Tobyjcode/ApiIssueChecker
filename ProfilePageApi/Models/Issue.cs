using System.ComponentModel.DataAnnotations;

namespace ProfilePageApi.Models
{
    // My public class for issue containing Id, Title, and Description im creating my properties here
    public class Issue
    {
        // I make some of my propeties required so it means that they must have a value
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime Created { get ; set; }
        public DateTime? Completed { get; set; }
    }
    // This is my enum for the Priority of the issue at hand
    public enum Priority
    {
        Low, Medium, High
    }
    public enum issueType
    {
        Feature, Bug, Documentation
    }
}
