namespace Kahnban_ToDo
{
    public class Project
    {
        public DateTime DateDue { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateStart { get; set; }
        public string Description { get; set; } = "";
        public long Id { get; set; }
        public string Name { get; set; } = "";
        public string Organization { get; set; } = "";

        public Project(long id, string name, string description, string organization)
        {
            Id = id;
            Name = name;
            Description = description;
            Organization = organization;
        }
    }
}
