using System.ComponentModel;
using System.Reflection.Metadata;

namespace LMS_G7.Shared.Domain
{
    public enum Name
    {
        DotNetProgramming,
        SupportTeknik,
        Systemdeveloper



    }
    public class Course
    {
        public Guid CourseId { get; set; }

        //[DisplayName("course name")]
        //[StringLength(20)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        //Fk

        /*public Guid ModuleId { get; set; }*/

        [DisplayName("Time of starting ")]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Module>? Modules { get; set; }
        public ICollection<User>? Users { get; set; }


        //public ICollection<Document> Documents { get; set; }

    }

}

