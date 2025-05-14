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
        [Range(0.0,5.0, ErrorMessage = "Ingrese una nota entre 0.0 y 5.0")]
        public double Grade { get; set; }

        [Display(Name = "Comentario del turista")]
        [Required]
        [MaxLength(40, ErrorMessage = "Comentario demasiado largo")]
        public string Comment { get; set; }

        [JsonIgnore]
        public PuntoInteres PuntoInteres { get; set; }
        public int PuntoInteresId { get; set; }

        [JsonIgnore]
        public Turista Turista { get; set; }
        public int TuristaId { get; set; }

    }
}
