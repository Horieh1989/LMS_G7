using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using LMS_G7.Shared.Domain;

namespace LMS_G7.Server.Data
{
    public static class DbInitializer
    {
        private static readonly Faker Faker = new Faker();

        public static void Initialize(ApplicationDbContext context)
        {
            InitializeCourses(context);
            InitializeModules(context);
            //InitializeActivityTypes(context);
            InitializeActivityModels(context);
            InitializeUsers(context);
        }

        private static void InitializeCourses(ApplicationDbContext context)
        {
            if (context.Courses.Any())
            {
                return; // Database has been seeded
            }

            var courses = new List<Course>();

            for (int i = 0; i < 3; i++)
            {
                courses.Add(new Course
                {
                   // Name = Faker.Commerce.ProductName(),
                    Description = Faker.Lorem.Sentence(),
                    StartDate = Faker.Date.Future(),
                    EndDate = Faker.Date.Future(),
                });
            }

            context.Courses.AddRange(courses);
            context.SaveChanges();
        }

        private static void InitializeModules(ApplicationDbContext context)
        {
            if (context.Modules.Any())
            {
                return; // Database has been seeded
            }

            var modules = new List<Module>();

            foreach (var course in context.Courses.ToList())
            {
                for (int i = 0; i < 3; i++)
                {
                    modules.Add(new Module
                    {
                        Name = Faker.Lorem.Word(),
                        Description = Faker.Lorem.Sentence(),
                        StartDate = Faker.Date.Future(),
                        EndDate = Faker.Date.Future(),
                        CourseId = course.Id,
                    });
                }
            }

            context.Modules.AddRange(modules);
            context.SaveChanges();
        }

        //private static void InitializeActivityTypes(ApplicationDbContext context)
        //{
        //    if (context.ActivityTypes.Any())
        //    {
        //        return; // Database has been seeded
        //    }

        //    var activityTypes = new List<ActivityType>
        //    {
        //        new ActivityType { Name = "E-Learning" },
        //        new ActivityType { Name = "Lecture" },
        //        new ActivityType { Name = "Practice session" },
        //        new ActivityType { Name = "Assignment" },
        //    };

        //    context.ActivityTypes.AddRange(activityTypes);
        //    context.SaveChanges();
        //}

        private static void InitializeActivityModels(ApplicationDbContext context)
        {
            if (context.Activities.Any())
            {
                return; // Database has been seeded
            }

            var activityModels = new List<Activity>();

            foreach (var module in context.Modules.ToList())
            {
                for (int i = 0; i < 3; i++)
                {
                    activityModels.Add(new Activity
                    {
                        Name = Faker.Lorem.Word(),
                        Description = Faker.Lorem.Sentence(),
                        StartDate = Faker.Date.Future(),
                        EndDate = Faker.Date.Future(),
                        ModuleId = module.Id,
                       // ActivityType = context.Activities.ToList().Random(),
                    });
                }
            }

            context.Activities.AddRange(activityModels);
            context.SaveChanges();
        }

        private static void InitializeUsers(ApplicationDbContext context)
        {
            if (context.Users.Any())
            {
                return; // Database has been seeded
            }

            var users = new List<User>();

            foreach (var course in context.Courses.ToList())
            {
                for (int i = 0; i < 3; i++)
                {
                    users.Add(new User
                    {
                        FirstName = Faker.Name.FirstName(),
                        LastName = Faker.Name.LastName(),
                        Email = Faker.Internet.Email(),
                        CourseId = course.Id,
                    });
                }
            }

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
