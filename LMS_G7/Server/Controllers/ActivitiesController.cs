using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LMS_G7.Server.Data;
using LMS_G7.Shared.Domain;

namespace LMS_G7.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ActivitiesController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetAllActivity()
        {
            var list = await _context.Activities.ToListAsync();
            return Ok(list);
        }

        [HttpGet("{id}")]
        //[Route("GetAllCoursesAndAllActivities")]
        public async Task<ActionResult<Activity>> GetActivity(int id)
        {
            var activity = await _context.Activities.FindAsync(id);

            if (activity == null)
            {
                return NotFound("This Activity does not exist");
            }
            return Ok(activity);
        }

        [HttpPost]
        public async Task<ActionResult<Activity>> AddActivity(Activity activity)
        {
            var result = await _context.Activities.AddAsync(activity);
            //var resultSave = _context.SaveChangesAsync();
            await _context.SaveChangesAsync();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Activity>>> UpdateActivity(int id, Activity activity)
        {
            var result = await _context.Activities.FindAsync(id);
            if (result == null)
            {
                return NotFound("This User does not exist1");
            }

            result.Name = activity.Name;
            result.StartDate = activity.StartDate;
            result.EndDate = activity.EndDate;
            result.ModuleId = activity.ModuleId;

            await _context.SaveChangesAsync();
            return await GetAllActivity();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Activity>>> DeleteActivity(int id)
        {
            var result = await _context.Activities.FindAsync(id);
            if (result == null)
            {
                return NotFound("This Activity does not exist1");
            }
            _context.Activities.Remove(result);
            await _context.SaveChangesAsync();
            return await GetAllActivity();
        }


    }
}
