#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56329a295e1b1df5b56cf2ad0f68f85dd5d46c5d"
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
#line 1 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
    public partial class PPEEquipmentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-lg-12");
#nullable restore
#line 5 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
         if (colour == "red")
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(4);
            __builder.AddAttribute(5, "Style", "width: 150px; height: 200px; border-color: red; background-color: red");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row d-flex justify-content-center");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-lg-12 d-flex justify-content-center");
                __builder2.OpenComponent<Radzen.Blazor.RadzenImage>(11);
                __builder2.AddAttribute(12, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
                                            ppe.IconFileLocation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Style", "width: 75px; align-content: center");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row d-flex justify-content-center");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-lg-12 d-flex justify-content-center");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(19);
                __builder2.AddAttribute(20, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
                                            ppe.PPEName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Style", "align-items: center; width=100%; color: white");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 19 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
        }
        else if (colour == "black")
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(22);
            __builder.AddAttribute(23, "Style", "width: 150px; height: 200px; border-color: black; background-color: white");
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "row d-flex justify-content-center");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-lg-12 d-flex justify-content-center");
                __builder2.OpenComponent<Radzen.Blazor.RadzenImage>(29);
                __builder2.AddAttribute(30, "Path", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
                                            ppe.IconFileLocation

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Style", "width: 75px; align-content: center");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "row d-flex justify-content-center");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-lg-12 d-flex justify-content-center");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(37);
                __builder2.AddAttribute(38, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
                                            ppe.PPEName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Style", "align-items: center; width=100%; color: black");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 34 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "row");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-lg-12");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
                                                     maintppeChanged

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 40 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
             if(colour == "red")
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(48);
            __builder.AddAttribute(49, "Text", "Remove");
            __builder.CloseComponent();
#nullable restore
#line 43 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
            }
             else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(50);
            __builder.AddAttribute(51, "Text", "Add");
            __builder.CloseComponent();
#nullable restore
#line 47 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\PPEEquipmentComponent.razor"
       
    [Parameter]
    public PPE ppe { get; set; }

    [Parameter]
    public EventCallback<MaintRequestInitiation> maintReqChanged { get; set; }

    [Parameter]
    public string colour { get; set; }

    [Parameter]
    public MaintRequestInitiation maintReq { get; set; }


    private void maintppeChanged()
    {
        if (colour == "red")
        {
            colour = "black";
            var reqid = maintReq.PPEEquipment;

            maintReq.PPEEquipment.RemoveAll(i => i.Id == ppe.Id);

            maintReqChanged.InvokeAsync(maintReq);
        }
        else
        {
            colour = "red";
            maintReq.PPEEquipment.Add(ppe);
        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
