using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_G7.Shared.Domain
{
    public class ActivityType
    {
        [Key]
        public string Name { get; set; } = string.Empty;
    }
}
