using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Components
{
    public partial class ActivityList
    {
       
            [Parameter]
            public string ExtraCaption { get; set; } = string.Empty;

            [Inject]
            public IActivityDataService activityDataService { get; set; }

            public List<Activity> ActivityLst { get; set; } = new List<Activity>();
            protected override void OnInitialized()
            {
                ActivityLst = activityDataService.GetActivity();
                base.OnInitialized();
            }

        }
    }

