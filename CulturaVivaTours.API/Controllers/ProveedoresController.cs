using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CulturaVivaTours.API.Data;
using CulturaVivaTours.Shared.Entities;
using System;

namespace CulturaVivaTours.API.Controllers
{
    [ApiController]
    [Route("/api/proveedores")]
    public class Proveedores : ControllerBase
    {
        private readonly DataContext _dataContext;

        public Proveedores(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        // Get
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _dataContext.Proveedores.ToListAsync());
        }

        // Get(id)
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var proveedor = await _dataContext.Proveedores.FirstOrDefaultAsync(x => x.Id == id);

            if (proveedor == null)
            {
                return NotFound();
            }
            return Ok(proveedor);
        }

        // Post
        [HttpPost]
        public async Task<ActionResult> Post(Proveedor pro)
        {
            _dataContext.Proveedores.Add(pro);
            await _dataContext.SaveChangesAsync();
            return Ok(pro);
        }

        // Put
        [HttpPut]
        public async Task<ActionResult> Put(Proveedor pro)
        {
            _dataContext.Proveedores.Update(pro);
            await _dataContext.SaveChangesAsync();
            return Ok(pro);
        }

        // Delete(id)
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filasAfectadas = await _dataContext.Proveedores
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (filasAfectadas == 0)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
