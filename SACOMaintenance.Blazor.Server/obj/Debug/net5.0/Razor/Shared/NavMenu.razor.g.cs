#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4666a55c43af895dbf12589871a67c739125c473"
// <auto-generated/>
#pragma warning disable 1591
namespace SACOMaintenance.Blazor.Server.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "<a class=\"navbar-brand\" href>SACO Maintenance App V1.0</a>\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<span class=\"navbar-toggler-icon\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", 
#nullable restore
#line 8 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "nav flex-column");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "class", "nav-link");
            __builder.AddAttribute(17, "href", "");
            __builder.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "<span class=\"oi oi-dashboard\" aria-hidden=\"true\"></span> Dashboard\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-item dropdown show");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "nav-link dropdown-toggle");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                                ()=>
                requestExpand = !requestExpand

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "<span class=\"oi oi-book\" aria-hidden=\"true\"></span>Requests\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
         if ((requestExpand))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "li");
            __builder.OpenElement(30, "ul");
            __builder.OpenElement(31, "li");
            __builder.AddAttribute(32, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "class", "nav-link");
            __builder.AddAttribute(35, "href", "maintrequests-list");
            __builder.AddAttribute(36, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 28 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                        NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(38, "<span class=\"oi oi-book\" aria-hidden=\"true\"></span> View Requests\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "li");
            __builder.AddAttribute(41, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "class", "nav-link");
            __builder.AddAttribute(44, "href", "/maint-req/add");
            __builder.AddAttribute(45, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 33 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                                               NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "<span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Add New Request\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"


        }



        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "li");
            __builder.AddAttribute(49, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
            __builder.AddAttribute(51, "class", "nav-link");
            __builder.AddAttribute(52, "href", "areas");
            __builder.AddAttribute(53, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 49 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "<span class=\"oi oi-map-marker\" aria-hidden=\"true\"></span> Areas\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "li");
            __builder.AddAttribute(58, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(59);
            __builder.AddAttribute(60, "class", "nav-link");
            __builder.AddAttribute(61, "href", "company-view-edit");
            __builder.AddAttribute(62, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 54 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(64, "<span class=\"fa fa-building\" aria-hidden=\"true\"></span> Companies\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "li");
            __builder.AddAttribute(67, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(68);
            __builder.AddAttribute(69, "class", "nav-link");
            __builder.AddAttribute(70, "href", "ppe-list");
            __builder.AddAttribute(71, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 59 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(73, "<span class=\"oi oi-shield\" aria-hidden=\"true\"></span> PPE\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "li");
            __builder.AddAttribute(76, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(77);
            __builder.AddAttribute(78, "class", "nav-link");
            __builder.AddAttribute(79, "href", "");
            __builder.AddAttribute(80, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 64 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(82, "<span class=\"fa fa-ambulance\" aria-hidden=\"true\"></span> Risks\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.OpenElement(84, "li");
            __builder.AddAttribute(85, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(86);
            __builder.AddAttribute(87, "class", "nav-link");
            __builder.AddAttribute(88, "href", "equipmentList");
            __builder.AddAttribute(89, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 69 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(91, "<span class=\"oi oi-wrench\" aria-hidden=\"true\"></span> Equipment\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.OpenElement(93, "li");
            __builder.AddAttribute(94, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(95);
            __builder.AddAttribute(96, "class", "nav-link");
            __builder.AddAttribute(97, "href", "machinetype-view-edit");
            __builder.AddAttribute(98, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 74 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                                          NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(100, "<span class=\"oi oi-cog\" aria-hidden=\"true\"></span> Machine Type\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.OpenElement(102, "li");
            __builder.AddAttribute(103, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(104);
            __builder.AddAttribute(105, "class", "nav-link");
            __builder.AddAttribute(106, "href", "factories-view-edit");
            __builder.AddAttribute(107, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 79 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                                        NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(109, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Factories\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n        ");
            __builder.OpenElement(111, "li");
            __builder.AddAttribute(112, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(113);
            __builder.AddAttribute(114, "class", "nav-link");
            __builder.AddAttribute(115, "href", "suppliers-list");
            __builder.AddAttribute(116, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 84 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                                   NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(118, "<span class=\"oi oi-people\" aria-hidden=\"true\"></span> Suppliers\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n        ");
            __builder.OpenElement(120, "li");
            __builder.AddAttribute(121, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(122);
            __builder.AddAttribute(123, "class", "nav-link");
            __builder.AddAttribute(124, "href", "parts-list");
            __builder.AddAttribute(125, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 89 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                               NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(127, "<span class=\"oi oi-wrench\" aria-hidden=\"true\"></span> Parts\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.OpenElement(129, "li");
            __builder.AddAttribute(130, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(131);
            __builder.AddAttribute(132, "class", "nav-link");
            __builder.AddAttribute(133, "href", "orders-list");
            __builder.AddAttribute(134, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 94 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
                                                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(136, "<span class=\"oi oi-clipboard\" aria-hidden=\"true\"></span> Orders\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Shared\NavMenu.razor"
       

    private bool requestExpand;

    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
