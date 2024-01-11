using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;


namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class ActivityUpdate
    {
        [Parameter]
        public int? Id { get; set; }


        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Activity Activity { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<Activity>($"api/Activity/{Id}");
            if (result != null)
                Activity = result;
        }

        protected async Task HandleValidSubmit()
        {
            await Http.PutAsJsonAsync($"api/Activity/{Id}", Activity);
            NavigationManager.NavigateTo("/listofActivity");
        }
    }
}