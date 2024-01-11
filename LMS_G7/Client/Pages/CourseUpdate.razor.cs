using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Authorization;

namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class CourseUpdate
    {
        [Parameter]
        public int? Id { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Course Course { get; set; } = new Course();


        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<Course>($"api/Course/{Id}");
            if (result != null)
                Course = result;
        }

        protected async Task HandleValidSubmit()
        {
            await Http.PutAsJsonAsync($"api/Course/{Id}", Course);
            NavigationManager.NavigateTo("/CourseLst");
        }
    }
}
