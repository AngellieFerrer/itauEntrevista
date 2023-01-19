using BlogDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class usuariosController : ControllerBase
    {
        public readonly ApplicationDbContext _context;

        public usuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        //POST: api/usuarios/registro

        [HttpPost]
        [Route("registro")]
        public async Task<IActionResult> registro([FromBody] ApplicationUserRegisterModel usuario)
        {
            try
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();

                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> login(ApplicationUserRegisterModel usuario)
        {
            try
            {
                IList<ApplicationUserRegisterModel> usarioAbuscar = _context.ApplicationRegistro.Where(s => s.Email == usuario.Email).ToList();

                if (usarioAbuscar == null)
                {
                    return NotFound();
                }

                return Ok(new { message = "El usuario existe!", optionId = usarioAbuscar[0].OptionId });
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> delete(ApplicationUserRegisterModel usuario)
        {
            var usarioAbuscar = await _context.ApplicationRegistro.FindAsync(usuario);
            if (usarioAbuscar == null)
            {
                return NotFound();
            }

            try
            {
                _context.Remove(usuario);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El usuario se elimino correctamente!" });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
