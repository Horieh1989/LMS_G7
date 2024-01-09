using LMS_G7.Client.Services;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Components
{
    public partial class ActivityStats
    {
        [Inject]
        public IActivityDataService activityDataService { get; set; }
        public int NumberOfActivity { get; set; }

        protected override void OnInitialized()
        {
            NumberOfActivity = activityDataService.GetActivity().Count;
            base.OnInitialized();
        }
    }
}
