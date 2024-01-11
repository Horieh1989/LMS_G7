using LMS_G7.Shared.Domain;

namespace LMS_G7.Client.Services
{
    public interface IModuleDataService
    {
        List<Module> GetModules();
        Module GetModule(int id);
        void DeleteModule(int id);
        void UpdateModule(Module module);
        void AddModule(Module module);
    }
}