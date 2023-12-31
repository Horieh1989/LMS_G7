using LMS_G7.Client.Helpers;
using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class ModuleDetails
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        [Inject]
        public IGenericDataService GenericDataService { get; set; } = default!;

        [Parameter]
        public Guid? ModuleId { get; set; }

        public Module Module { get; set; } = new Module();

        public IEnumerable<Activity> Activities { get; set; } = new List<Activity>();

        public string ErrorMessage { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            if (ModuleId == null)
            {
                ErrorMessage = "Module not found";
                return;
            }

            Module = await GenericDataService.GetAsync<Module>(UriHelper.GetModuleUri(ModuleId.Value)) ?? Module;

            if (Module == null)
            {
                ErrorMessage = "Module not found";
                return;
            }

            Activities = (await GenericDataService.GetAsync<IEnumerable<Activity>>(UriHelper.GetActivitiesUri(ModuleId.Value.ToString())))!;

            await base.OnInitializedAsync();
        }
    }
}
