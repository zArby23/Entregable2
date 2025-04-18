﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CulturaVivaTours.Shared.Entities
{
    public class Turista
    {
        
        public int Id { get; set; }
 

        [Display(Name = "Nombre turista")] //Pone una Descripcion del campo
        [Required] //Hace que sea obligatorio
        [MaxLength(75, ErrorMessage = "Nombre Demasiado largo")]//Caracteres maximos y mensaje de error
        public string FullName { get; set; }


        [Display(Name = "Nacionalidad turista")]
        [Required]
        [MaxLength(40,ErrorMessage = "Nacionalidad Demasiado largo")]
        public string Nationality { get; set; }

        [Display(Name = "Idioma turista")]
        [Required]
        [MaxLength(40, ErrorMessage = "Idioma Demasiado largo")]
        public string Language { get; set; }


        [Display(Name = "Comida Restringida turista (si aplica)")]
        [MaxLength(100, ErrorMessage = "Comida Restringida Demasiado largo")]
        public string RestringFood { get; set; }


        [Display(Name = "Idioma turista")]
        [Required]
        [MaxLength(40, ErrorMessage = "Idioma Demasiado largo" )]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Disponibility { get; set; }





        //Conexion con la tabla calificacion
        [JsonIgnore]
        public ICollection<Calificacion> Calificaciones { get; set; }






    }
}
