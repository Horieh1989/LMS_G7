using LMS_G7.Shared.Domain;

namespace LMS_G7.Client.Services
{
    public class UserDataService : IUserDataService
    {

        public List<User> Users { get; set; } = new List<User>();

        public UserDataService()
        {
            Users.Add(new User()
            {
                Id = 1,
                FirstName = "FirstName1",
                LastName = "LastName1",
                Email = "Email1",
                UserRole = UserRole.student,
                CourseId = 1,
            });
            Users.Add(new User()
            {
                Id = 2,
                FirstName = "FirstName2",
                LastName = "LastName2",
                Email = "Email2",
                UserRole = UserRole.student,
                CourseId = 1,
            });
            Users.Add(new User()
            {
                Id = 3,
                FirstName = "FirstName3",
                LastName = "LastName3",
                Email = "Email3",
                UserRole = UserRole.student,
                CourseId = 1,
            });
        }
        public List<User> GetUsers()
        {
            return Users;
        }

        public User GetUser(int id)
        {
            return Users.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteUser(int id)
        {
            var user = Users.FirstOrDefault(x => x.Id == id);

            if (user != null)
                Users.Remove(user);
        }

        public void UpdateUser(User user)
        {
            var updatedUser = Users.FirstOrDefault(u => u.Id == user.Id);
            if (updatedUser != null)
            {
                updatedUser.FirstName = user.FirstName;
                updatedUser.LastName = user.LastName;
                updatedUser.Email = user.Email;
                updatedUser.CourseId = user.CourseId;
            }
        }

        public void AddUser(User user)
        {
            Random rnd = new Random();
            user.Id = rnd.Next(1000);
            Users.Add(user);
        }
    }
}
