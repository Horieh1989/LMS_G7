namespace LMS_G7.Shared.Domain
{

    public class ActivityModel
    {
        public Guid Id { get; set; }
        public ActivityType Type { get; set; } = new ActivityType();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid ModuleId { get; set; }
        public Module? Module { get; set; }
    }

}
