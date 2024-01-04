using LMS_G7.Shared.Domain;

namespace LMS_G7.Client.Services
{
    public class ModuleDataService : IModuleDataService
    {
        public List<Module> Modules { get; set; } = new List<Module>();
        public ModuleDataService()
        {
            Modules.Add(new Module() { Id = 1, Name = "Name1", StartDate = DateTime.Now.AddDays(-30), EndDate = DateTime.Now.AddDays(30), });
            Modules.Add(new Module() { Id = 2, Name = "Name2", StartDate = DateTime.Now.AddDays(-40), EndDate = DateTime.Now.AddDays(30), });
            Modules.Add(new Module() { Id = 3, Name = "Name3", StartDate = DateTime.Now.AddDays(-50), EndDate = DateTime.Now.AddDays(30), });
        }

        public List<Module> GetModules()
        {
            return Modules;
        }

        public Module GetModule(int Id)
        {
            return Modules.FirstOrDefault(x => x.Id == Id);
        }

        public void DeleteModule(int Id)
        {
            var Module = Modules.FirstOrDefault(x => x.Id == Id);
            if (Module != null)
            {
                Modules.Remove(Module);
            }
        }

        public void UpdateModule(Module updatedModule)
        {
            var module = Modules.FirstOrDefault(d => d.Id == updatedModule.Id);
            if (module != null)
            {
                module.Name = updatedModule.Name;
                module.StartDate = updatedModule.StartDate;
                module.EndDate = updatedModule.EndDate;
            }
        }

        public void AddModule(Module module)
        {
            Random rnd = new Random();
            module.Id = rnd.Next(100000);
            Modules.Add(module);
        }


        //private readonly IGenericDataService dataService;

        //public ModuleDataService(IGenericDataService genericDataService)
        //{
        //    dataService = genericDataService;
        //}

        //public async Task<Module?> GetAsync() => await dataService.GetAsync<Module>(UriHelper.GetModulesUri());
        //public async Task<Module?> GetAsync(Guid id, bool includeActivities = false) => await dataService.GetAsync<Module>(UriHelper.GetModuleUri(id, includeActivities));

        //public async Task<bool> AddAsync(Module module) => await dataService.AddAsync(UriHelper.GetModulesUri(), module);

        //public async Task<bool> UpdateAsync(Module module) => await dataService.UpdateAsync(UriHelper.GetModuleUri(module.Id), module);

        //public async Task<bool> DeleteAsync(Guid id) => await dataService.DeleteAsync(UriHelper.GetModuleUri(id));

        //public async Task<List<Module>> GetModulesByCourseId(Guid id) => await dataService.GetAsync<List<Module>>($"modulesbycourse/{id}");
    }
}
