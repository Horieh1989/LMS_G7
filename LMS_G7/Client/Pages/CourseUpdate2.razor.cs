using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class CourseUpdate2
    {
       
        
            [Inject]
            public ICourseDataService CourseDataService { get; set; }

            [Inject]
            public NavigationManager NavigationManager { get; set; }

            [Parameter]
            public int? CourseId { get; set; }

            public Course Course { get; set; } = new Course();

            protected override void OnInitialized()
            {
                if (CourseId.HasValue)
                {
                   Course = CourseDataService.GetCourse(CourseId.Value);
                }

                base.OnInitialized();
            }

            protected async Task HandleValidSubmit()
            {
               CourseDataService.UpdateCourse(Course);
                NavigationManager.NavigateTo($"/devicelst");
            }
        }


}
