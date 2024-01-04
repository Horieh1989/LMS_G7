using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class CourseDelete
    {
        [Inject]
        public ICourseDataService CourseDataService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]

        public int CourseId { get; set; }

        public Course Course { get; set; } = new Course();

        protected override void OnInitialized()
        {

           

           base.OnInitialized();
        }
        protected void Delet(int CourseId)
        {
            CourseDataService.DeleteCourse(CourseId);//why we dont use directly instead of delet ,deletdevice
            NavigationManager.NavigateTo($"CourseLst");
        }


    }
}
