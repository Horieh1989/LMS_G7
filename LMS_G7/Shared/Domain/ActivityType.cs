using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace LMS_G7.Shared.Domain
{
    public class ActivityType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        //Navigation Prop.
        public ICollection<Activity> Activities { get; set; }
    }
}
