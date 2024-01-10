using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;


namespace LMS_G7.Client.Pages
{
    [Authorize(Roles = "Admin, Teacher")]
    public partial class ActivityUpdate
    {
        [Parameter]
        public int? Id { get; set; }

        [Inject]
        public IActivityDataService? ActivityDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Activity Activity { get; set; }

        protected override void OnInitialized()
        {
            if (Id.HasValue)
            {
                Activity = ActivityDataService.GetActivity(Id.Value);
            }

            base.OnInitialized();
        }

        protected async Task HandleValidSubmit()
        {
            ActivityDataService.UpdateActivity(Activity);
            NavigationManager.NavigateTo("/listofusers");
        }
    }
}