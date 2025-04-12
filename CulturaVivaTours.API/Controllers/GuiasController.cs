using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CulturaVivaTours.API.Data;
using CulturaVivaTours.Shared.Entities;

namespace CulturaVivaTours.API.Controllers
{
    [ApiController]
    [Route("/api/guias")]
    public class GuiasController:ControllerBase
    {
        private readonly DataContext _dataContext;

        public GuiasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // Get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _dataContext.Guias.ToListAsync());
        }

        // Get(id)
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var guia = await _dataContext.Guias.FirstOrDefaultAsync(x=>x.Id == id);
            
            if (guia == null)
            {
                return NotFound();
            }
            return Ok(guia);
        }

        // Post
        [HttpPost]
        public async Task<ActionResult> Post(Guia guia)
        {
            _dataContext.Guias.Add(guia);
            await _dataContext.SaveChangesAsync();
            return Ok(guia);
        }

        // Put
        [HttpPut]
        public async Task<ActionResult> Put(Guia guia)
        {
            _dataContext.Guias.Update(guia);
            await _dataContext.SaveChangesAsync();
            return Ok(guia);
        }

        // Delete(id)
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAfectadas = await _dataContext.Guias
                .Where(x=>x.Id==id)
                .ExecuteDeleteAsync();

            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
