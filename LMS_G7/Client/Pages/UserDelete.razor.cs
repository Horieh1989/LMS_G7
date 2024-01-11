using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class UserDelete
    {

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int? Id { get; set; }

        public User User { get; set; } = new User();

        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<User>($"api/User/{Id}");
            if (result != null)
                User = result;
        }
        protected async Task Delete()
        {
            await Http.DeleteAsync($"api/User/{Id}");
            NavigationManager.NavigateTo("/listofusers");
        }
    }
}