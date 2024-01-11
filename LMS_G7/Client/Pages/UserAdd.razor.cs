using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class UserAdd
    {
        //[Inject]
        //public IUserDataService UserDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public User User { get; set; } = new User();
        public string ErrorMessage { get; set; } = string.Empty;
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected async Task HandleValidSubmit()// I should ask this part?
        {
            try
            {
                var result = await Http.PostAsJsonAsync<User>("api/User", User);
                if (!result.IsSuccessStatusCode)
                {
                    ErrorMessage = "Could not add User!";
                }
                NavigationManager.NavigateTo($"/listofusers");
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
