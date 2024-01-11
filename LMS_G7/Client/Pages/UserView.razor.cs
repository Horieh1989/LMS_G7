// Ignore Spelling: LMS

using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Pages
{
    public partial class UserView
    {

        [Parameter]
        public int Id { get; set; }

        public User User { get; set; } = new User();

        protected override async Task OnParametersSetAsync()
        {
            var result = await Http.GetFromJsonAsync<User>($"api/User/{Id}");
            if (result != null)
                User = result;
        }

        //protected override async Task OnInitializedAsync()
        //{
        //    var result = await Http.GetFromJsonAsync<User>($"api/User/{Id}");
        //    if (result != null)
        //        User = result;
        //}
    }
}
