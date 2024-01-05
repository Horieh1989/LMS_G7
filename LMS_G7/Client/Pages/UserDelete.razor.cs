using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class UserDelete
    {
        [Inject]
        public IUserDataService? UserDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int? Id { get; set; }

        public User User { get; set; }

        protected override void OnInitialized()
        {
            User = UserDataService.GetUser(Id.Value);
        }
        protected void Delete(int id)
        {
            UserDataService.DeleteUser(User.Id);
            NavigationManager.NavigateTo("/listofusers");
        }
    }
}