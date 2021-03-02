#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e59ff62e9a59b025612d08923862168f8157a0"
// <auto-generated/>
#pragma warning disable 1591
namespace SACOMaintenance.Blazor.Server.Pages.AreaPages
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
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaListComponent.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaListComponent.razor"
using SACOMaintenance.DataAccess.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/areas-list")]
    public partial class AreaListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<div class=\"col-lg-4\"><h3>Areas List</h3></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg-2");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "href", "area/create");
            __builder.AddAttribute(9, "class", "btn btn-primary stretched-link");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Add New Area");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "continer-fluid");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-sm-12 col-md-12 col-lg-6");
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table");
            __builder.AddMarkupContent(19, "<thead><tr><th>Id</th>\r\n                    <th>Name</th>\r\n                    <th>Actions</th></tr></thead>\r\n            ");
            __builder.OpenElement(20, "tbody");
#nullable restore
#line 28 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaListComponent.razor"
                   
                    foreach(var areaItem in Areas)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "tr");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaListComponent.razor"
                                 areaItem.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 33 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaListComponent.razor"
                                 areaItem.AreaName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "href", 
#nullable restore
#line 34 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaListComponent.razor"
                                           $"editarea/{areaItem.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(32, "<i class=\"fa fa-pencil-square\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaListComponent.razor"
                    }
                

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaListComponent.razor"
       
    private IEnumerable<AreaModel> Areas { get; set; } = new List<AreaModel>();

    protected override void OnInitialized()
    {
        Areas = AreaDataProvider.LoadAllAreas();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArea AreaDataProvider { get; set; }
    }
}
#pragma warning restore 1591
