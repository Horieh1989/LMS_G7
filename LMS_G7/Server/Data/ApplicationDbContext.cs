using Duende.IdentityServer.EntityFramework.Options;
using LMS_G7.Server.Models;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LMS_G7.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<ActivityModel> ActivityModels { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration for ActivityModel entity
            modelBuilder.Entity<ActivityModel>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<ActivityModel>()
                .HasOne(a => a.Module)
                .WithMany(m => m.Activities)
                .HasForeignKey(a => a.ModuleId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ActivityModel>()
                .HasOne(a => a.Type)
                .WithMany()
                .HasForeignKey(a => a.Type.Name)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuration for Course entity
            modelBuilder.Entity<Course>()
                .HasKey(c => c.CourseId);

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Modules)
                .WithOne(m => m.Course)
                .HasForeignKey(m => m.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuration for Module entity
            modelBuilder.Entity<Module>()
                .HasKey(m => m.ModuleId);

            modelBuilder.Entity<Module>()
                .HasOne(m => m.Course)
                .WithMany(c => c.Modules)
                .HasForeignKey(m => m.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuration for User entity
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Course)
                .WithMany(c => c.Users)
                .HasForeignKey(u => u.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Add other configurations as needed

            base.OnModelCreating(modelBuilder);
        }


    }
}
