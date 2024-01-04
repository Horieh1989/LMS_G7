using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class Activityview
    {
            [Inject]
            public IActivityDataService? activityDataService { get; set; }

            [Parameter]
            public int Id { get; set; }

            public Activity activity { get; set; } = new Activity();

            protected override void OnInitialized()
            {
                activity = activityDataService.GetActivity(Id);
                base.OnInitialized();
            }
        }
}
