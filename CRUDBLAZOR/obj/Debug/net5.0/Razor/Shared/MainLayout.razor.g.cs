#pragma checksum "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fa41f2ae2748b8d92bbcbda6b4647e9de397940"
// <auto-generated/>
#pragma warning disable 1591
namespace CRUDBLAZOR.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(6);
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(10);
                    __builder3.AddAttribute(11, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 9 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 9 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n        Vacunate rd\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(17);
                __builder2.AddAttribute(18, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Shared\MainLayout.razor"
                            _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<CRUDBLAZOR.Shared.NavMenu>(21);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(23);
                __builder2.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(25);
                    __builder3.AddAttribute(26, "MaxWidth", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MaxWidth>(
#nullable restore
#line 16 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Shared\MainLayout.razor"
                                MaxWidth.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(28, 
#nullable restore
#line 17 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\keury\source\repos\Vacunados2021\CRUDBLAZOR\Shared\MainLayout.razor"
       
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
