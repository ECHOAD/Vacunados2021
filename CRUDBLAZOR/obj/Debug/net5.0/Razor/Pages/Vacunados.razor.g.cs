#pragma checksum "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "477f41975c57d79a8870a83d16b14be842f115f1"
// <auto-generated/>
#pragma warning disable 1591
namespace CRUDBLAZOR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Models.ComboBoxModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/vacunados")]
    public partial class Vacunados : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
 if (personas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading...</p>");
#nullable restore
#line 8 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-12");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, @"<thead class=""thead-dark""><tr><th scope=""col"">Cedula</th>
                            <th scope=""col"">Nombres</th>
                            <th scope=""col"">Apellido</th>
                            <th scope=""col"">Telefono</th>
                            <th scope=""col"">Signo Zodiacal</th>
                            <th scope=""col"">Provincia</th>
                            <th scope=""col"">Acciones</th></tr></thead>
                    ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 29 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
                         foreach (var p in personas)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 32 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
                                     p.CEDULA

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 33 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
                                     p.NOMBRE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 34 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
                                     p.APELLIDO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 35 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
                                     p.TELEFONO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 36 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
                                     p.SIGNOZODIACAL

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 37 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
                                     p.PROVINCIA

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
                                                                              () => LoadEditar(p.CEDULA)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "<i class=\"bi-pencil-fill\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                    ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-danger");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
                                                                             () => DeleteData(p)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "<i class=\"bi bi-x-octagon-fill\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"




}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Pages\Vacunados.razor"
       

    private Persona_Model OPersona = new();

    private static bool ModoEditar = false;



    List<dynamic> personas;
    private List<ComboBoxProvinciaModel> _cboProvincia;
    private List<ComboBoxSignoZodModel> _cboSignoZod;


    int AnswerServer;




    private async Task LoadEditar(string Cedula)
    {

        string query = "SELECT * FROM PERSONAS WHERE Cedula = @Cedula";

        OPersona = await _data.LoadObject<Persona_Model, dynamic>(query, new { Cedula = Cedula }, _config.GetConnectionString("default"));


    }

    private async Task InsertData()
    {
        string query = "Insert into PERSONAS (CEDULA,NOMBRE,APELLIDO,TELEFONO,FECHANACIMIENTO,PROVINCIAID,SIGNOZODID) values (@Cedula,@Nombre,@Apellido,@Telefono,@FechaNacimiento,@ProvinciaId,@SignoZodid)";

        AnswerServer = await _data.SaveData<dynamic>(query, OPersona, _config.GetConnectionString("default"));
        OnInitialized();
    }

    private async Task UpdateData()
    {
        string query = "Update Personas set Nombre=@Nombre,Apellido=@Apellido,Telefono=@Telefono,FechaNacimiento=@FechaNacimiento,ProvinciaId=@ProvinciaId,SIGNOZODID=@SignoZodid Where Cedula= @Cedula";
        AnswerServer = await _data.SaveData<Persona_Model>(query, OPersona, _config.GetConnectionString("default"));
        await OnInitializedAsync();
    }

    private async Task DeleteData(dynamic Persona)
    {
        string query = "Delete Personas Cedula= @Cedula";
        AnswerServer = await _data.SaveData(query, new { Cedula = Persona.CEDULA }, _config.GetConnectionString("default"));
        await OnInitializedAsync();
    }

    protected override async Task OnInitializedAsync()
    {
        string query = "SELECT * from vwPersonas";
        personas = await _data.LoadData<dynamic, dynamic>(query, new { }, _config.GetConnectionString("default"));

        query = "SELECT ID_Provincia, Nombre FROM PROVINCIAS";

        _cboProvincia = await _data.LoadData<ComboBoxProvinciaModel, dynamic>(query, new { }, _config.GetConnectionString("default"));

        query = "SELECT ID_SIGNO_Zodiacal, Nombre FROM SIGNO_ZODIACAL";

        _cboSignoZod = await _data.LoadData<ComboBoxSignoZodModel, dynamic>(query, new { }, _config.GetConnectionString("default"));
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
