using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBLAZOR.Models
{
    public class VacunaModel
    {
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Este campo no puede tener mas de 50 caracteres")]
        public string Marca { get; set; }

      
    }
}
