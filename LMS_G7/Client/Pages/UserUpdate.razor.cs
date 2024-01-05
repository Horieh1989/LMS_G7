using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class UserUpdate
    {
        [Parameter]
        public int? Id { get; set; }

        [Inject]
        public IUserDataService? UserDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            if (Id.HasValue)
            {
                User = UserDataService.GetUser(Id.Value);
            }

            base.OnInitialized();
        }

        protected async Task HandleValidSubmit()
        {
            UserDataService.UpdateUser(User);
            NavigationManager.NavigateTo("/listofusers");
        }
    }
}
