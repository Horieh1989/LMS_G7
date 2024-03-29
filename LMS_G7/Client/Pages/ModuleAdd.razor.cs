﻿using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LMS_G7.Client.Pages
{
    public partial class ModuleAdd
    {
        [Inject]
        IModuleDataService ModuleDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public Module NewModule { get; set; } = new Module();
        public string ErrorMessage { get; set; } = string.Empty;

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected async Task HandleValidSubmit()
        {
            try
            {
                var result = await Http.PostAsJsonAsync<Module>("api/Module", NewModule);
                if (!result.IsSuccessStatusCode)
                {
                    ErrorMessage = "Could not add Module!";
                }
                NavigationManager.NavigateTo("/modules");
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
