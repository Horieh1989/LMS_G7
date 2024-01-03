using LMS_G7.Shared.Domain;

namespace LMS_G7.Client.Services
{
    public interface IUserDataService
    {
        List<User> GetUsers();
        User GetUser(int id);
        void DeleteUser(int id);
        void UpdateUser(User user);
        void AddUser(User user);
    }
}
