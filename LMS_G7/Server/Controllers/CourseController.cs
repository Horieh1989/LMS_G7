using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LMS_G7.Server.Data;
using LMS_G7.Shared.Domain;

namespace LMS_G7.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Courses
        [HttpGet]
        //[Route("GetAllCoursesAndAllActivities")]
        public async Task<ActionResult<List<Course>>> GetAllCourses()
        {
            var list = await _context.Courses.ToListAsync();
            return Ok(list);
        }

        [HttpGet("{Id}")]
        //[Route("GetAllCoursesAndAllActivities")]
        public async Task<ActionResult<Course>> GetCourse(int Id)
        {
            var course = await _context.Courses.FirstOrDefaultAsync(c => c.Id == Id);
            return Ok(course);
        }

        [HttpPost]
        public async Task<ActionResult<Course>> AddCourse(Course course)
        {
            var resultCourse = await _context.Courses.AddAsync(course);
            var resultSave = _context.SaveChangesAsync();

            return Ok(resultCourse);
        }

    }
}