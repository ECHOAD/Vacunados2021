// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CRUDBLAZOR.Pages.RegistrosDatos
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/provincia")]
    public partial class Provincia : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Alejandra\OneDrive\Desktop\Vacunados2021 RETITUYO UNA PREGUNTA\Vacunados2021EsteSi\CRUDBLAZOR\Pages\RegistrosDatos\Provincia.razor"
       

    private ProvinciaModel OProvincia = new();

    private static bool ModoEditar = false;

    List<dynamic> provincias;

    int AnswerServer;

    private async Task LoadEditar(int Id)
    {
        string query = "SELECT * FROM PROVINCIA WHERE Id = @Id";

        OProvincia = await _data.LoadObject<ProvinciaModel, dynamic>(query, new { Id = Id }, _config.GetConnectionString("default"));

        ModoEditar = true;
    }

    private async Task InsertData()
    {
        string query = "INSERT INTO Provincia (Nombre) Values(@Nombre)";
        AnswerServer = await _data.SaveData<dynamic>(query, OProvincia, _config.GetConnectionString("default"));
        OnInitialized();
    }

    private async Task UpdateData()
    {
        string query = $"UPDATE PROVINCIA SET Nombre = '{OProvincia.Nombre.ToString()}' Where Id = {Convert.ToInt32(OProvincia.Id)} ";
        AnswerServer = await _data.SaveData<dynamic>(query, new { }, _config.GetConnectionString("default"));
        await OnInitializedAsync();

        ModoEditar = false;
    }

    private async Task DeleteData(dynamic Provincia)
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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
