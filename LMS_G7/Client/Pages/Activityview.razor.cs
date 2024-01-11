using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Pages
{
    public partial class Activityview
    {

        public IActivityDataService? activityDataService = new ActivityDataService();
        [Parameter]
        public int Id { get; set; }

        public Activity activity { get; set; } = new Activity();

        protected override async Task OnParametersSetAsync()
        {
            var result = await Http.GetFromJsonAsync<Activity>($"api/Activity/{Id}");
            if (result != null)
                activity = result;
        }

        //protected override void OnInitialized()
        //{
        //    activity = activityDataService.GetActivity(Id);
        //    base.OnInitialized();
        //}
    }
}
