using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    public class UserStory
    {
        public DateTime DateEnd { get; set; }
        public DateTime DateStart { get; set; }
        public long Id { get; set; }
        public string Name { get; set; } = "";
        public string Organization { get; set; } = "";
        public string Project { get; set; } = "";
        public string Status { get; set; } = "";
        public string Summary { get; set; } = "";
        public string TaskList { get; set; } = "";

        public UserStory (long id, string name, string organization, string project, string status, string summary, string taskList)
        {
            Id = id;
            Name = name;
            Organization = organization;
            Project = project;
            Status = status;
            Summary = summary;
            TaskList = taskList;
        }
    }
}
