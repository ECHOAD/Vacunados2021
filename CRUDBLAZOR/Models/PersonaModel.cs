using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBLAZOR.Models
{
    public class PersonaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Fecha Nacimiento es obligatorio")]
        [StringLength(11, ErrorMessage = "La Cedula no puede exceder de 16 caracteres.")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El campo Fecha Nacimiento es obligatorio")]
        [StringLength(50, ErrorMessage = "El Nombre no puede exceder de 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        [StringLength(50, ErrorMessage = "El Apellido no puede exceder de 50 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        [StringLength(10, ErrorMessage = "El Telefono no puede exceder de 10 caracteres.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo Fecha Nacimiento es obligatorio")]
        public DateTime Fecha_nacimiento { get; set; }

        [Required(ErrorMessage = "El campo Signo Zodiacal es obligatorio")]
        public int Signo_Id { get; set; }

    }
}
