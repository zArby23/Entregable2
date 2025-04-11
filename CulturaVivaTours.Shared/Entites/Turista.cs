using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturaVivaTours.Shared.Entites
{
    public class Turista
    {
        [Display(Name = "# Documento turista")]
        [Required]
        [MaxLength(15)]
        public string id { get; set; }

        [Display(Name = "Nombre turista")]
        [Required]
        [MaxLength(75)]
        public string FullName { get; set; }


        [Display(Name = "Nacionalidad turista")]
        [Required]
        [MaxLength(40)]
        public string Nacionality { get; set; }

        [Display(Name = "Idioma turista")]
        [Required]
        [MaxLength(40)]
        public string Lenguage { get; set; }


        [Display(Name = "Comida Restringida turista")]
        [Required]
        [MaxLength(50)]
        public int RestringFood { get; set; }




    }
}
