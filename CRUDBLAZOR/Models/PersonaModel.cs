using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBLAZOR.Models
{
    public class Persona_Model
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Fecha Nacimiento es obligatorio")]
        [StringLength(13, ErrorMessage = "La Cedula no puede exceder de 16 caracteres.")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El campo Fecha Nacimiento es obligatorio")]
        [StringLength(30, ErrorMessage = "El Nombre no puede exceder de 30 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        [StringLength(30, ErrorMessage = "El Apellido no puede exceder de 30 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        [StringLength(15, ErrorMessage = "El Telefono no puede exceder de 15 caracteres.")]
        public string Telefono { get; set; }
        
        [Parameter]
        [Required(ErrorMessage = "El campo Fecha Nacimiento es obligatorio")]        
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo Provincia Nacimiento es obligatorio")]
        public int ProvinciaID { get; set; }

        [Required(ErrorMessage = "El campo Signo Zodiacal es obligatorio")]
        public int SignoZodid { get; set; }
    }
}
