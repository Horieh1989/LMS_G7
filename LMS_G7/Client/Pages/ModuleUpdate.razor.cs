using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace LMS_G7.Client.Pages
{
    public partial class ModuleUpdate
    {
        [Inject]
        IModuleDataService ModuleDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public int ModuleId { get; set; }

        Module UpdatedModule { get; set; } = new Module();
        string ErrorMessage { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            UpdatedModule = await ModuleDataService.GetModule(ModuleId);
        }

        protected async Task HandleValidSubmit()
        {
            try
            {
                await ModuleDataService.UpdateModule(UpdatedModule);
                NavigationManager.NavigateTo($"/moduleview/{UpdatedModule.Id}");
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
