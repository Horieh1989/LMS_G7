using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace LMS_G7.Client.Pages
{
    public partial class ActivityUpdate
    {
        [Parameter]
        public int? Id { get; set; }

        [Inject]
        public IActivityDataService? activityDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public Activity activity { get; set; }

        private string selectedFileName;

        protected override void OnInitialized()
        {
            if (Id.HasValue)
            {
                activity = activityDataService.GetActivity(Id.Value);
            }

            base.OnInitialized();
        }

        protected async Task HandleValidSubmit()
        {
            activityDataService.UpdateActivity(activity);
            NavigationManager.NavigateTo("/listofActivity");
        }

        private async Task HandleFileSelected(InputFileChangeEventArgs e)
        {
            var file = e.File;

            if (file != null)
            {
                selectedFileName = file.Name;

                // You can perform further actions with the file, such as uploading it to a server.
                // For demonstration purposes, let's just print some information about the file.
                Console.WriteLine($"File Name: {file.Name}");
                Console.WriteLine($"File Size: {file.Size} bytes");
            }
        }
    }
}
