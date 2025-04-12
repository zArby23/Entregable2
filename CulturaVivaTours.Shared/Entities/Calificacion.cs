using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CulturaVivaTours.Shared.Entites
{
    public class Calificacion
    {
      
        public string id { get; set; }//Primary key


        public string FullName { get; set; }


        [Display(Name = "Puntuacion del turista")]
        [Required]
        [MaxLength(40, ErrorMessage = "Nacionalidad Demasiado largo")]
        public string Puntuation { get; set; }

        [Display(Name = "Comentario del turista")]
        [Required]
        [MaxLength(40, ErrorMessage = "Idioma Demasiado largo")]
        public string Coment { get; set; }

        [JsonIgnore]
        public PuntoInteres PuntoInteres { get; set; }

        [JsonIgnore]
        public Turista Turista { get; set; }

 




    }
}
