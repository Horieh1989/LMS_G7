﻿using LMS_G7.Client.Services;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class CourseView
    {
        [Inject]
        public ICourseDataService CourseDataService { get; set; }

        [Parameter]
        public int Id { get; set; }
        public Course Course { get; set; } = new Course();

        protected override void OnInitialized()
        {

            Course = CourseDataService.GetCourse(Id);
            base.OnInitialized();

        }
    }
}
