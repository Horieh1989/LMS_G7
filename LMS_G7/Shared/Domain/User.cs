using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace LMS_G7.Shared.Domain
{
    public enum UserRole
    {
        teacher,
        student
    }

    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }

        public UserRole UserRole { get; set; }

        //Foreign Key
        public int CourseId { get; set; }

        //Navigation Properties
        public Course Course { get; set; }
        public ICollection<Document> Documents { get; set; } = new List<Document>();

    }
}
