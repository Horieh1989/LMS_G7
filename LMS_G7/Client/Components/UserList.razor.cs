using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Components
{
    public partial class UserList
    {
        public List<User> UserLst { get; set; } = new List<User>();

        [Parameter]
        public string ExtraCaption { get; set; } = string.Empty;
        protected override void OnInitialized()
        {
            base.OnInitialized();

            UserLst.Add(new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "first name",
                LastName = "last name",
                Email = "email",
                UserRole = UserRole.teacher,
                CourseId = Guid.NewGuid(),
            });
            UserLst.Add(new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "first name1",
                LastName = "last name1",
                Email = "email1",
                UserRole = UserRole.teacher,
                CourseId = Guid.NewGuid(),
            });
        }

    }
}
