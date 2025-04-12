using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulturaVivaTours.Shared.Entities
{
    public class Guia
    {
        public int Id { get; set; }

        [Display(Name = "Ingrese su nombre.")]
        [Required]
        [MaxLength(20)]
        public string? FirstName { get; set; }

        [Display(Name = "Ingrese su apellido.")]
        [Required]
        [MaxLength(20)]
        public string? LastName { get; set; }

        [Display(Name = "Ingrese su cedula.")]
        [Required]
        [MaxLength(10, ErrorMessage = "La cédula no debe superar los 10 caracteres.")]
        public int Cedula { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Ingrese el idioma que habla.")]
        [Required]
        [MaxLength(20)]
        public string? Language { get; set; }

        [Display(Name = "Ingrese los meses de experiencia que tiene (solo el número).")]
        [Required]
        public int Experience { get; set; }

        [Display(Name = "Seleccione su especialidad.")]
        [Required]
        public string? Speciality { get; set; }

    }
}
