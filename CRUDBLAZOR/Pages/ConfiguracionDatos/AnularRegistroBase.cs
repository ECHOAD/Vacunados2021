using DataLibrary;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBLAZOR.Pages.ConfiguracionDatos
{
    public class AnularRegistroBase:ComponentBase
    {
        [Inject]
        private IDataAccess _data { get; set; }
        [Inject]
        private IConfiguration _config { get; set; }
        protected string CedulaFiltro = "";
        protected static bool ExistPersona = false;
        protected static List<dynamic> personavacunas;

        int AnswerServer;

        protected async Task LoadObjects(string Cedula)
        {
            string query = $"SELECT dbo.ufcExistePersona (@Cedula)";
            int AnswerServer = await _data.LoadObject<int, dynamic>(query, new { Cedula = Cedula }, _config.GetConnectionString("default"));

            ExistPersona = true;

            if (AnswerServer == 1)
            {
                query = "SELECT * FROM uvwPersonaVacuna WHERE Cedula = @Cedula ";
                personavacunas = await _data.LoadData<dynamic, dynamic>(query, new { Cedula = Cedula }, _config.GetConnectionString("default"));
            }
            else
            {
                //persona = new();
                //OPersonaVacuna = new();

                //OPersonaVacuna.Persona.Cedula = Cedula;
                //ExistPersona = false;
            }
        }

        protected async Task DeleteData(dynamic Persona)
        {
            string query = "DELETE PERSONA_VACUNA WHERE Id= @Id";
            AnswerServer = await _data.SaveData(query, new { Id = Persona.Id }, _config.GetConnectionString("default"));
            personavacunas = null;
        }
    }
}
