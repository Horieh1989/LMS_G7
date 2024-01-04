﻿using LMS_G7.Shared.Domain;
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

            CourseList.Add(new Course() { Id = 1, Name = "CourseName1", Description = "This course..", StartDate = DateTime.Today });
            CourseList.Add(new Course() { Id = 2, Name = "CourseName2", Description = "This course..", StartDate = DateTime.Today });
            CourseList.Add(new Course() { Id = 3, Name = "CourseName3", Description = "This course..", StartDate = DateTime.Today });



        }
        public void AddCourse(Course Course)
        {
            Random rnd = new Random();
            Course.Id = rnd.Next(100000);
            CourseList.Add(Course);
        }

        public void DeleteCourse(int Id)
        {
            var Course = CourseList.FirstOrDefault(c => c.Id == Id);
            if (Course! == null)
            {
                CourseList.Remove(Course);
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
            }
        }
    }
}
