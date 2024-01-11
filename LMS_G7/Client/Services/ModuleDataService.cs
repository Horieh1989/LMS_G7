using LMS_G7.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LMS_G7.Client.Services
{
    public class ModuleDataService : IModuleDataService
    {
        public List<Module> Modules { get; set; } = new List<Module>();

        public ModuleDataService()
        {
            // Seeding some initial data for modules
            Modules.Add(new Module
            {
                Id = 1,
                Name = "Introduction to C#",
                Description = "A basic overview of C# in the course.",
                StartDate = DateTime.Now.AddDays(1),
                EndDate = DateTime.Now.AddDays(15),
                CourseId = 1
            });

            Modules.Add(new Module
            {
                Id = 2,
                Name = "ASP .NET Core MVC",
                Description = "Exploring advanced concepts within the MVC .",
                StartDate = DateTime.Now.AddDays(10),
                EndDate = DateTime.Now.AddDays(30),
                CourseId = 1
            });

            // Add more modules if necessary
        }

        public List<Module> GetModules()
        {
            return Modules;
        }

        public Module GetModule(int id)
        {
            return Modules.FirstOrDefault(x => x.Id == id);
        }

        public void DeleteModule(int id)
        {
            var module = Modules.FirstOrDefault(x => x.Id == id);

            if (module != null)
                Modules.Remove(module);
        }

        public void UpdateModule(Module module)
        {
            var updatedModule = Modules.FirstOrDefault(m => m.Id == module.Id);
            if (updatedModule != null)
            {
                updatedModule.Name = module.Name;
                updatedModule.Description = module.Description;
                updatedModule.StartDate = module.StartDate;
                updatedModule.EndDate = module.EndDate;
                updatedModule.CourseId = module.CourseId;
            }
        }

        public void AddModule(Module module)
        {
            Random rnd = new Random();
            module.Id = rnd.Next(1000);
            Modules.Add(module);
        }
    }
}
