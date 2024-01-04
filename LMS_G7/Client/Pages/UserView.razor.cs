// Ignore Spelling: LMS

using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class UserView
    {
        [Inject]
        public IUserDataService? UserDataService { get; set; }

        [Parameter]
        public int Id { get; set; }

        public User User { get; set; } = new User();

        protected override void OnInitialized()
        {
            User = UserDataService.GetUser(Id);
            base.OnInitialized();
        }
    }
}
