using Botones.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Botones.Models;
using Microsoft.AspNetCore.Cors;

namespace Botones.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/[controller]")]
    [ApiController]
    public class BotonesController : ControllerBase
    {
        private readonly ButtonContext _context;
        public BotonesController(ButtonContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAllButton")]
        public async Task<ActionResult<IEnumerable<Boton>>> GetButtons()
        {
            return await _context.Botones.ToListAsync();
        }

        [HttpPost]
        [Route("AddButton")]
        public async Task<ActionResult> CreateButton()
        {
            Boton boton = new Boton();
            _context.Add(boton);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPatch]
        [Route("AddClickButton")]
        public async Task<ActionResult> UpdateButton(int id)
        {
            var button = await _context.Botones.FindAsync(id);
            if (button == null)
            {
                return NotFound();
            }
            button.Contador += 1;
            _context.Update(button);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteButton")]
        public async Task<ActionResult> DeleteButton(int id)
        {
            var button = await _context.Botones.FindAsync(id);
            if (button == null)
            {
                return NotFound();
            }
            _context.Remove(button);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
