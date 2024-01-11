using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Pages
{
    public partial class CourseAdd { 


        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public Course Course { get; set; } = new Course();
        public string ErrorMessage { get; set; } = string.Empty;
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected async Task HandleValidSubmit()// I should ask this part?
        {
            try
            {
                var result = await Http.PostAsJsonAsync<Course>("api/Course", Course);
                if (!result.IsSuccessStatusCode)

                {
                    ErrorMessage = "Could not add Course!";
                }
                NavigationManager.NavigateTo($"/CourseLst");
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }

        }
    }
}
