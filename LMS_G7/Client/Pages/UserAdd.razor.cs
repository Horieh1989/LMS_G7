using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class UserAdd
    {
        [Inject]
        public IUserDataService UserDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public User User { get; set; } = new User();

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected async Task HandleValidSubmit()
        {
            UserDataService.AddUser(User);
            NavigationManager.NavigateTo("/listofusers");
        }
    }
}
