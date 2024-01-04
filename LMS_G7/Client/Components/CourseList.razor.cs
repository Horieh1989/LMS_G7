using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Components
{
    public partial class CourseList
    {
        [Parameter]
        public string ExtraCaption { get; set; } = string.Empty;// I should ask this
        [Inject]
        public ICourseDataService? CourseDataService { get; set; }
        public List<Course> CourseLst { get; set; } = new List<Course>();
        protected override void OnInitialized()
        {
            CourseLst = CourseDataService.GetCourses();
            base.OnInitialized();
        }
    }
}
