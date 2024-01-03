using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_G7.Shared.Domain
{
    

    public class ActivityModel
    {
        public string Name { get; set; }
        public string ActivityType { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

}
