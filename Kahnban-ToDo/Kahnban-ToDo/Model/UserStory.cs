using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    public class UserStory
    {
        public string Category { get; set; } = "";
        public DateTime? DateDue { get; set; }
        public DateTime? DateEnd { get; set; }
        public DateTime? DateStart { get; set; }
        public long Id { get; set; }
        public string Name { get; set; } = "";
        public string Organization { get; set; } = "";
        public string Project { get; set; } = "";
        public string Status { get; set; } = "";
        public string Summary { get; set; } = "";
        public string TaskList { get; set; } = "";

        public UserStory()
        {
            Category = "";
            Name = "";
            Organization = "";
            Project = "";
            Status = "";
            Summary = "";
            TaskList = "";
        }
    }
}
