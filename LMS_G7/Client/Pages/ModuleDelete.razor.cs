using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace LMS_G7.Client.Pages
{
    public partial class ModuleDelete
    {
        [Inject]
        IModuleDataService ModuleDataService { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        [Parameter] public int Id { get; set; }
        private Module Module { get; set; } = new Module();
        private string ErrorMessage { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            // Load module details when the component is initialized
            try
            {
                Module = await ModuleDataService.GetModule(Id);
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }

        private async Task HandleDelete()
        {
            try
            {
                await ModuleDataService.DeleteModule(Id);
                Navigation.NavigateTo("/modules"); // Redirect to the module list page after deletion
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }

        private void CancelDelete()
        {
            Navigation.NavigateTo("/modules"); // Redirect to the module list page without deletion
        }
    }
}
