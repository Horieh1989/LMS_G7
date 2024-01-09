using LMS_G7.Server.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LMS_G7.Server.Extensions
{
    public static class DbInitializerExtension
    {
        public static void InitializeDatabase(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<ApplicationDbContext>();

                context.Database.EnsureCreated(); // Ensure the database is created

                // Call your DbInitializer to seed data
                DbInitializer.InitializeAsync(context).Wait();
            }
        }
    }
}
