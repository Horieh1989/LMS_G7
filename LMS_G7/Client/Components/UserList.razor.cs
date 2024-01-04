using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Components
{
    public partial class UserList
    {
        [Parameter]
        public string ExtraCaption { get; set; } = string.Empty;

        [Inject]
        public IUserDataService UserDataService { get; set; }

        public List<User> UserLst { get; set; } = new List<User>();
        protected override void OnInitialized()
        {
            UserLst = UserDataService.GetUsers();
            base.OnInitialized();
        }

    }
}
