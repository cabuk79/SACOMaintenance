#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9212d73553fd2057483bd1130b0083b6ebea41ce"
// <auto-generated/>
#pragma warning disable 1591
namespace SACOMaintenance.Blazor.Server.Pages.CompanyPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using SACOMaintenance.Blazor.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using SACOMaintenance.Blazor.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
using SACOMaintenance.DataAccess.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/company-view/{CompanyId}")]
    public partial class CompanyViewComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-lg-12");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "h3");
            __builder.AddContent(5, "Company View for ");
            __builder.AddContent(6, 
#nullable restore
#line 8 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
                              CompanyModelItem.CompantName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "h3");
            __builder.AddContent(11, "Lsit of Maintenance Requests Linked to ");
            __builder.AddContent(12, 
#nullable restore
#line 11 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
                                                    CompanyModelItem.CompantName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __Blazor.SACOMaintenance.Blazor.Server.Pages.CompanyPages.CompanyViewComponent.TypeInference.CreateRadzenGrid_0(__builder, 16, 17, 
#nullable restore
#line 14 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
                           ListOfMaintReqInitations

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 14 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
                                                                   true

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 14 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
                                                                                         true

#line default
#line hidden
#nullable disable
            , 20, (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(21);
                __builder2.AddAttribute(22, "Property", "Id");
                __builder2.AddAttribute(23, "Title", "Id");
                __builder2.AddAttribute(24, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
                                                                                                      false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(26);
                __builder2.AddAttribute(27, "Property", "RequestDetails");
                __builder2.AddAttribute(28, "Title", "Details");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(30);
                __builder2.AddAttribute(31, "Property", "Area.AreaName");
                __builder2.AddAttribute(32, "Title", "Area");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(34);
                __builder2.AddAttribute(35, "Property", "Factory.FactoryName");
                __builder2.AddAttribute(36, "Title", "Factory");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(38);
                __builder2.AddAttribute(39, "Property", "Area.Id");
                __builder2.AddAttribute(40, "Title", "Actions");
                __builder2.AddAttribute(41, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
                                                                                                                false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiation>)((data) => (__builder3) => {
                    __builder3.OpenElement(43, "a");
                    __builder3.AddAttribute(44, "href", 
#nullable restore
#line 22 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
                                   $"editarea/{data.AreaId}"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(45, "class", "btn btn-primary table-btn");
                    __builder3.AddMarkupContent(46, "<i class=\"fa fa-pencil-square\"></i>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\CompanyPages\CompanyViewComponent.razor"
       
    [Parameter]
    public string CompanyId { get; set; }

    public IEnumerable<MaintRequestInitiation> ListOfMaintReqInitations { get; set; } = new List<MaintRequestInitiation>();

    private Company CompanyModelItem { get; set; } = new Company();

    protected override void OnInitialized()
    {
        CompanyModelItem = CompanyDataProvider.LoadSingleCompany(Convert.ToInt32(CompanyId));
        ListOfMaintReqInitations = CompanyModelItem.MaintenanceRequestIniations;   
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompany CompanyDataProvider { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Pages.CompanyPages.CompanyViewComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "AllowSorting", __arg1);
        __builder.AddAttribute(__seq2, "AllowFiltering", __arg2);
        __builder.AddAttribute(__seq3, "Columns", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
