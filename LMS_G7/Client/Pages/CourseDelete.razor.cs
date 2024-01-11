using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Pages
{
    public partial class CourseDelete
    {

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]

        public int? Id { get; set; }

        public Course Course { get; set; } = new Course();

        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<Course>($"api/User/{Id}");
            if (result != null)
               Course = result;
        }
        protected async Task Delete()
        {
            await Http.DeleteAsync($"api/course/{Id}");
            NavigationManager.NavigateTo("/CourseLst");
        }


    }
}
