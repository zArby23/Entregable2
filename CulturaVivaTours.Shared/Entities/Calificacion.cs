using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CulturaVivaTours.Shared.Entities
{
    public class Calificacion
    {
      
        public int Id { get; set; }//Primary key

        [Display(Name = "Puntuacion del turista")]
        [Required]
        [MaxLength(40, ErrorMessage = "Nacionalidad Demasiado largo")]
        public string Grade { get; set; }

        [Display(Name = "Comentario del turista")]
        [Required]
        [MaxLength(40, ErrorMessage = "Idioma Demasiado largo")]
        public string Comment { get; set; }

        [JsonIgnore]
        public PuntoInteres PuntoInteres { get; set; }

        [JsonIgnore]
        public Turista Turista { get; set; }

    }
}
