#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca61d0879653610000221834b1362a6bb4aa503"
// <auto-generated/>
#pragma warning disable 1591
namespace SACOMaintenance.Blazor.Server.Pages.SuppliersPages
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
#line 4 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/supplier/add")]
    public partial class AddSupplierPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddAttribute(4, "style", "padding: 5px 0px 10px 5px");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg-4");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(7);
            __builder.AddAttribute(8, "Text", "Add New Supplier - Fill in the Details Below");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(14);
            __builder.AddAttribute(15, "Text", "Address Information");
            __builder.AddAttribute(16, "Style", "border-color: black; height: max-content");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "row");
                __builder2.AddAttribute(20, "style", "padding: 5px 5px 5px 5px");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-lg-6");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "row");
                __builder2.AddAttribute(25, "style", "padding: 5px 5px 5px 5px");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(28);
                __builder2.AddAttribute(29, "Text", "Name");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-lg-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(33);
                __builder2.AddAttribute(34, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(35, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                supplierViewModel.NewSupplier.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplierViewModel.NewSupplier.Name = __value, supplierViewModel.NewSupplier.Name))));
                __builder2.AddAttribute(37, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplierViewModel.NewSupplier.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "row");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(43);
                __builder2.AddAttribute(44, "Text", "Address One");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-lg-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(48);
                __builder2.AddAttribute(49, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(50, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                supplierViewModel.NewSupplier.AddressLineOne

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplierViewModel.NewSupplier.AddressLineOne = __value, supplierViewModel.NewSupplier.AddressLineOne))));
                __builder2.AddAttribute(52, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplierViewModel.NewSupplier.AddressLineOne));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "row");
                __builder2.AddAttribute(56, "style", "padding: 5px 5px 5px 5px");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(59);
                __builder2.AddAttribute(60, "Text", "Address Two");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                                ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col-lg-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(64);
                __builder2.AddAttribute(65, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(66, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                supplierViewModel.NewSupplier.AddressLineTwo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplierViewModel.NewSupplier.AddressLineTwo = __value, supplierViewModel.NewSupplier.AddressLineTwo))));
                __builder2.AddAttribute(68, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplierViewModel.NewSupplier.AddressLineTwo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                            ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "row");
                __builder2.AddAttribute(72, "style", "padding: 5px 5px 5px 5px");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(75);
                __builder2.AddAttribute(76, "Text", "County");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                                ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col-lg-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(80);
                __builder2.AddAttribute(81, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(82, "ReadOnly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                supplierViewModel.NewSupplier.Postcode.County

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplierViewModel.NewSupplier.Postcode.County = __value, supplierViewModel.NewSupplier.Postcode.County))));
                __builder2.AddAttribute(85, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplierViewModel.NewSupplier.Postcode.County));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                            ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "row");
                __builder2.AddAttribute(89, "style", "padding: 5px 5px 5px 5px");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(92);
                __builder2.AddAttribute(93, "Text", "Town");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                                ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-lg-8");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(97);
                __builder2.AddAttribute(98, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(99, "ReadOnly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                supplierViewModel.NewSupplier.Postcode.District

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplierViewModel.NewSupplier.Postcode.District = __value, supplierViewModel.NewSupplier.Postcode.District))));
                __builder2.AddAttribute(102, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplierViewModel.NewSupplier.Postcode.District));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                            ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "row");
                __builder2.AddAttribute(106, "style", "padding: 5px 5px 5px 5px");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(109);
                __builder2.AddAttribute(110, "Text", "Post Code");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                                ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(114);
                __builder2.AddAttribute(115, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(116, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                supplierViewModel.NewSupplier.Postcode.PostCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(117, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplierViewModel.NewSupplier.Postcode.PostCode = __value, supplierViewModel.NewSupplier.Postcode.PostCode))));
                __builder2.AddAttribute(118, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplierViewModel.NewSupplier.Postcode.PostCode));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                                    ");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(122);
                __builder2.AddAttribute(123, "Text", "Search");
                __builder2.AddAttribute(124, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                            args => PostCodeOnChange(supplierViewModel.NewSupplier.Postcode.PostCode)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n                                ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "row");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "col-lg-12");
#nullable restore
#line 62 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                         if (hasFoundPostCodeError == true)
                                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(130);
                __builder2.AddAttribute(131, "Style", "color: red");
                __builder2.AddAttribute(132, "Text", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                                   postCodeFoundError

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 65 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                                ");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "row");
                __builder2.AddAttribute(136, "style", "padding: 5px 5px 5px 5px");
                __builder2.OpenElement(137, "div");
                __builder2.AddAttribute(138, "class", "col-lg-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(139);
                __builder2.AddAttribute(140, "Text", "Comment");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                                    ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "col-lg-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditor>(144);
                __builder2.AddAttribute(145, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 70 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                                          supplierViewModel.NewSupplier.Comments

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(146, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplierViewModel.NewSupplier.Comments = __value, supplierViewModel.NewSupplier.Comments))));
                __builder2.AddAttribute(147, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplierViewModel.NewSupplier.Comments));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "\r\n                                ");
                __builder2.OpenElement(149, "div");
                __builder2.AddAttribute(150, "class", "row");
                __builder2.OpenElement(151, "div");
                __builder2.AddAttribute(152, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(153);
                __builder2.AddAttribute(154, "Text", "SAVE");
                __builder2.AddAttribute(155, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                                             args => AddNewSupplier()

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n                        ");
                __builder2.OpenElement(157, "div");
                __builder2.AddAttribute(158, "class", "col-lg-6");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(159);
                __builder2.AddAttribute(160, "Zoom", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 78 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                  15

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(161, "ApiKey", "AIzaSyB69EiMRd7IfrT6PK_0T-6H-ESsf8YakMM");
                __builder2.AddAttribute(162, "Center", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 79 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                      new GoogleMapPosition()
                                                  {
                                                      Lat = Convert.ToDouble(supplierViewModel.NewSupplier.Postcode.Latitide),
                                                      Lng = Convert.ToDouble(supplierViewModel.NewSupplier.Postcode.Longitude)
                                                  }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(163, "Markers", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(164);
                    __builder3.AddAttribute(165, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 85 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                   supplierViewModel.NewSupplier.Postcode.District

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(166, "Label", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 86 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                   supplierViewModel.NewSupplier.Postcode.District

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(167, "Position", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 87 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
                                                                      new GoogleMapPosition()
                                                                  {
                                                                      Lat = Convert.ToDouble(supplierViewModel.NewSupplier.Postcode.Latitide),
                                                                      Lng = Convert.ToDouble(supplierViewModel.NewSupplier.Postcode.Longitude)
                                                                  }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\SuppliersPages\AddSupplierPage.razor"
           
        [Parameter]
        public string Id { get; set; }

        string postCodeFoundError;
        bool hasFoundPostCodeError = false;

        protected override void OnInitialized()
        {
            supplierViewModel.CreateEmptySupplier();           
        }

        void AddNewSupplier()
        {
            supplierViewModel.AddNewSupplier();
            NavigationManager.NavigateTo("suppliers-list");
        }


        void PostCodeOnChange(string value)
        {
            supplierViewModel.postcodefound(value, "New");

            if (supplierViewModel.NewSupplier.Postcode.Id == 0)
            {
                postCodeFoundError = "Sorry no post code could be found!";
                hasFoundPostCodeError = true;
            }
            else
            {
                hasFoundPostCodeError = false;
            }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.ISupplierViewModel supplierViewModel { get; set; }
    }
}
#pragma warning restore 1591
