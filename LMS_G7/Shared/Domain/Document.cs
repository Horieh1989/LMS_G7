using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace LMS_G7.Shared.Domain
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TimeStamp { get; set; }

        //Foreign Keys
        public int? UserId { get; set; }
        public int? ModuleId { get; set; }
        public int? ActivityId { get; set; }

        //Navigation Properties
        public User User { get; set; }
        public Module Module { get; set; }
        public Activity Activity { get; set; }

    }
}
