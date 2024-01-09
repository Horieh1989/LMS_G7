using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class ActivityDelete
    {
        [Inject]
        public IActivityDataService? activityDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int? Id { get; set; }

        public Activity activity { get; set; }

        protected override void OnInitialized()
        {
            activity = activityDataService.GetActivity(Id.Value);
        }
        protected void Delete(int id)
        {
            activityDataService.DeleteActivity(activity.Id);
            NavigationManager.NavigateTo("/listofActivity");
        }
    }
}
