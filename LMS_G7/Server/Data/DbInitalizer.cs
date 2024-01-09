using Bogus;
using LMS_G7.Shared.Domain;

namespace LMS_G7.Server.Data
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync(ApplicationDbContext context)
        {
            // Check if the database has been seeded
            if (context.Users.Any())
            {
                return; // Database has been seeded
            }

            // Seed fake data
            await SeedFakeDataAsync(context);
        }

        private static async Task SeedFakeDataAsync(ApplicationDbContext context)
        {
            var faker = new Faker();

            // Seed Users
            var users = GenerateFakeUsers(10);
            context.Users.AddRange(users);
            await context.SaveChangesAsync();

            // Seed Courses
            var courses = GenerateFakeCourses(3);
            context.Courses.AddRange(courses);
            await context.SaveChangesAsync();

            // Seed Modules
            var modules = GenerateFakeModules(courses);
            context.Modules.AddRange(modules);
            await context.SaveChangesAsync();

            // Seed ActivityTypes
            var activityTypes = GenerateFakeActivityTypes(4);
            context.ActivityTypes.AddRange(activityTypes);
            await context.SaveChangesAsync();

            // Seed Activities
            var activities = GenerateFakeActivities(modules, activityTypes);
            context.Activities.AddRange(activities);
            await context.SaveChangesAsync();

            // Seed Documents
            var documents = GenerateFakeDocuments(users, modules, activities);
            context.Documents.AddRange(documents);
            await context.SaveChangesAsync();
        }

        private static List<User> GenerateFakeUsers(int count)
        {
            var userFaker = new Faker<User>()
                .RuleFor(u => u.FirstName, faker => faker.Name.FirstName())
                .RuleFor(u => u.LastName, faker => faker.Name.LastName())
                .RuleFor(u => u.Email, (faker, user) => faker.Internet.Email(user.FirstName, user.LastName));

            return userFaker.Generate(count);
        }

        private static List<Course> GenerateFakeCourses(int count)
        {
            var courseFaker = new Faker<Course>()
                .RuleFor(c => c.Name, faker => faker.Lorem.Word())
                .RuleFor(c => c.Description, faker => faker.Lorem.Sentence())
                .RuleFor(c => c.StartDate, faker => faker.Date.Soon(30))
                .RuleFor(c => c.EndDate, (faker, course) => faker.Date.Between(course.StartDate, course.StartDate.AddDays(30)));

            return courseFaker.Generate(count);
        }

        private static List<Module> GenerateFakeModules(List<Course> courses)
        {
            var moduleFaker = new Faker<Module>()
                .RuleFor(m => m.Name, faker => faker.Lorem.Word())
                .RuleFor(m => m.Description, faker => faker.Lorem.Sentence())
                .RuleFor(m => m.StartDate, faker => faker.Date.Soon(30))
                .RuleFor(m => m.EndDate, (faker, module) => faker.Date.Between(module.StartDate, module.StartDate.AddDays(15)))
                .RuleFor(m => m.CourseId, faker => faker.PickRandom(courses).Id);

            return moduleFaker.Generate(courses.Count * 2);
        }

        private static List<ActivityType> GenerateFakeActivityTypes(int count)
        {
            var activityTypeFaker = new Faker<ActivityType>()
                .RuleFor(at => at.Type, faker => faker.Lorem.Word());

            return activityTypeFaker.Generate(count);
        }

        private static List<Activity> GenerateFakeActivities(List<Module> modules, List<ActivityType> activityTypes)
        {
            var activityFaker = new Faker<Activity>()
                .RuleFor(a => a.Name, faker => faker.Lorem.Word())
                .RuleFor(a => a.Description, faker => faker.Lorem.Sentence())
                .RuleFor(a => a.StartDate, faker => faker.Date.Soon(30))
                .RuleFor(a => a.EndDate, (faker, activity) => faker.Date.Between(activity.StartDate, activity.StartDate.AddDays(7)))
                .RuleFor(a => a.ModuleId, faker => faker.PickRandom(modules).Id)
                .RuleFor(a => a.ActivityTypeId, faker => faker.PickRandom(activityTypes).Id);

            return activityFaker.Generate(modules.Count * 3);
        }

        private static List<Document> GenerateFakeDocuments(List<User> users, List<Module> modules, List<Activity> activities)
        {
            var documentFaker = new Faker<Document>()
                .RuleFor(d => d.Name, faker => faker.System.FileName())
                .RuleFor(d => d.Description, faker => faker.Lorem.Sentence())
                .RuleFor(d => d.TimeStamp, faker => faker.Date.Soon(30))
                .RuleFor(d => d.UserId, faker => faker.PickRandom(users).Id)
                .RuleFor(d => d.ModuleId, faker => faker.PickRandom(modules).Id)
                .RuleFor(d => d.ActivityId, faker => faker.PickRandom(activities).Id);

            return documentFaker.Generate(users.Count * 2);
        }
    }
}
