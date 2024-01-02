﻿using LMS_G7.Client.Services;
using LMS_G7.Shared;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class CourseView
    {
        [Inject]
        public ICourseDataService CourseDataService { get; set; }

        [Parameter]
        public int CourseId { get; set; }
        public Course Course { get; set; } = new Course();

        protected override void OnInitialized()
        {

            Course = CourseDataService.GetCourse(CourseId);
            base.OnInitialized();

        }
    }
}