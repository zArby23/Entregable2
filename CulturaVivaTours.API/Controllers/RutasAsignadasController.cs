using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CulturaVivaTours.API.Data;
using CulturaVivaTours.Shared.Entities;

namespace CulturaVivaTours.API.Controllers
{
    [ApiController]
    [Route("/api/rutasasignadas")]
    public class RutasAsignadasController:ControllerBase
    {
        private readonly DataContext _dataContext;

        public RutasAsignadasController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // Get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _dataContext.RutasAsignadas.ToListAsync());
        }

        // Get(id)
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var rutaAsignada = await _dataContext.RutasAsignadas.FirstOrDefaultAsync(x=>x.Id == id);
            
            if (rutaAsignada == null)
            {
                return NotFound();
            }
            return Ok(rutaAsignada);
        }

        // Post
        [HttpPost]
        public async Task<ActionResult> Post(RutaAsignada rutaAsignada)
        {
            _dataContext.RutasAsignadas.Add(rutaAsignada);
            await _dataContext.SaveChangesAsync();
            return Ok(rutaAsignada);
        }

        // Put
        [HttpPut]
        public async Task<ActionResult> Put(RutaAsignada rutaAsignada)
        {
            _dataContext.RutasAsignadas.Update(rutaAsignada);
            await _dataContext.SaveChangesAsync();
            return Ok(rutaAsignada);
        }

        // Delete(id)
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAfectadas = await _dataContext.RutasAsignadas
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
