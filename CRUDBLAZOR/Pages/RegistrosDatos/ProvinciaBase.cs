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
    public class ProvinciaBase:ComponentBase
    {
        [Inject]
        public IDataAccess _data { get; set; }
        [Inject]
        public IConfiguration _config { get; set; }
        protected ProvinciaModel OProvincia { get; set; } = new();
        protected static bool ModoEditar { get; set; } = false;
        protected List<dynamic> provincias { get; set; }

        int AnswerServer;

        protected async Task LoadEditar(int Id)
        {
            string query = "SELECT * FROM PROVINCIA WHERE Id = @Id";
            OProvincia = await _data.LoadObject<ProvinciaModel, dynamic>(query, new { Id = Id }, _config.GetConnectionString("default"));
            ModoEditar = true;
        }
        protected async Task InsertData()
        {
            string query = "INSERT INTO Provincia (Nombre) Values(@Nombre)";
            AnswerServer = await _data.SaveData<dynamic>(query, OProvincia, _config.GetConnectionString("default"));
            OProvincia.Nombre = "";
            await OnInitializedAsync();
        }
        protected async Task UpdateData()
        {
            string query = $"UPDATE PROVINCIA SET Nombre = '{OProvincia.Nombre.ToString()}' Where Id = {Convert.ToInt32(OProvincia.Id)} ";
            AnswerServer = await _data.SaveData<dynamic>(query, new { }, _config.GetConnectionString("default"));
            OProvincia.Nombre = "";
            await OnInitializedAsync();

            ModoEditar = false;
        }
        protected async Task DeleteData(dynamic Provincia)
        {
            string query = "DELETE PROVINCIA WHERE Id = @Id";
            AnswerServer = await _data.SaveData(query, new { Id = Provincia.Id }, _config.GetConnectionString("default"));
            await OnInitializedAsync();
        }
        protected override async Task OnInitializedAsync()
        {
            string query = "SELECT Id, Nombre FROM PROVINCIA";
            provincias = await _data.LoadData<dynamic, dynamic>(query, new { }, _config.GetConnectionString("default"));
        }
    } 
}
