using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profilepage.cilent
{
    internal class IssueDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
    }
    public enum Priority
    {
        Low, Medium, High
    }
    public enum issueType
    {
        Feature, Bug, Documentation
    }
}
