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

        [Display(Name = "Descripcion del Punto de Interes")]
        [Required]
        [MaxLength(150, ErrorMessage = "Descripcion demasiada larga")]
        public string Descripcion { get; set; }


        [Display(Name = "Lugar de punto de interes")]
        [Required]
        [MaxLength(50, ErrorMessage = "Mucho texto")]
        public string Ubicacion { get; set; }


        [Display(Name = "Descripcion de tipo de actividad")]
        [Required]
        [MaxLength(50, ErrorMessage = "Mucho texto")]
        public string TipoActividad { get; set; }


        [Display(Name = "Hora de llegada al punto de interes")]
        [Required]
        [MaxLength(50, ErrorMessage = "Mucho texto")]
        [DisplayFormat(DataFormatString = "{0:hh:mm}")]
        public DateTime HorarioEstimado { get; set; }


        [JsonIgnore]
        public Proveedor Proveedor { get; set; }

        [JsonIgnore]
        public ICollection<Calificacion> Calificaciones { get; set; }

        [JsonIgnore]
        public Ruta Ruta { get; set; }
    }
}
