using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using static System.Net.WebRequestMethods;
using System.Net.Http.Json;
namespace LMS_G7.Client.Pages
{
    public partial class CourseView
    {

        [Parameter]
        public int Id { get; set; }
        public Course Course { get; set; } = new Course();
        protected override async Task OnParametersSetAsync()
        {
            var result = await Http.GetFromJsonAsync<Course>($"api/Course/{Id}");
            if (result != null)
                Course = result;
        }

    }
}
