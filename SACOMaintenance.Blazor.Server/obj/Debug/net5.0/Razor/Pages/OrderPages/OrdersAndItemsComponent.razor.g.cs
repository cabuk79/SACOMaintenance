#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrdersAndItemsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2f642aedc5806e59ad2bf4f7148bc689694b60f"
// <auto-generated/>
#pragma warning disable 1591
namespace SACOMaintenance.Blazor.Server.Pages.OrderPages
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
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrdersAndItemsComponent.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
    public partial class OrdersAndItemsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Order>>(0);
            __builder.AddAttribute(1, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Order>>(
#nullable restore
#line 4 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrdersAndItemsComponent.razor"
                   orderViewModel.Orders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ExpandMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridExpandMode>(
#nullable restore
#line 4 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrdersAndItemsComponent.razor"
                                                                    DataGridExpandMode.Single

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Order>)((order) => (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<OrderItem>>(4);
                __builder2.AddAttribute(5, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderItem>>(
#nullable restore
#line 6 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrdersAndItemsComponent.razor"
                           order.OrderItems

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderItem>>(7);
                    __builder3.AddAttribute(8, "Property", "Id");
                    __builder3.AddAttribute(9, "Title", "ID");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderItem>>(11);
                    __builder3.AddAttribute(12, "Property", "ItemName");
                    __builder3.AddAttribute(13, "Title", "Item Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(14, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderItem>>(15);
                    __builder3.AddAttribute(16, "Property", "Qty");
                    __builder3.AddAttribute(17, "Title", "Qty");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderItem>>(19);
                    __builder3.AddAttribute(20, "Property", "Price");
                    __builder3.AddAttribute(21, "Title", "Price");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(22, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Order>>(23);
                __builder2.AddAttribute(24, "Property", "Id");
                __builder2.AddAttribute(25, "Title", "ID");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Order>>(27);
                __builder2.AddAttribute(28, "Property", "Description");
                __builder2.AddAttribute(29, "Title", "Description");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Order>>(31);
                __builder2.AddAttribute(32, "Property", "Date");
                __builder2.AddAttribute(33, "Title", "Date");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrdersAndItemsComponent.razor"
       
    protected override async Task OnInitializedAsync()
    {
        orderViewModel.LoadAllOrders();
    }

    //void RowRender(RowRenderEventArgs<Order> args)
    //{
    //    args.Expandable = args.Data.ShipCountry == "France" || args.Data.ShipCountry == "Brazil";
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IOrderViewModel orderViewModel { get; set; }
    }
}
#pragma warning restore 1591
