#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a9c8da20c4f4d78b49289b5485534bc5a7d8911"
// <auto-generated/>
#pragma warning disable 1591
namespace SACOMaintenance.Blazor.Server.Components
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
#line 12 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
    public partial class RequestsForUserAll : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\"><div class=\"col-lg-12\"><label>Dashboard</label></div></div>");
#nullable restore
#line 11 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
 if(userRequestAllViewModel.Requests.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row row-allrequest-table");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(5);
            __builder.AddAttribute(6, "Text", "Your Open Requests");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "row");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-lg-12");
                __Blazor.SACOMaintenance.Blazor.Server.Components.RequestsForUserAll.TypeInference.CreateRadzenGrid_0(__builder2, 12, 13, 
#nullable restore
#line 18 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
                                           userRequestAllViewModel.Requests

#line default
#line hidden
#nullable disable
                , 14, 
#nullable restore
#line 18 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
                                                                                                true

#line default
#line hidden
#nullable disable
                , 15, 
#nullable restore
#line 18 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
                                                                                                                      true

#line default
#line hidden
#nullable disable
                , 16, 
#nullable restore
#line 19 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
                                                  true

#line default
#line hidden
#nullable disable
                , 17, (__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(18);
                    __builder3.AddAttribute(19, "Property", "Id");
                    __builder3.AddAttribute(20, "Title", "Number");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(22);
                    __builder3.AddAttribute(23, "Property", "RequestDetails");
                    __builder3.AddAttribute(24, "Title", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(26);
                    __builder3.AddAttribute(27, "Property", "DateRaised");
                    __builder3.AddAttribute(28, "Title", "Date Raised");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(30);
                    __builder3.AddAttribute(31, "Property", "Status.StatusName");
                    __builder3.AddAttribute(32, "Title", "Status");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n                                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(34);
                    __builder3.AddAttribute(35, "Title", "Staff Assigned");
                    __builder3.AddAttribute(36, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiation>)((data) => (__builder4) => {
#nullable restore
#line 27 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
                                         foreach(var item in data.Users)
                                        {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(37, "img");
                        __builder4.AddAttribute(38, "src", 
#nullable restore
#line 29 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
                                                       item.AvatarLocation

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddAttribute(39, "width", "30");
                        __builder4.AddAttribute(40, "height", "30");
                        __builder4.CloseElement();
#nullable restore
#line 30 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
                                        }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsForUserAll.razor"
       

    [Parameter]
    public string UserId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await userRequestAllViewModel.LoadAllRequestsForUser(UserId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IUserRequestsAll userRequestAllViewModel { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Components.RequestsForUserAll
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "AllowColumnResize", __arg1);
        __builder.AddAttribute(__seq2, "AllowFiltering", __arg2);
        __builder.AddAttribute(__seq3, "AllowSorting", __arg3);
        __builder.AddAttribute(__seq4, "Columns", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
