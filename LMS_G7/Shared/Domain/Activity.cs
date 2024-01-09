using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace LMS_G7.Shared.Domain
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [StringLength(15, ErrorMessage = "Activity name should be between {2} and {1}", MinimumLength = 2)]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Foreign Keys
        public int ModuleId { get; set; }
        public int ActivityTypeId { get; set; }

        //Navigation Properties
        public Module Module { get; set; }
        public ActivityType ActivityType { get; set; }
        public ICollection<Document> Documents { get; set; }
    }

}
