// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CRUDBLAZOR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Models.ComboBoxModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/anularegistros")]
    public partial class AnularRegistros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\Pages\AnularRegistros.razor"
       
    string CedulaFiltro = "";
    private static bool ExistPersona = false;
    static List<dynamic> personavacunas;

    int AnswerServer;

    private async Task LoadObjects(string Cedula)
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

    private async Task DeleteData(dynamic Persona)
    {
        string query = "DELETE PERSONA_VACUNA WHERE Id= @Id";
        AnswerServer = await _data.SaveData(query, new { Id = Persona.Id }, _config.GetConnectionString("default"));
        personavacunas = null;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591