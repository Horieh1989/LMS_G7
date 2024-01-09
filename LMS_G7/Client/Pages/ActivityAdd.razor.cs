using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class ActivityAdd
    {
        [Inject]
        public IActivityDataService activityDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Activity activity { get; set; } = new Activity();

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected async Task HandleValidSubmit()
        {
            activityDataService.AddActivity(activity);
            NavigationManager.NavigateTo("/listofActivity");
        }
    }
}
