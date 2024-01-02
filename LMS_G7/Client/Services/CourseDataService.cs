using LMS_G7.Shared;

namespace LMS_G7.Client.Services
{
    public class CourseDataService : ICourseDataService
    {
        public static List<Course> CourseList = new List<Course>();
        public CourseDataService() {

            CourseList.Add(new Course() { CourseId = 1, Name = Name.DotNetProgramming, Description = "This course..", StartDate = DateTime.Today });
            CourseList.Add(new Course() { CourseId = 2, Name = Name.Systemdeveloper, Description = "This course..", StartDate = DateTime.Today });
            CourseList.Add(new Course() { CourseId = 3, Name = Name.SupportTeknik, Description = "This course..", StartDate = DateTime.Today });

                
        
        
        }  
        public void AddCourse(Course Course)
        {
            Random rnd = new Random();
            Course.CourseId = rnd.Next(100000);
            CourseList.Add(Course);
        }

        public void DeleteCourse(int Id)
        {
            var Course = CourseList.FirstOrDefault(c => c.CourseId == Id);
            if (Course! == null)
            {
                CourseList.Remove(Course);
            }
        }

        public Course GetCourse(int Id)
        {
            return CourseList.FirstOrDefault(x=> x.CourseId==Id);
        }

        public List<Course> GetCourses()
        {
           return CourseList;
        }

        public void UpdateCourse(Course UpdatedCourse)
        {
            var Course = CourseList.FirstOrDefault(d => d.CourseId == UpdatedCourse.CourseId);
            if (Course != null)
            {
                Course.Name = UpdatedCourse.Name;
                Course.Description = UpdatedCourse.Description;
                Course.StartDate = UpdatedCourse.StartDate;
            }
        }
    }
}
