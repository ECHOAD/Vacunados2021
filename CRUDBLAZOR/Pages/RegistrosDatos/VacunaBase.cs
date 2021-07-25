using CRUDBLAZOR.Models;
using DataLibrary;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBLAZOR.Pages.RegistrosDatos
{
    public class VacunaBase:ComponentBase
    {
        [Inject]
        public IDataAccess _data { get; set; }
        [Inject]
        public IConfiguration _config { get; set; }
        protected VacunaModel OVacuna { get; set; } = new();
        protected List<dynamic> vacunas { get; set; }
        int AnswerServer;

        protected async Task InsertData()
        {
            string query = "SP_AGREGAR_VACUNA @Marca";
            AnswerServer = await _data.SaveData<dynamic>(query, OVacuna, _config.GetConnectionString("default"));
            OVacuna.Marca = "";
            await OnInitializedAsync();
        }
        protected async Task DeleteData(dynamic Vacuna)
        {
            string query = "DELETE FROM VACUNA WHERE Id = @Id";
            AnswerServer = await _data.SaveData(query, new { Id = Vacuna.Id }, _config.GetConnectionString("default"));
            await OnInitializedAsync();
        }
        protected override async Task OnInitializedAsync()
        {
            string query = "SELECT * FROM VACUNA";
            vacunas = await _data.LoadData<dynamic, dynamic>(query, new { }, _config.GetConnectionString("default"));
        }
    }
}
