using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CulturaVivaTours.API.Data;
using CulturaVivaTours.Shared.Entities;

namespace CulturaVivaTours.API.Controllers
{
    [ApiController]
    [Route("/api/rutas")]
    public class RutasController:ControllerBase
    {
        private readonly DataContext _dataContext;

        public RutasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // Get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _dataContext.Rutas.ToListAsync());
        }

        // Get(id)
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var ruta = await _dataContext.Rutas.FirstOrDefaultAsync(x=>x.Id == id);
            
            if (ruta == null)
            {
                return NotFound();
            }
            return Ok(ruta);
        }

        // Post
        [HttpPost]
        public async Task<ActionResult> Post(Ruta ruta)
        {
            _dataContext.Rutas.Add(ruta);
            await _dataContext.SaveChangesAsync();
            return Ok(ruta);
        }

        // Put
        [HttpPut]
        public async Task<ActionResult> Put(Ruta ruta)
        {
            _dataContext.Rutas.Update(ruta);
            await _dataContext.SaveChangesAsync();
            return Ok(ruta);
        }

        // Delete(id)
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAfectadas = await _dataContext.Rutas
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
