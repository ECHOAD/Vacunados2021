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
    public class PersonaVacunaBase:ComponentBase
    {
        [Inject]
        protected IDataAccess _data { get; set; }
        [Inject]
        protected IConfiguration _config { get; set; }
        protected string CedulaFiltro { get; set; } = "";
        protected static PersonaModel persona { get; set; } = new();
        protected PersonaVacunaModel OPersonaVacuna { get; set; }
        protected static bool ExistPersona { get; set; } = false;
        protected static bool FechaActual { get; set; } = true;
        protected List<dynamic> personavacunas { get; set; }
        protected List<ComboBoxProvinciaModel> _cboProvincia { get; set; }
        protected List<ComboBoxSignoZodModel> _cboSignoZod { get; set; }
        protected List<dynamic> _cboVacunas { get; set; }

        int AnswerServer;

        protected void SetFechaActual(object Validacion)
        {
            FechaActual = (bool)Validacion;
            OPersonaVacuna.Fecha = FechaActual == true ? DateTime.Now : null;
        }
        protected async Task LoadObjects(string Cedula)
        {

            string query = $"SELECT dbo.ufcExistePersona (@Cedula)";

            int AnswerServer = await _data.LoadObject<int, dynamic>(query, new { Cedula = Cedula }, _config.GetConnectionString("default"));

            query = "SELECT * FROM VACUNA";
            _cboVacunas = await _data.LoadData<dynamic, dynamic>(query, new { }, _config.GetConnectionString("default"));

            query = "SELECT Id, Nombre FROM PROVINCIA";

            _cboProvincia = await _data.LoadData<ComboBoxProvinciaModel, dynamic>(query, new { }, _config.GetConnectionString("default"));

            query = "SELECT ID, Nombre FROM SIGNO";

            _cboSignoZod = await _data.LoadData<ComboBoxSignoZodModel, dynamic>(query, new { }, _config.GetConnectionString("default"));

            ExistPersona = true;

            if (AnswerServer == 1)
            {
                query = "SELECT  TOP 1 * FROM Persona WHERE Cedula = @Cedula ";
                persona = await _data.LoadObject<PersonaModel, dynamic>(query, new { Cedula = Cedula }, _config.GetConnectionString("default"));
                OPersonaVacuna = new(persona);
            }
            else
            {
                persona = new();
                OPersonaVacuna = new(persona);
                OPersonaVacuna.Persona.Cedula = Cedula;
                ExistPersona = false;
            }

        }

        protected async Task InsertData()
        {
            string query;

            if (!ExistPersona)
            {
                query = "SP_AGREGAR_PERSONA @Cedula, @Nombre, @Apellido, @Telefono, @Fecha_Nacimiento,@Signo_Id";
                AnswerServer = await _data.SaveData<dynamic>(query, OPersonaVacuna.Persona, _config.GetConnectionString("default"));

                query = "SP_AGREGAR_PERSONAVACUNA @Cedula,  @Vacuna_Id , @Provincia_Id, @Fecha";
                AnswerServer = await _data.SaveData<dynamic>(query, new
                {
                    Cedula = OPersonaVacuna.Persona.Cedula,
                    Vacuna_Id = OPersonaVacuna.Vacuna_Id,
                    Provincia_Id = OPersonaVacuna.Provincia_Id,
                    Fecha = OPersonaVacuna.Fecha
                },
                  _config.GetConnectionString("default"));
            }
            else
            {
                query = "SP_AGREGAR_PERSONAVACUNA @Cedula,  @Vacuna_Id , @Provincia_Id, @Fecha";

                AnswerServer = await _data.SaveData<dynamic>(query, new
                {
                    Cedula = OPersonaVacuna.Persona.Cedula,
                    Vacuna_Id = OPersonaVacuna.Vacuna_Id,
                    Provincia_Id = OPersonaVacuna.Provincia_Id,
                    Fecha = OPersonaVacuna.Fecha
                },
                  _config.GetConnectionString("default"));
            }

            OPersonaVacuna = null;
            await OnInitializedAsync();
        }
        protected async Task UpdateData()
        {
            string query = "UPDATE PERSONAVACUNA SET Nombre=@Nombre,Apellido=@Apellido,Telefono=@Telefono," +
                           "FechaNacimiento=@FechaNacimiento,ProvinciaId=@ProvinciaId,SIGNOZODID=@SignoZodid, " +
                           "MarcaId=@MarcaId, DosisId=@DosisIdWhere Cedula= @Cedula";
            AnswerServer = await _data.SaveData<PersonaVacunaModel>(query, OPersonaVacuna, _config.GetConnectionString("default"));
            await OnInitializedAsync();
        }
        protected async Task DeleteData(dynamic Persona)
        {
            string query = "DELETE PERSONAVACUNA Cedula= @Cedula";
            AnswerServer = await _data.SaveData(query, new { Cedula = Persona.CEDULA }, _config.GetConnectionString("default"));
            await OnInitializedAsync();
        }
        protected override async Task OnInitializedAsync()
        {
            string query = "SELECT * from uvwPersonaVacuna";
            personavacunas = await _data.LoadData<dynamic, dynamic>(query, new { }, _config.GetConnectionString("default"));
        }
    }
}
