﻿using CulturaVivaTours.API.Data;
using CulturaVivaTours.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CulturaVivaTours.API.Controllers
{
  

        [ApiController]
        [Route("/api/Calificaciones")]
        public class CalificacionesController : ControllerBase
        {
            private readonly DataContext _Context;

            public CalificacionesController(DataContext context)
            {
                _Context = context;
            }

            //Get para obtener una lista de resultados

            [HttpGet]
            public async Task<ActionResult> Get() //select * from table
            {
                return Ok(await _Context.Calificaciones.ToListAsync());//200
            }



            //Get por parametro

            [HttpGet("{id:int}")]//Busca con un parametro de entrada
            public async Task<ActionResult> Get(int id) //select * from table where...
            {
                var Calificacions = await _Context.Calificaciones.FirstOrDefaultAsync(x => x.Id == id);

                if (Calificacions == null)
                {
                    return NotFound();//404

                }

                return Ok(Calificacions);//200

            }

            //Inserta datos
            [HttpPost]
            public async Task<ActionResult> Post(Calificacion calificacion)
            {

                _Context.Calificaciones.Add(calificacion);

                await _Context.SaveChangesAsync();

                return Ok(calificacion);


            }

            //Actualizar datos

            [HttpPut]
            public async Task<ActionResult> Put(Calificacion calificacion)
            {

                _Context.Calificaciones.Update(calificacion);

                await _Context.SaveChangesAsync();

                return Ok(calificacion); //200


            }


            [HttpDelete("{id:int}")]
            public async Task<ActionResult> Delete(int id) //select * from table where...
            {
                var FilasAfectadas = await _Context.Calificaciones

                    .Where(x => x.Id == id)
                    .ExecuteDeleteAsync();




                if (FilasAfectadas == 0)
                {
                    return NotFound();//404

                }

                return NoContent();//204

            }









        }//Fin clase



    }

