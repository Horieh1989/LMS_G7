using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class ActivityDelete
    {


        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int? Id { get; set; }

        public Activity activity { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<Activity>($"api/User/{Id}");
            if (result != null)
                activity = result;
        }
        protected async Task Delete()
        {
            await Http.DeleteAsync($"api/Activity/{Id}");
            NavigationManager.NavigateTo("/listofActivity");
        }
    }
}
