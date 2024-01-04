using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class ModuleAdd
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        public IModuleDataService ModuleDataService { get; set; } = default!;

        [Parameter]
        public int CourseId { get; set; }

        public Module Module { get; set; } = new Module();

        public string ErrorMessage { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        private async Task HandleValidSubmit()
        {
            try
            {
                Module.CourseId = CourseId;
                if (await GenericDataService.AddAsync(UriHelper.GetModulesUri(), Module))
                {
                    NavigationManager.NavigateTo("/");
                }
                else
                {
                    ErrorMessage = "Could not add module";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"{ex.Message} {ex.HResult}";
            }
        }

        private void DeleteModule()
        {

        }
    }
}