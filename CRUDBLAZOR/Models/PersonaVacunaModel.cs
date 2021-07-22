using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBLAZOR.Models
{
    public class PersonaVacunaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este Campo es requerido")]
        public int Persona_Id { get; set; }
        [Required(ErrorMessage = "Este Campo es requerido")]
        public int Vacuna_Id { get; set; }
        [Required(ErrorMessage = "Este Campo es requerido")]
        public int Provincia_Id { get; set; }
        [Required(ErrorMessage = "Este Campo es requerido")]
        public DateTime Fecha { get; set; }
    }
}

