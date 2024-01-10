using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Components
{
    public partial class UserList
    {
        [Parameter]
        public string ExtraCaption { get; set; } = string.Empty;

        //[Inject]
        //public IUserDataService UserDataService { get; set; }

        public List<User> UserLst { get; set; } = new List<User>();
        //protected override void OnInitialized()
        //{
        //    UserLst = UserDataService.GetUsers();
        //    base.OnInitialized();
        //}
        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<List<User>>("api/User");
            if (result != null)
                UserLst = result;
        }
    }
}
