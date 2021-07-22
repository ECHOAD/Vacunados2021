using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBLAZOR.Models
{
    public class ProvinciaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La Provincia es requerida")]
        [StringLength(50, ErrorMessage = "Este campo no puede contener mas de 50 caracteres")]
        public string Nombre { get; set; }
    }
}
