using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class CourseUpdate
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int? Id { get; set; }

        public Course Course { get; set; }

        //protected override void OnInitialized()
        //{
        //    if (Id.HasValue)
        //    {
        //        Course = CourseDataService.GetCourse(Id.Value);
        //    }

        //    base.OnInitialized();
        //}


        //protected async Task HandleValidSubmit()
        //{
        //    CourseDataService.UpdateCourse(Course);
        //    NavigationManager.NavigateTo($"/courselst");
        //}
    }


}
