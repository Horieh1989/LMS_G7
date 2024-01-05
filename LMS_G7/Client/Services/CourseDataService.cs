using LMS_G7.Shared.Domain;
using System.Xml.Linq;

namespace LMS_G7.Client.Services
{
    public class CourseDataService : ICourseDataService
    {
        public static List<Course> CourseList = new List<Course>();
        public CourseDataService()
        {

            //CourseList.Add(new Course() { Id = 1, Name = Name.DotNetProgramming, Description = "This course..", StartDate = DateTime.Today });
            //CourseList.Add(new Course() { Id = 2, Name = Name.Systemdeveloper, Description = "This course..", StartDate = DateTime.Today });
            //CourseList.Add(new Course() { Id = 3, Name = Name.SupportTeknik, Description = "This course..", StartDate = DateTime.Today });

            CourseList.Add(new Course() { Id = 1, Name = "DotNetProgramming", Description = "This course..", StartDate = DateTime.Today, EndDate = DateTime.Now });
            CourseList.Add(new Course() { Id = 2, Name = "SystemDeveloper", Description = "This course..", StartDate = DateTime.Today, EndDate = DateTime.Now });
            CourseList.Add(new Course() { Id = 3, Name = "SupportTeknik", Description = "This course..", StartDate = DateTime.Today, EndDate = DateTime.Now });



        }
        public void AddCourse(Course Course)
        {
            Random rnd = new Random();
            Course.Id = rnd.Next(100000);
            CourseList.Add(Course);
        }

        public void DeleteCourse(int Id)
        {
            var course = CourseList.FirstOrDefault(c => c.Id == Id);
            if (course != null)
            {
                CourseList.Remove(course);
            }
        }

        public Course GetCourse(int Id)
        {
            return CourseList.FirstOrDefault(x => x.Id == Id);
        }

        public List<Course> GetCourses()
        {
            return CourseList;
        }

        public void UpdateCourse(Course UpdatedCourse)
        {
            var Course = CourseList.FirstOrDefault(d => d.Id == UpdatedCourse.Id);
            if (Course != null)
            {
                Course.Name = UpdatedCourse.Name;
                Course.Description = UpdatedCourse.Description;
                Course.StartDate = UpdatedCourse.StartDate;
                Course.EndDate = UpdatedCourse.EndDate;
            }
        }
    }
}
