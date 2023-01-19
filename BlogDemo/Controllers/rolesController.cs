using BlogDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class rolesController : ControllerBase
    {
        public readonly ApplicationDbContext _context;
        public rolesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Get()
        {
            try
            {
                var listRols = await _context.ApplicationRole.ToListAsync();
                return Ok(listRols);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<blogController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<blogController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ApplicationRole rol)
        {
            try
            {
                _context.Add(rol);
                await _context.SaveChangesAsync();
                return Ok(rol);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<blogController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] ApplicationRole rol)
        {
            int finalId = 0;
            try
            {
                finalId = int.Parse(id);
            }
            catch (Exception ex)
            {
            }
            try
            {
                if (finalId != rol.id)
                {
                    return NotFound();
                }

                _context.Update(rol);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El rol se actualizo correctamente!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<blogController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            int finalId = 0;
            try
            {
                finalId = int.Parse(id);
            }
            catch (Exception ex)
            {
            }
            try
            {
                var rol = await _context.ApplicationRole.FindAsync(finalId);

                if (rol == null)
                {
                    return NotFound();
                }

                _context.Remove(rol);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El rol se elimino correctamente!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
