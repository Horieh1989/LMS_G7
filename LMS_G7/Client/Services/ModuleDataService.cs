﻿using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Http.Extensions;

namespace LMS_G7.Client.Services
{
    public class ModuleDataService : IModuleDataService
    {
        private readonly IGenericDataService dataService;

        public ModuleDataService(IGenericDataService genericDataService)
        {
            dataService = genericDataService;
        }

        public async Task<Module?> GetAsync() => await dataService.GetAsync<Module>(UriHelper.GetModulesUri());
        public async Task<Module?> GetAsync(Guid id, bool includeActivities = false) => await dataService.GetAsync<Module>(UriHelper.GetModuleUri(id, includeActivities));

        public async Task<bool> AddAsync(Module module) => await dataService.AddAsync(UriHelper.GetModulesUri(), module);

        public async Task<bool> UpdateAsync(Module module) => await dataService.UpdateAsync(UriHelper.GetModuleUri(module.Id), module);

        public async Task<bool> DeleteAsync(Guid id) => await dataService.DeleteAsync(UriHelper.GetModuleUri(id));

        public async Task<List<Module>> GetModulesByCourseId(Guid id) => await dataService.GetAsync<List<Module>>($"modulesbycourse/{id}");
    }
}
