#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db33fb5796c96eca3c502bcc953489f631a82bc"
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
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
    public partial class OrderItemPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Order Item</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "item-body");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
            __builder.AddAttribute(8, "Text", "Existing Part?");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-lg-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenSwitch>(12);
            __builder.AddAttribute(13, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
                                                         switchValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => switchValue = __value, switchValue))));
            __builder.AddAttribute(15, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => switchValue));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
#nullable restore
#line 11 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
__builder.AddContent(17, switchValue);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
     if(switchValue == true)       
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(22);
            __builder.AddAttribute(23, "Text", "Select Part");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-lg-12");
            __Blazor.SACOMaintenance.Blazor.Server.Pages.OrderPages.OrderItemPage.TypeInference.CreateCbDropDown_0(__builder, 29, 30, 
#nullable restore
#line 29 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
                                    partViewModel.parts

#line default
#line hidden
#nullable disable
            , 31, "Id", 32, "Name", 33, 
#nullable restore
#line 30 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
                                                                                                false

#line default
#line hidden
#nullable disable
            , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 30 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
                                                                                                                         LoadSinglePart

#line default
#line hidden
#nullable disable
            ), 35, 
#nullable restore
#line 30 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
                                                                            selectedid

#line default
#line hidden
#nullable disable
            , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedid = __value, selectedid)));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-lg-12");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "row");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(45);
            __builder.AddAttribute(46, "Text", "Item Name");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextBox>(52);
            __builder.AddAttribute(53, "Style", "width: 100%");
            __builder.AddAttribute(54, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
                                                itemtoadd.ItemName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => itemtoadd.ItemName = __value, itemtoadd.ItemName))));
            __builder.AddAttribute(56, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => itemtoadd.ItemName));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "row");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-lg-6");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(62);
            __builder.AddAttribute(63, "Text", "Quantity");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-lg-6");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(66);
            __builder.AddAttribute(67, "Text", "Price");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "row");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "col-lg-6");
            __builder.OpenComponent<Radzen.Blazor.RadzenNumeric<int>>(73);
            __builder.AddAttribute(74, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 57 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
                                                                 itemtoadd.Qty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => itemtoadd.Qty = __value, itemtoadd.Qty))));
            __builder.AddAttribute(76, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => itemtoadd.Qty));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-lg-6");
            __builder.OpenComponent<Radzen.Blazor.RadzenNumeric<decimal>>(80);
            __builder.AddAttribute(81, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<decimal>(
#nullable restore
#line 60 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
                                                                     itemtoadd.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<decimal>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => itemtoadd.Price = __value, itemtoadd.Price))));
            __builder.AddAttribute(83, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<decimal>>>(() => itemtoadd.Price));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "row");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(89);
            __builder.AddAttribute(90, "Text", "Description");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenTextArea>(94);
            __builder.AddAttribute(95, "Style", "width: 100%");
            __builder.AddAttribute(96, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
                                                 itemtoadd.Comments

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => itemtoadd.Comments = __value, itemtoadd.Comments))));
            __builder.AddAttribute(98, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => itemtoadd.Comments));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "    \r\n            ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "row");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "col-lg-3");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(104);
            __builder.AddAttribute(105, "Text", "Save");
            __builder.AddAttribute(106, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
                                                                        args => AddItem()

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "col-lg-3");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(110);
            __builder.AddAttribute(111, "Text", "Cancel");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\OrderPages\OrderItemPage.razor"
       
    bool switchValue;

    [Parameter]
    public string Content { get; set; } = string.Empty;

    [Parameter]
    public List<OrderItem> OrderItems { get; set; } = new();

    [Parameter]
    public EventCallback<List<OrderItem>> OrderItemsChanged { get; set; } 

    [Parameter]
    public EventCallback<List<OrderItem>> OnClickCallback {get;set;}

    public OrderItem itemtoadd = new();

    public string selectedid { get; set; }

    public void AddItem()
    {
        OrderItems.Add(itemtoadd);
        itemtoadd = new();
        OrderItemsChanged.InvokeAsync(OrderItems);
        OnClickCallback.InvokeAsync(OrderItems);
    }

    public void LoadSinglePart()
    {
        Task.Run(async () => { await partViewModel.LoadSinglePart(Convert.ToInt32(selectedid)); }).Wait();
        itemtoadd = new();
        if(partViewModel.SelectedPart != null)
        {
            itemtoadd.ItemName = partViewModel.SelectedPart.Name;
            itemtoadd.Comments = partViewModel.SelectedPart.Comment;          
        }
    }

    void LoadParts()
    {
        Task.Run(async () => { await partViewModel.LoadAllParts(); }).Wait();

    }

    Part partSelected = new();
    //string partIdSelected;

    public List<string> Testing = new();


    private void SelectedItemChosen(Part part)
    {
        //partSelected = part;
        //partIdSelected = partSelected.Id.ToString();
    }

    protected override async Task OnInitializedAsync()
    {
        Task.Run(async () => { await partViewModel.LoadAllParts(); }).Wait();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IPartViewModel partViewModel { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Pages.OrderPages.OrderItemPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCbDropDown_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<global::System.String> __arg6)
        {
        __builder.OpenComponent<global::SACOMaintenance.Blazor.Server.Shared.CbDropDown<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ValueId", __arg1);
        __builder.AddAttribute(__seq2, "Text", __arg2);
        __builder.AddAttribute(__seq3, "Search", __arg3);
        __builder.AddAttribute(__seq4, "OnClickCallback", __arg4);
        __builder.AddAttribute(__seq5, "SelectedItem", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItemChanged", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
