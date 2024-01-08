using Microsoft.EntityFrameworkCore;

namespace LMS_G7.Server.Data
{
    public class SeedData
    {
        public static async Task InitAsync(ApplicationDbContext db)
        {
            if (await db.Users.AnyAsync()) return;
        }
    }
}
