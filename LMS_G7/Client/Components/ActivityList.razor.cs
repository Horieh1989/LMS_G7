using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Components
{
    public partial class ActivityList
    {

        [Parameter]
        public string ExtraCaption { get; set; } = string.Empty;


        public IActivityDataService activityDataService = new ActivityDataService();

        public List<Activity> ActivityLst { get; set; } = new List<Activity>();
        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<List<Activity>>("api/Activity");
            if (result != null)
                ActivityLst = result;
        }

    }
}

