using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class CourseDelete
    {

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]

        public int? Id { get; set; }

        public Course Course { get; set; } = new Course();

        //protected override void OnInitialized()
        //{   
        //    Course=CourseDataService.GetCourse(Id.Value);

        //}
        //protected void Delete(int Id)
        //{
        //    CourseDataService.DeleteCourse(Course.Id);
        //    NavigationManager.NavigateTo("/CourseLst");
        //}


    }
}
