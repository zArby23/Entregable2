using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CulturaVivaTours.Shared.Entities
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Display(Name = "Descripcion del proveedor")]
        [Required]
        [MaxLength(150, ErrorMessage = "Descripcion demasiada larga")]
        public string NombreProveedor { get; set; }

        [Display(Name = "Tipo del servicio del proveedor")]
        [Required]
        [MaxLength(50, ErrorMessage = "Mucho texto")]
        public string TipoServicio { get; set; }

        [Display(Name = "Contacto del proveedor")]
        [Required]
        [MaxLength(50, ErrorMessage = "Mucho texto")]
        public string Contacto { get; set; }

        [JsonIgnore]
        public ICollection<PuntoInteres> PuntosInteres{ get; set; }
    }
}
