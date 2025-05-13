using CulturaVivaTours.API.Data;
using CulturaVivaTours.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CulturaVivaTours.API.Controllers
{
    [ApiController]
    [Route("/api/Turistas")]
    public class TuristasController:ControllerBase
    {
        private readonly DataContext _Context;

        public TuristasController(DataContext context)
        {
            _Context = context;
        }

        //Get para obtener una lista de resultados

        [HttpGet]
        public async Task<ActionResult> Get() //select * from table
        {
            return Ok(await _Context.Turistas.ToListAsync());//200
        }



        //Get por parametro

        [HttpGet("{id:int}")]//Busca con un parametro de entrada
        public async Task<ActionResult> Get(int id) //select * from table where...
        {
            var turista = await _Context.Turistas.FirstOrDefaultAsync(x => x.Id == id);

            if (turista == null)
            {
                return NotFound();//404

            }

            return Ok(turista);//200

        }

        //Inserta datos
        [HttpPost]
        public async Task<ActionResult> Post(Turista turista)
        {

            _Context.Turistas.Add(turista);

            await _Context.SaveChangesAsync();

            return Ok(turista);


        }

        //Actualizar datos

        [HttpPut]
        public async Task<ActionResult> Put(Turista turista)
        {

            _Context.Turistas.Update(turista);

            await _Context.SaveChangesAsync();

            return Ok(turista); //200


        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id) //select * from table where...
        {
            var FilasAfectadas = await _Context.Turistas

                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();




            if (FilasAfectadas == 0)
            {
                return NotFound();//404

            }

            return NoContent();//204

        }









    }//Fin clase
}//Fin
