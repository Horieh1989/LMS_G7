using LMS_G7.Shared.Domain;

namespace LMS_G7.Client.Services
{
    public interface IActivityDataService
    {
        List<Activity> GetActivity();
        Activity GetActivity(int id);
        void DeleteActivity(int id);
        void UpdateActivity(Activity activity);
        void AddActivity(Activity activity);
    }
}
