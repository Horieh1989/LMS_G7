using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Reflection;

namespace LMS_G7.Server.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [DisplayName("course name")]
        [StringLength(20)]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }

        //Fk
        public int ModuleId { get; set; }
        [DisplayName("Time of starting ")]
        public DateTime StartDate { get; set; }

        public ICollection<Module> Modules { get; set; }
        //public ICollection<User> Users { get; set; }
        public ICollection<Document> Documents { get; set; }

    }
}
