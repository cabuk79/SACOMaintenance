#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b0731d8a35a86e0301844f347823a8f9fac1d12"
// <auto-generated/>
#pragma warning disable 1591
namespace SACOMaintenance.Blazor.Server.Pages.ReqInititation
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
#line 5 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
using SACOMaintenance.Blazor.Server.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/maint-req/add")]
    public partial class AddMaintReq : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddMarkupContent(4, "<div class=\"row\"><div class=\"col-lg-12\"><h3>Add New Maintenance Request</h3></div></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(9);
            __builder.AddAttribute(10, "Text", "Enter Request Details");
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(16);
                __builder2.AddAttribute(17, "Text", "Priority");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(19);
                __builder2.AddAttribute(20, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(22, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 25 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                               FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.StringFilterOperator>(
#nullable restore
#line 26 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                                                  StringFilterOperator.Contains

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 28 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                               AddReqViewModel.Priorities

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "TextProperty", "Name");
                __builder2.AddAttribute(27, "ValueProperty", "Id");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                      AddReqViewModel.PriorityId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddReqViewModel.PriorityId = __value, AddReqViewModel.PriorityId))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => AddReqViewModel.PriorityId));
                __builder2.AddAttribute(31, "Template", (Microsoft.AspNetCore.Components.RenderFragment<dynamic>)((context) => (__builder3) => {
                    __builder3.OpenElement(32, "div");
                    __builder3.AddAttribute(33, "class", "row");
                    __builder3.OpenElement(34, "div");
                    __builder3.AddAttribute(35, "class", "col-lg-1");
                    __builder3.OpenElement(36, "i");
                    __builder3.AddAttribute(37, "class", 
#nullable restore
#line 32 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                    (context as Priority).Icon

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n                                    ");
                    __builder3.OpenElement(39, "div");
                    __builder3.AddAttribute(40, "class", "col-lg-5");
                    __builder3.AddContent(41, 
#nullable restore
#line 35 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                          (context as Priority).Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(45);
                __builder2.AddAttribute(46, "Text", "Company");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(48);
                __builder2.AddAttribute(49, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(51, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 44 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                               FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.StringFilterOperator>(
#nullable restore
#line 45 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                                                 StringFilterOperator.Contains

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 47 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                               AddReqViewModel.Companies

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "TextProperty", "CompanyName");
                __builder2.AddAttribute(56, "ValueProperty", "Id");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 45 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                      AddReqViewModel.CompanyId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddReqViewModel.CompanyId = __value, AddReqViewModel.CompanyId))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => AddReqViewModel.CompanyId));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "row");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(65);
                __builder2.AddAttribute(66, "Text", "Factory");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(68);
                __builder2.AddAttribute(69, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(71, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 55 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                               FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.StringFilterOperator>(
#nullable restore
#line 56 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                                                 StringFilterOperator.Contains

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 57 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 58 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                               AddReqViewModel.Factories

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "TextProperty", "FactoryName");
                __builder2.AddAttribute(76, "ValueProperty", "Id");
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 56 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                      AddReqViewModel.FactoryId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddReqViewModel.FactoryId = __value, AddReqViewModel.FactoryId))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => AddReqViewModel.FactoryId));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-lg-4");
#nullable restore
#line 62 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                         if (AddReqViewModel.Areas != null)
                        {
                            var numberAreasEquipment = AddReqViewModel.Areas.Count();
                            if (numberAreasEquipment > 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(83);
                __builder2.AddAttribute(84, "Text", "Area");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n                                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(86);
                __builder2.AddAttribute(87, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 68 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(89, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 69 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                       FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.StringFilterOperator>(
#nullable restore
#line 70 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                                                      StringFilterOperator.Contains

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 71 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 72 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                       AddReqViewModel.Areas

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "TextProperty", "AreaName");
                __builder2.AddAttribute(94, "ValueProperty", "Id");
                __builder2.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 70 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                              AddReqViewModel.AreaId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddReqViewModel.AreaId = __value, AddReqViewModel.AreaId))));
                __builder2.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => AddReqViewModel.AreaId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n                                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(99);
                __builder2.AddAttribute(100, "Text", "If the area is want is not in the list please contact maintenance!");
                __builder2.CloseComponent();
#nullable restore
#line 75 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-lg-4");
#nullable restore
#line 79 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                         if (AddReqViewModel.Equipment != null)
                        {
                            var numberEuipmentItems = AddReqViewModel.Equipment.Count();
                            if (numberEuipmentItems > 0)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(104);
                __builder2.AddAttribute(105, "Text", "Equipment");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\r\n                                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(107);
                __builder2.AddAttribute(108, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 85 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "Style", "width: 100%; border-color: black");
                __builder2.AddAttribute(110, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 86 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                       FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.StringFilterOperator>(
#nullable restore
#line 87 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                                                           StringFilterOperator.Contains

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(112, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 88 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(113, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 89 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                       AddReqViewModel.Equipment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "TextProperty", "Name");
                __builder2.AddAttribute(115, "ValueProperty", "Id");
                __builder2.AddAttribute(116, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 87 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                              AddReqViewModel.EquipmentId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(117, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddReqViewModel.EquipmentId = __value, AddReqViewModel.EquipmentId))));
                __builder2.AddAttribute(118, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => AddReqViewModel.EquipmentId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n                                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(120);
                __builder2.AddAttribute(121, "Text", "If the area is want is not in the list please contact maintenance!");
                __builder2.CloseComponent();
#nullable restore
#line 92 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "row");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "col-lg-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenHtmlEditor>(127);
                __builder2.AddAttribute(128, "Style", "height: 500px; border-color: black");
                __builder2.AddAttribute(129, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 98 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                       AddReqViewModel.MaintReq.RequestDetails

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(130, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddReqViewModel.MaintReq.RequestDetails = __value, AddReqViewModel.MaintReq.RequestDetails))));
                __builder2.AddAttribute(131, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AddReqViewModel.MaintReq.RequestDetails));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "row");
                __builder2.OpenElement(135, "div");
                __builder2.AddAttribute(136, "class", "col-lg-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(137);
                __builder2.AddAttribute(138, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                              UpdateBook

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(139, "Text", "Save New Request");
                __builder2.AddAttribute(140, "Icon", "save");
                __builder2.AddAttribute(141, "Style", "margin-bottom: 20px; width: 200px");
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
#line 111 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
       

    private HubConnection hubConnection;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
            .Build();

        await hubConnection.StartAsync();
    }

    protected async Task UpdateBook()
    {
        //hubConnection = new HubConnectionBuilder()
        //    .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
        //    .Build();

        //await hubConnection.StartAsync();

        AddReqViewModel.AddNewRequest();

        //Check if the prisority is emergency then send text to let someone know
        if(AddReqViewModel.PriorityId == 1)
        {
            Equipment equipName = AddReqViewModel.Equipment.Where(i => i.Id == AddReqViewModel.MaintReq.EquipmentId).FirstOrDefault();

            if(AddReqViewModel.SendTextMessageForEmergencyPriority == true)
            {
                string message = "MAINT-" + AddReqViewModel.NewAddedMaintId.ToString("D4") +
                " has just been added and is either buisness crirtical or danger to life or health.  Please review ASAP!!!\n\n\nEquipment: "
                + equipName.Name + "\n\nDetails:\n" + AddReqViewModel.MaintReq.RequestDetails;

                var respone = SmsService.SendSms("447432 556452", "SACO Maint", message);
                string MessageId = respone.Messages[0].MessageId;
            }
            //var responOne = SmsService.SendSms("447432556452", "SACO Maint", message);
            //string MessageIdTwo = respone.Messages[0].MessageId;
        }

        if (IsConnected) await SendMessage();

        ShowNotification(new NotificationMessage
        {
            Severity = NotificationSeverity.Success,
            Summary = "Saved",
            Detail = "New maintenance request saved to database!",
            Duration = 4000
        });
    }

    void ShowNotification(NotificationMessage message)
    {
        NotificationService.Notify(message);
    }

    Task SendMessage() => hubConnection.SendAsync("SendMessage");

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SmsService SmsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IMaintReqNewViewModel AddReqViewModel { get; set; }
    }
}
#pragma warning restore 1591
