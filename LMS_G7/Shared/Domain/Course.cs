﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Reflection;

#nullable disable
namespace LMS_G7.Shared.Domain
{
    //public enum Name
    //{
    //    DotNetProgramming,
    //    SupportTeknik,
    //    Systemdeveloper
    //}

    public class Course
    {
        public int Id { get; set; }
        //[DisplayName("course name")]
        //[StringLength(20)]
        public string Name { get; set; }
        public string Description { get; set; }

        [DisplayName("Time of starting ")]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Navigation Properties
        public ICollection<User> Users { get; set; }
        public ICollection<Module> Modules { get; set; }
    }

}

