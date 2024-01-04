using LMS_G7.Client.Pages;
using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Components
{
    public partial class ModuleList
    {
        [Parameter]
        public string ExtraCaption { get; set; } = string.Empty;

        [Inject]
        public IModuleDataService ModuleDataService { get; set; }

        public List<Module> ModuleLst { get; set; } = new List<Module>();

        protected override void OnInitialized()
        {
            ModuleLst = ModuleDataService.GetModules();
            base.OnInitialized();
        }
    }
}
