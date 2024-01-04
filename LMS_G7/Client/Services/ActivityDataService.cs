using LMS_G7.Shared.Domain;

namespace LMS_G7.Client.Services
{
    public class ActivityDataService: IActivityDataService
    {
       
            public List<Activity> activty { get; set; } = new List<Activity>();

        public ActivityDataService()
            {
            activty.Add(new Activity()
                {
                    Id = 1,
                    Name = "Activty1",
                    Description = "Activty1",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(+10),
                });
            activty.Add(new Activity()
            {
                Id = 1,
                Name = "Activty2",
                Description = "Activty2",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(+10),
            });
            activty.Add(new Activity()
            {
                Id = 1,
                Name = "Activty3",
                Description = "Activty3",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(+10),
            });
        }
            public List<Activity> GetActivity()
            {
                return activty;
            }

            public Activity GetActivity(int id)
            {
                return activty.FirstOrDefault(x => x.Id == id);
            }

            public void DeleteActivity(int id)
            {
                var _activity = activty.FirstOrDefault(x => x.Id == id);

                if (_activity != null)
                    activty.Remove(_activity);
            }

            public void UpdateActivity(Activity _activity)
            {
                var updatedActivity = activty.FirstOrDefault(u => u.Id == _activity.Id);
                if (updatedActivity != null)
                {
                updatedActivity.Name = _activity.Name;
                updatedActivity.Description = _activity.Description;
                updatedActivity.StartDate = _activity.StartDate;
                updatedActivity.EndDate = _activity.EndDate;
                }
            }

            public void AddActivity(Activity _activity)
        {
                Random rnd = new Random();
            _activity.Id = rnd.Next(1000);
                activty.Add(_activity);
            }
        }
    }



