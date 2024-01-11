using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace LMS_G7.Client.Components
{
    public partial class CourseList
    {
        [Parameter]
       
        [Inject]
        public HttpClient HttpClient { get; set; }

        public List<Course> CourseLst { get; set; } = new List<Course>();

        //protected override async Task OnInitializedAsync()
        //{
        //   var course  = await Http.GetFromJsonAsync<List<Course>>("api/course");
        //    if (course == null) {
        //        course = CourseLst;
        //    }
           
        //}
    }
}
