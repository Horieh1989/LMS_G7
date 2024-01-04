using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Reflection;

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
        public int CourseId { get; set; }
        //[DisplayName("course name")]
        //[StringLength(20)]
        public Name Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }= DateTime.Now;

        //Fk
        public int ModuleId { get; set; }
        [DisplayName("Time of starting ")]
      

        public ICollection<Module> Modules { get; set; }
        //public ICollection<User> Users { get; set; }
        public ICollection<Document> Documents { get; set; }

    }

}

