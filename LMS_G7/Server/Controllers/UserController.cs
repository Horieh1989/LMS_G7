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
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var list = await _context.Users.ToListAsync();
            return Ok(list);
        }


        [HttpGet("{id}")]
        //[Route("GetAllCoursesAndAllActivities")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound("This User does not exist1");
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            var result = await _context.Users.AddAsync(user);
            //var resultSave = _context.SaveChangesAsync();
            await _context.SaveChangesAsync();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(int id, User user)
        {
            var result = await _context.Users.FindAsync(id);
            if (result == null)
            {
                return NotFound("This User does not exist1");
            }

            result.FirstName = user.FirstName;
            result.LastName = user.LastName;
            result.Email = user.Email;
            result.CourseId = user.CourseId;

            await _context.SaveChangesAsync();
            return await GetAllUsers();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(int id)
        {
            var result = await _context.Users.FindAsync(id);
            if (result == null)
            {
                return NotFound("This User does not exist1");
            }
            _context.Users.Remove(result);
            await _context.SaveChangesAsync();
            return await GetAllUsers();
        }
    }
}
