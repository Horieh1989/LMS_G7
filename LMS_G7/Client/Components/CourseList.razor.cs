using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;

namespace LMS_G7.Client.Components
{
    public partial class CourseList
    {
        [Parameter]
        public HttpClient Http { get; set; } = new HttpClient();
        [Inject]
        public ICourseDataService? CourseDataService { get; set; }

        [Inject]
        HttpClient HttpClient { get; set; }

        public List<Course> CourseLst { get; set; } = new List<Course>();

        protected override async Task OnInitializedAsync()
        {
            CourseLst = await Http.GetAsync("api/course");

            base.OnInitialized();
        }
    }
}
