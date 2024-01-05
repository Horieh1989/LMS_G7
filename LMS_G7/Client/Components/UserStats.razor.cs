using LMS_G7.Client.Services;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Components
{
    public partial class UserStats
    {
        [Inject]
        public IUserDataService UserDataService { get; set; }
        public int NumberOfUsers { get; set; }

        protected override void OnInitialized()
        {
            NumberOfUsers = UserDataService.GetUsers().Count;
            base.OnInitialized();
        }
    }
}
