using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CulturaVivaTours.API.Data;
using CulturaVivaTours.Shared.Entities;
using System;
namespace CulturaVivaTours.API.Controllers
{
    [ApiController]
    [Route("/api/puntosinteres")]
    public class PuntosInteresController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PuntosInteresController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // Get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _dataContext.PuntosInteres.ToListAsync());
        }

        // Get(id)
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var puntoi = await _dataContext.PuntosInteres.FirstOrDefaultAsync(x => x.id == id);

            if (puntoi == null)
            {
                return NotFound();
            }
            return Ok(puntoi);
        }

        // Post
        [HttpPost]
        public async Task<ActionResult> Post(PuntoInteres puntoi)
        {
            _dataContext.PuntosInteres.Add(puntoi);
            await _dataContext.SaveChangesAsync();
            return Ok(puntoi);
        }

        // Put
        [HttpPut]
        public async Task<ActionResult> Put(PuntoInteres puntoi)
        {
            _dataContext.PuntosInteres.Update(puntoi);
            await _dataContext.SaveChangesAsync();
            return Ok(puntoi);
        }

        // Delete(id)
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAfectadas = await _dataContext.PuntosInteres
                .Where(x => x.id == id)
                .ExecuteDeleteAsync();

            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
