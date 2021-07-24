using System.ComponentModel.DataAnnotations;

namespace CRUDBLAZOR.Models
{
    public class VacunaModel
    {
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Este campo no puede tener mas de 50 caracteres")]
        public string Marca { get; set; }


    }
}
