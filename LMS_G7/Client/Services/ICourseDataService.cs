using LMS_G7.Shared.Domain;

namespace LMS_G7.Client.Services
{
    public interface ICourseDataService
    {
        List<Course> GetCourses();
        Course GetCourse(int Id);
        void DeleteCourse(int Id);
        void UpdateCourse(Course Course);
        void AddCourse(Course Course);
    }
}
