using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace LMS_G7.Client.Pages
{
    public partial class ModuleView
    {
        [Inject]
        IModuleDataService ModuleDataService { get; set; }

        [Parameter]
        public int ModuleId { get; set; }

        Module Module { get; set; } = new Module();

        protected override async Task OnInitializedAsync()
        {
            Module = await ModuleDataService.GetModule(ModuleId);
        }
    }
}
