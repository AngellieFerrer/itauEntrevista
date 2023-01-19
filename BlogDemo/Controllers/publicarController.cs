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
    public class publicarController : ControllerBase
    {
        public readonly ApplicationDbContext _context;
        public publicarController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<PublicarController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listBlogs = await _context.ApplicationBlogs.ToListAsync();
                return Ok(listBlogs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<PublicarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PublicarController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ApplicationPublish publish)
        {
            try
            {
                _context.Add(publish);
                await _context.SaveChangesAsync();
                return Ok(publish);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<PublicarController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] ApplicationPublish publish)
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
                if (finalId != publish.Id)
                {
                    return NotFound();
                }

                _context.Update(publish);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El blog se publicó correctamente!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<PublicarController>/5
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
                var blog = await _context.ApplicationBlogs.FindAsync(finalId);

                if (blog == null)
                {
                    return NotFound();
                }

                _context.Remove(blog);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El blog se marco para no publicarse y se eliminó!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
