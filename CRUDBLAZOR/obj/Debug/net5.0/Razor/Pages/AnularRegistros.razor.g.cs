#pragma checksum "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab242220c7ba8d3293feb99d080c9282d8bc56b9"
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
#line 1 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using DataLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
using CRUDBLAZOR.Models.ComboBoxModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\_Imports.razor"
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
            __builder.AddMarkupContent(0, "<h3>Anular Registro Persona</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-12");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                             CedulaFiltro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "form-inline");
            __builder.AddAttribute(10, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                         ()=>LoadObjects(CedulaFiltro)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group mx-sm-3 mb-2");
                __builder2.AddMarkupContent(14, "<label for=\"inputPassword2\" class=\"sr-only\">Cedula</label>\r\n                    ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "id", "inputPassword2");
                __builder2.AddAttribute(19, "placeholder", "Cedula");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                                       CedulaFiltro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CedulaFiltro = __value, CedulaFiltro));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.AddMarkupContent(23, "<button type=\"submit\" class=\"btn btn-primary mb-2\">Verificar</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
 if (personavacunas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<p>Loading...</p>");
#nullable restore
#line 67 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "container-fluid");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-12");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "class", "table");
            __builder.AddMarkupContent(33, @"<thead class=""thead-dark""><tr><th scope=""col"">Cedula</th>
                            <th scope=""col"">Nombre</th>
                            <th scope=""col"">Telefono</th>
                            <th scope=""col"">Provincia</th>
                            <th scope=""col"">Marca Vacuna</th>
                            <th scope=""col"">Fecha Vacuna</th>
                            <th scope=""col"">Signo Zodiacal</th>

                            <th scope=""col"">Acciones</th></tr></thead>
                    ");
            __builder.OpenElement(34, "tbody");
#nullable restore
#line 90 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                         foreach (var p in personavacunas)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "tr");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 93 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                     p.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 94 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                     p.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 95 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                     p.Telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 96 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                     p.Provincia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 97 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                     p.VacunaAplicada

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                ");
            __builder.OpenElement(51, "td");
            __builder.AddContent(52, 
#nullable restore
#line 98 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                     p.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 99 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                     p.Signo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                ");
            __builder.OpenElement(57, "td");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "class", "btn btn-danger");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
                                                                             () => DeleteData(p)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(61, "<i class=\"bi bi-x-octagon-fill\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 105 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
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
#line 112 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\Users\Adrian Estevez\Desktop\Backend 1\Vacunados2021\CRUDBLAZOR\Pages\AnularRegistros.razor"
       
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

    //protected override async Task OnInitializedAsync()
    //{
    //    string query = "SELECT * from uvwPersonaVacuna";
    //    personavacunas = await _data.LoadData<dynamic, dynamic>(query, new { }, _config.GetConnectionString("default"));
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration _config { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDataAccess _data { get; set; }
    }
}
#pragma warning restore 1591
