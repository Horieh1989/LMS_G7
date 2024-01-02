using Microsoft.AspNetCore.Components;
using LMS_G7.Server.Models;
 

namespace LMS_G7.Client.Pages
{
    public partial class CourseAdd
    {
        public List <Course> CourseLst { get; set; }=new List<Course>();
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        protected override void OnInitialized()
        {
            base.OnInitialized();

         

        }
        public void AddCourse(Course Course)// I should ask
        {
            Random rnd = new Random();
            Course.CourseId = rnd.Next(100000);
            CourseLst.Add(Course);
            NavigationManager.NavigateTo($"/Course");
        }






    }
}
