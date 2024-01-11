using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class ActivityAdd
    {
        [Inject]
        public IActivityDataService ActivityDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;

        public Activity Activity { get; set; } = new Activity();

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected async Task HandleValidSubmit()// I should ask this part?
        {
            try
            {
                var result = await Http.PostAsJsonAsync<Activity>("api/Activity", Activity);
                if (!result.IsSuccessStatusCode)
                {
                    ErrorMessage = "Could not add Activity!";
                }
                NavigationManager.NavigateTo($"/listofActivity");
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
