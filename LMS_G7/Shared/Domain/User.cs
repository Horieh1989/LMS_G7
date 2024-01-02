using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_G7.Shared.Domain
{
    public enum UserRole
    {
        teacher,
        student
    }

    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }

        public UserRole UserRole { get; set; }

        public Guid CourseId { get; set; }

        //public Course Course { get; set; }

        //public ICollection<UserDocument> UserDocuments { get; set; }

    }
}
