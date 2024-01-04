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
        public DbSet<Activity> Activities { get; set; }
        // public IEnumerable<ActivityModel> Activities { get; internal set; }

    }
}
