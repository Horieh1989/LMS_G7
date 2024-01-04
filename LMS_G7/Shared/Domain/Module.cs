using System.Diagnostics;

namespace LMS_G7.Shared.Domain;

public class Module
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    //Foreign Key
    public int CourseId { get; set; }

    //Navigation Properties
    public Course Course { get; set; }
    public ICollection<Activity>? Activities { get; set; } = new List<Activity>();
    public ICollection<Document> Documents { get; set; } = new List<Document>();
}