using LMS_G7.Shared.Domain;

namespace LMS_G7.Client.Services
{
    public interface IModuleDataService
    {
        List<Module> GetModules();
        Module GetModule(int Id);
        void DeleteModule(int Id);
        void UpdateModule(Module module);
        void AddModule(Module module);

        //Task<Module?> GetAsync();
        //Task<List<Module>> GetModulesByCourseId(Guid id);
        //Task<Module?> GetAsync(Guid id, bool includeActivities = false);
        //Task<bool> AddAsync(Module module);
        //Task<bool> UpdateAsync(Module module);
        //Task<bool> DeleteAsync(Guid id);
    }
}