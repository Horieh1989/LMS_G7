using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LMS_G7.Server.Data;
using LMS_G7.Shared.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LMS_G7.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ModuleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Module
        [HttpGet]
        public async Task<ActionResult<List<Module>>> GetModules()
        {
            var modules = await _context.Modules.ToListAsync();
            return Ok(modules);
        }

        // GET: api/Module/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Module>> GetModule(int id)
        {
            var module = await _context.Modules.FirstOrDefaultAsync(m => m.Id == id);

            if (module == null)
            {
                return NotFound();
            }

            return Ok(module);
        }

        // POST: api/Module
        [HttpPost]
        public async Task<ActionResult<Module>> AddModule(Module module)
        {
            var resultModule = await _context.Modules.AddAsync(module);
            await _context.SaveChangesAsync();

            return Ok(resultModule.Entity);
        }

        // PUT: api/Module/1
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateModule(int id, Module module)
        {
            if (id != module.Id)
            {
                return BadRequest();
            }

            _context.Entry(module).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Module/1
        [HttpDelete("{id}")]
        public async Task<ActionResult<Module>> DeleteModule(int id)
        {
            var module = await _context.Modules.FindAsync(id);
            if (module == null)
            {
                return NotFound();
            }

            _context.Modules.Remove(module);
            await _context.SaveChangesAsync();

            return Ok(module);
        }

        private bool ModuleExists(int id)
        {
            return _context.Modules.Any(e => e.Id == id);
        }
    }
}
