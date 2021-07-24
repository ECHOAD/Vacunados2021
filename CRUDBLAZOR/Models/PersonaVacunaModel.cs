using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDBLAZOR.Models
{
    public class PersonaVacunaModel
    {

        public PersonaVacunaModel(PersonaModel Opersona)
        {
            Persona = Opersona;

            this.Fecha = DateTime.Now;
        }


        public int Id { get; set; }
        [Required(ErrorMessage = "Este Campo es requerido")]
        public PersonaModel Persona { get; set; }
        [Required(ErrorMessage = "Este Campo es requerido")]
        public int Vacuna_Id { get; set; }
        [Required(ErrorMessage = "Este Campo es requerido")]
        public int Provincia_Id { get; set; }
        [Required(ErrorMessage = "Este Campo es requerido")]
        public DateTime? Fecha { get; set; }
    }
}

