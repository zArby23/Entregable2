using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CulturaVivaTours.Shared.Entites
{
    public class PuntoInteres
    {
      
        public int id { get; set; }//Primary key






        //Conexion con la tabla calificacion
        [JsonIgnore]
        public ICollection<Calificacion> Calificacions{ get; set; }

    }
}
