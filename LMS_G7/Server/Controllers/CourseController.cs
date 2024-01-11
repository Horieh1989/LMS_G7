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
        // create new instance our course
        public async Task<ActionResult<Course>> AddCourse(Course course)
        {
            var resultCourse = await _context.Courses.AddAsync(course);
            var resultSave = _context.SaveChangesAsync();

            return Ok(resultCourse);
        }
        [HttpPut("{id}")]
        //update
        public async Task<ActionResult<List<Course>>> UpdateCourse(int id, Course course)

        {
            var resault = await _context.Courses.FindAsync(id);
            if (resault == null)
            {
                return NotFound("this course does not exist");
            }

            resault.StartDate = course.StartDate;
            resault.EndDate = course.EndDate;
            resault.Description = course.Description;
            resault.Name = course.Name;

            await _context.SaveChangesAsync();
            return await GetAllCourses();

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Course>>> DeleteUser(int id)
        {

            var result = await _context.Courses.FindAsync(id);
            if (result == null)
            {
                return NotFound("this course does not exist");
            }
            _context.Courses.Remove(result);
            await _context.SaveChangesAsync();
            return await GetAllCourses();

        }

    }
}