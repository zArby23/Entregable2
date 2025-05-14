using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CulturaVivaTours.Shared.Entities
{
    public class Ruta
    {
        public int Id { get; set; }

        [Display(Name = "Ingrese el nombre de la ruta.")]
        [Required]
        [MaxLength(20,ErrorMessage = "No debe haber un nombre de mas de 20 caracteres.")]
        public string FirstName { get; set; }

        [Display(Name = "Region de la ruta.")]
        [Required]
        [MaxLength(20, ErrorMessage = "Digite una region de menos de 20 caracteres.")]
        public string Region { get; set; }

        [Display(Name = "Cuanto dura en horas.")]
        [Required]
        [Range(0,96)]
        public int Time { get; set; }

        [Display(Name = "Tipo de experiencia de la ruta.")]
        [Required]
        [MaxLength(20,ErrorMessage = "El tipo de experiencia debe ser de menos de 20 caracteres.")]
        public string Experience { get; set; }

        [Display(Name = "Ingrese el idioma que se hablara durante la ruta.")]
        [Required]
        [MaxLength(20,ErrorMessage = "Ingrese una lengua de menos de 20 caracteres.")]
        public string Language { get; set; }

        [JsonIgnore]
        public ICollection<RutaAsignada> RutasAsignadas { get; set; }

        [JsonIgnore]
        public ICollection<PuntoInteres> PuntosInteres { get; set; }
    }
}
