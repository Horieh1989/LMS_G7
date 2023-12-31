﻿using LMS_G7.Server.Data;
using LMS_G7.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LMS_G7.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActivityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ActivityController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Activity> GetActivities()
        {
            return _context.Activities;
        }

        [HttpPost]
        public IActionResult AddActivity(Activity activity)
        {
            _context.Activities.Add(activity);
            _context.SaveChanges();

            return Ok(activity); // Return the added activity with an HTTP 200 OK status
        }
    }
}

