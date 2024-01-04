using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Reflection;

#nullable disable
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
        public int Id { get; set; }
        //[DisplayName("course name")]
        //[StringLength(20)]
        public Name Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }= DateTime.Now;

        [DisplayName("Time of starting ")]


        //Navigation Properties
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Module> Modules { get; set; } = new List<Module>();
        public ICollection<Document> Documents { get; set; } = new List<Document>();

    }

}

