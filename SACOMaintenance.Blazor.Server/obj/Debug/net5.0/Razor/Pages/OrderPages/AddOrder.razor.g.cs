#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "190042a7f1e196f1f11041307f69e2450ca162cd"
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
#line 13 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addneworder")]
    public partial class AddOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "<div class=\"row\"><div class=\"col-lg-12\"><h3>Adding new order</h3>\r\n            <hr></div></div>\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
            __builder.AddAttribute(8, "Text", "Date Test");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-lg-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(12);
            __builder.AddAttribute(13, "Text", "Supplier");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-lg-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
            __builder.AddAttribute(18, "Text", "Department");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-lg-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenDatePicker<DateTime?>>(24);
            __builder.AddAttribute(25, "DateFormat", "d");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-lg-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(29);
            __builder.AddAttribute(30, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 21 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
                                                orderViewModel.Suppliers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "TextProperty", "Name");
            __builder.AddAttribute(32, "ValueProperty", "Id");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-lg-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(36);
            __builder.AddAttribute(37, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 25 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
                                                orderViewModel.Departments

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "TextProperty", "Name");
            __builder.AddAttribute(39, "ValueProperty", "Id");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "row");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(45);
            __builder.AddAttribute(46, "Text", "Description");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextArea>(52);
            __builder.AddAttribute(53, "Style", "width: 100%");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "col-lg-2");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "type", "button");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
                                                              (() => Showdialog())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Add Item");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "row");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(68);
            __builder.AddAttribute(69, "Text", "Items in order");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "row");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<OrderItem>>(75);
            __builder.AddAttribute(76, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<OrderItem>>(
#nullable restore
#line 44 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
                                                 OrderItemsList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderItem>>(78);
                __builder2.AddAttribute(79, "Title", "Item Name");
                __builder2.AddAttribute(80, "Property", "ItemName");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderItem>>(82);
                __builder2.AddAttribute(83, "Title", "Description");
                __builder2.AddAttribute(84, "Property", "Comments");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderItem>>(86);
                __builder2.AddAttribute(87, "Title", "Qty");
                __builder2.AddAttribute(88, "Property", "Qty");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(89, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderItem>>(90);
                __builder2.AddAttribute(91, "Title", "Price");
                __builder2.AddAttribute(92, "Property", "Price");
                __builder2.AddAttribute(93, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderItem>)((price) => (__builder3) => {
#nullable restore
#line 52 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
__builder3.AddContent(94, String.Format(new System.Globalization.CultureInfo("en-GB"), "{0:C}", price.Price));

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<OrderItem>>(96);
                __builder2.AddAttribute(97, "Title", "Total Price Per Part");
                __builder2.AddAttribute(98, "Property", "FullPrice");
                __builder2.AddAttribute(99, "Template", (Microsoft.AspNetCore.Components.RenderFragment<OrderItem>)((fullPrice) => (__builder3) => {
#nullable restore
#line 57 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
__builder3.AddContent(100, String.Format(new System.Globalization.CultureInfo("en-GB"), "{0:C}", fullPrice.FullPrice));

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.AddAttribute(101, "FooterTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(102, "\r\n                            Order Total: ");
                    __builder3.OpenElement(103, "b");
#nullable restore
#line 60 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
__builder3.AddContent(104, String.Format(new System.Globalization.CultureInfo("en-GB"), "{0:C}", OrderItemsList.Sum(o => o.FullPrice)));

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(105, (__value) => {
#nullable restore
#line 44 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
                                                                       OrderItemsTable = (Radzen.Blazor.RadzenGrid<OrderItem>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "row");
            __builder.AddAttribute(109, "style", "margin: 5px 5px 5px 0px");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "col-lg-2");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(112);
            __builder.AddAttribute(113, "Text", "Save");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n        ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-lg-2");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(117);
            __builder.AddAttribute(118, "Text", "Close");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
 if(ShowPopup)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "modal");
            __builder.AddAttribute(121, "tabindex", "-1");
            __builder.AddAttribute(122, "style", "display:block");
            __builder.AddAttribute(123, "role", "dialog");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "modal-dialog");
            __builder.AddAttribute(126, "style", "border-color: black");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "modal-content");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "modal-body");
            __builder.OpenComponent<SACOMaintenance.Blazor.Server.Pages.OrderPages.OrderItemPage>(131);
            __builder.AddAttribute(132, "OnClickCallback", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.List<SACOMaintenance.Common.ModelDB.OrderItem>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.List<SACOMaintenance.Common.ModelDB.OrderItem>>(this, 
#nullable restore
#line 81 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
                                      UpdatePage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(133, "CloseDialogCallback", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 81 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
                                                                        CloseDialog

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(134, "OrderItems", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SACOMaintenance.Common.ModelDB.OrderItem>>(
#nullable restore
#line 80 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
                                                     OrderItemsList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(135, "OrderItemsChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.List<SACOMaintenance.Common.ModelDB.OrderItem>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.List<SACOMaintenance.Common.ModelDB.OrderItem>>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => OrderItemsList = __value, OrderItemsList))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\AddOrder.razor"
       
    public List<OrderItem> OrderItemsList = new List<OrderItem>();
    public RadzenGrid<OrderItem> OrderItemsTable = new();

    bool ShowPopup = false;

    protected override async Task OnInitializedAsync()
    {
        Task.Run(async () => { await orderViewModel.LoadSuppliers(); }).Wait();
        Task.Run(async () => { await orderViewModel.LoadDepartments(); }).Wait();
        
        OrderItem testingitem = new();
        testingitem.Comments = "ttttest";
        OrderItemsList.Add(testingitem);

    }

    public void UpdatePage()
    {
        OrderItemsTable.Reload();
    }


    void Showdialog()
    {
        ShowPopup = true;
    }

    void CloseDialog()
    {
        ShowPopup = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IOrderViewModel orderViewModel { get; set; }
    }
}
#pragma warning restore 1591