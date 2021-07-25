using CRUDBLAZOR.Models;
using CRUDBLAZOR.Models.ComboBoxModels;
using DataLibrary;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDBLAZOR.Pages.RegistrosDatos.RegistroPersonas
{
    public class PersonaBase:ComponentBase
    {
        [Inject]
        public IDataAccess _data { get; set; }
        [Inject]
        public IConfiguration _config { get; set; }
        protected PersonaModel OPersona { get; set; } = new();
        protected static bool ModoEditar { get; set; } = false;
        protected List<dynamic> personas { get; set; }

        protected List<ComboBoxProvinciaModel> _cboProvincia;
        protected List<ComboBoxSignoZodModel> _cboSignoZod;
        int AnswerServer;
        protected async Task LoadEditar(string Cedula)
        {
            string query = "SELECT * FROM PERSONA WHERE Cedula = @Cedula";
            OPersona = await _data.LoadObject<PersonaModel, dynamic>(query, new { Cedula = Cedula }, _config.GetConnectionString("default"));
        }

        protected async Task InsertData()
        {
            string query = "SP_AGREGAR_PERSONA @Cedula, @Nombre, @Apellido, @Telefono, @Fecha_nacimiento, @Signo_Id";

            AnswerServer = await _data.SaveData<dynamic>(query, OPersona, _config.GetConnectionString("default"));
            OnInitialized();
        }

        protected async Task UpdateData()
        {
            string query = "Update Personas set Nombre=@Nombre,Apellido=@Apellido," +
                           "Telefono=@Telefono,FechaNacimiento=@FechaNacimiento," +
                           "ProvinciaId=@ProvinciaId,SIGNOZODID=@SignoZodid " +
                           "Where Cedula= @Cedula";
            AnswerServer = await _data.SaveData<PersonaModel>(query, OPersona, _config.GetConnectionString("default"));
            await OnInitializedAsync();
        }

        protected async Task DeleteData(dynamic Persona)
        {
            string query = "DELETE PERSONA Cedula= @Cedula";
            AnswerServer = await _data.SaveData(query, new { Cedula = Persona.Cedula }, _config.GetConnectionString("default"));
            await OnInitializedAsync();
        }

        protected override async Task OnInitializedAsync()
        {
            string query = "SELECT * FROM PERSONA";
            personas = await _data.LoadData<dynamic, dynamic>(query, new { }, _config.GetConnectionString("default"));

            query = "SELECT Id, Nombre FROM SIGNO";
            _cboSignoZod = await _data.LoadData<ComboBoxSignoZodModel, dynamic>(query, new { }, _config.GetConnectionString("default"));
        }
    }
}
