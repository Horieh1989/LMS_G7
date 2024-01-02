﻿using LMS_G7.Client.Services;
using LMS_G7.Shared;
using Microsoft.AspNetCore.Components;

namespace LMS_G7.Client.Pages
{
    public partial class CourseAdd
    {
        [Inject]
        ICourseDataService CourseDataService { get; set; }


        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public Course course { get; set; } = new Course();
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        protected async Task HandleValidSubmit()
        {
            CourseDataService.AddCourse(course);
            NavigationManager.NavigateTo($"/CourseLst");
        }
    }
}