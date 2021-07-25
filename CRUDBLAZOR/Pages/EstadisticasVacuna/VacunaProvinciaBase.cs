using CRUDBLAZOR.Models;
using CRUDBLAZOR.Models.ComboBoxModels;
using DataLibrary;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBLAZOR.Pages.EstadisticasVacuna
{
    public class VacunaProvinciaBase:ComponentBase
    {
        [Inject]
        private IDataAccess _data { get; set; }
        [Inject]
        private IConfiguration _config { get; set; }
        protected static ProvinciaModel OProvincia { get; set; } = new();
        protected List<ComboBoxProvinciaModel> _cboProvincia { get; set; }
        protected List<dynamic> VacunadosProv { get; set; }


        protected async Task VacunadosProvincias(int Id)
        {
            string query = "SP_LIST_VACUNADOS_PROVINCIA @Id";
            VacunadosProv = await _data.LoadData<dynamic, dynamic>(query, new { Id = Id }, _config.GetConnectionString("default"));
        }
        protected override async Task OnInitializedAsync()
        {
            string query = "SELECT Id, Nombre FROM PROVINCIA";
            _cboProvincia = await _data.LoadData<ComboBoxProvinciaModel, dynamic>(query, new { }, _config.GetConnectionString("default"));
        }
    }
}
