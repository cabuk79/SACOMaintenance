#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bcc98026989caf187082648dc974c4d935b5cfa"
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
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
using SACOMaintenance.Blazor.Server.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/maint-req/full-add/{MaintReqID}")]
    public partial class MaintReqFull : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Maintenance Request ");
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                         maintReqInitation.maintReqId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(4);
            __builder.AddAttribute(5, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                      args => maintReqInitation.ExportRequest()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "Text", "Create Request Form Word");
            __builder.AddAttribute(7, "Icon", "import_export");
            __builder.AddAttribute(8, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 10 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "container-fluid");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-lg-12");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-lg-6");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(24);
            __builder.AddAttribute(25, "Text", "Details");
            __builder.AddAttribute(26, "Style", "border-color: black");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "row");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(32);
                __builder2.AddAttribute(33, "Style", "font-weight: bold");
                __builder2.AddAttribute(34, "Text", "Factory");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                                    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(38);
                __builder2.AddAttribute(39, "Style", "font-weight: bold");
                __builder2.AddAttribute(40, "Text", "Area");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                                    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(44);
                __builder2.AddAttribute(45, "Style", "font-weight: bold");
                __builder2.AddAttribute(46, "Text", "Equipment");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "row");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-lg-4");
                __builder2.OpenElement(52, "span");
                __builder2.AddContent(53, 
#nullable restore
#line 29 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                 maintReqInitation.factoryName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-lg-4");
                __builder2.OpenElement(57, "span");
                __builder2.AddContent(58, 
#nullable restore
#line 30 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                 maintReqInitation.areaName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-lg-4");
                __builder2.OpenElement(62, "span");
                __builder2.AddContent(63, 
#nullable restore
#line 31 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                 maintReqInitation.equipName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "row");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "col-lg-12");
                __builder2.AddMarkupContent(69, "<div class=\"row\"><div class=\"col-lg-12\"><label style=\"font-weight:bold\">Details</label></div></div>\r\n                                        ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "row");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-lg-12");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "card text-black");
                __builder2.AddAttribute(76, "style", "width: 100%");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "card-body");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "row");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-lg-12");
                __builder2.AddContent(83, 
#nullable restore
#line 46 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                  (MarkupString)detailMarkUp

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.OpenElement(85, "dicv");
            __builder.AddAttribute(86, "class", "row");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(89);
            __builder.AddAttribute(90, "Text", "Isolations");
            __builder.AddAttribute(91, "Style", "border-color: black");
            __builder.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "row");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "col-lg-12");
                __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.MaintReqFull.TypeInference.CreateCheckListBox_0(__builder2, 97, 98, 
#nullable restore
#line 63 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                             maintReqInitation.Isolations

#line default
#line hidden
#nullable disable
                , 99, 
#nullable restore
#line 64 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                   (item)=>item.Name

#line default
#line hidden
#nullable disable
                , 100, 
#nullable restore
#line 65 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                    (item)=>item.Id

#line default
#line hidden
#nullable disable
                , 101, 
#nullable restore
#line 66 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                        maintReqInitation.SelectedIsolationIds

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "col-lg-6");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "row");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(109);
            __builder.AddAttribute(110, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                  UpdateRisks

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(111, "\r\n                            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(112);
            __builder.AddAttribute(113, "Text", "Risk Assemssment");
            __builder.AddAttribute(114, "Style", "border-color: black");
            __builder.AddAttribute(115, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<MaintRequestInitiationRisk>>(116);
                __builder2.AddAttribute(117, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<MaintRequestInitiationRisk>>(
#nullable restore
#line 98 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                   maintReqInitation.RiskInfoList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(118, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiationRisk>>(119);
                    __builder3.AddAttribute(120, "Property", "RiskId");
                    __builder3.AddAttribute(121, "Title", "Risk Name");
                    __builder3.AddAttribute(122, "Width", "15px");
                    __builder3.AddAttribute(123, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiationRisk>)((data) => (__builder4) => {
#nullable restore
#line 102 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                 foreach (var riskItem in maintReqInitation.Risks)
                                                {
                                                    if (riskItem.Id == data.RiskId)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(124, 
#nullable restore
#line 106 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                         riskItem.RiskName

#line default
#line hidden
#nullable disable
                        );
#nullable restore
#line 106 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                          
                                                    }
                                                }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(125, "\r\n                                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiationRisk>>(126);
                    __builder3.AddAttribute(127, "Property", "RiskLevel");
                    __builder3.AddAttribute(128, "Title", "H");
                    __builder3.AddAttribute(129, "Width", "10px");
                    __builder3.AddAttribute(130, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiationRisk>)((data) => (__builder4) => {
#nullable restore
#line 113 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                 if (data.M == true || data.L == true)
                                                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(131);
                        __builder4.AddAttribute(132, "Style", "border-color: black");
                        __builder4.AddAttribute(133, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 115 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(134, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 115 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                 data.H

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(135, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => data.H = __value, data.H))));
                        __builder4.AddAttribute(136, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => data.H));
                        __builder4.CloseComponent();
#nullable restore
#line 116 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(137);
                        __builder4.AddAttribute(138, "Style", "border-color: black");
                        __builder4.AddAttribute(139, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 119 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                 data.H

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(140, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => data.H = __value, data.H))));
                        __builder4.AddAttribute(141, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => data.H));
                        __builder4.CloseComponent();
#nullable restore
#line 120 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(142, "\r\n                                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiationRisk>>(143);
                    __builder3.AddAttribute(144, "Property", "RiskLevel");
                    __builder3.AddAttribute(145, "Title", "M");
                    __builder3.AddAttribute(146, "Width", "10px");
                    __builder3.AddAttribute(147, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiationRisk>)((data) => (__builder4) => {
#nullable restore
#line 125 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                 if (data.H == true || data.L == true)
                                                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(148);
                        __builder4.AddAttribute(149, "Style", "border-color: black");
                        __builder4.AddAttribute(150, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 127 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(151, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 127 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                 data.M

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(152, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => data.M = __value, data.M))));
                        __builder4.AddAttribute(153, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => data.M));
                        __builder4.CloseComponent();
#nullable restore
#line 128 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(154);
                        __builder4.AddAttribute(155, "Style", "border-color: black");
                        __builder4.AddAttribute(156, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 131 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                 data.M

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(157, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => data.M = __value, data.M))));
                        __builder4.AddAttribute(158, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => data.M));
                        __builder4.CloseComponent();
#nullable restore
#line 132 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(159, "\r\n                                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiationRisk>>(160);
                    __builder3.AddAttribute(161, "Property", "RiskLevel");
                    __builder3.AddAttribute(162, "Title", "L");
                    __builder3.AddAttribute(163, "Width", "10px");
                    __builder3.AddAttribute(164, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiationRisk>)((data) => (__builder4) => {
#nullable restore
#line 137 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                 if (data.H == true || data.M == true)
                                                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(165);
                        __builder4.AddAttribute(166, "Style", "border-color: black");
                        __builder4.AddAttribute(167, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 139 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                                                                             true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(168, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 139 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                 data.L

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(169, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => data.L = __value, data.L))));
                        __builder4.AddAttribute(170, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => data.L));
                        __builder4.CloseComponent();
#nullable restore
#line 140 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(171);
                        __builder4.AddAttribute(172, "Style", "border-color: black");
                        __builder4.AddAttribute(173, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 143 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                 data.L

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(174, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => data.L = __value, data.L))));
                        __builder4.AddAttribute(175, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<bool>>>(() => data.L));
                        __builder4.CloseComponent();
#nullable restore
#line 144 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n    ");
            __builder.OpenElement(177, "div");
            __builder.AddAttribute(178, "class", "row");
            __builder.OpenElement(179, "div");
            __builder.AddAttribute(180, "class", "col-lg-12");
#nullable restore
#line 158 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
             if (maintReqInitation.maintReqAreaId == 1)  //This ID 1 refers to the plant Area so either plant 1 or 2
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                                               
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SACOMaintenance.Blazor.Server.Pages.ReqInititation.GeneralMaintReqComponent>(181);
            __builder.AddAttribute(182, "maintReq", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SACOMaintenance.Common.ModelDB.MaintRequestInitiation>(
#nullable restore
#line 164 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                    maintReqInitation.maintReqInitation

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 165 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
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
#line 233 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
       
    [Parameter]
    public string maintReqID { get; set; }

    string detailMarkUp;

    string value = "";


    public void Testing()
    {

    }


    protected async Task UpdateRisks()
    {
        maintReqInitation.UpdateMaintReqRisks();
    }

    public bool moveCol = false;

    public enum RiskLevelLetter { H, M, L }

    protected override void OnInitialized()
    {
        maintReqInitation.GetMaintReqInitation(Convert.ToInt32(maintReqID));

        // maintReqInitation.LoadRiskLevel(Convert.ToInt32(maintReqID));

        maintReqInitation.LoadFactories();

        maintReqInitation.LoadRisks();

        maintReqInitation.LoadMaintRiskData(maintReqInitation.maintReqId);
        maintReqInitation.LoadIsolations();
        maintReqInitation.LoadIsoaltionsByMaint();

        detailMarkUp = maintReqInitation.maintReqDetails;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IMaintRequestFullViewModel maintReqInitation { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.MaintReqFull
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCheckListBox_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Func<TItem, global::System.String> __arg1, int __seq2, global::System.Func<TItem, global::System.Object> __arg2, int __seq3, global::System.Collections.Generic.List<global::System.String> __arg3)
        {
        __builder.OpenComponent<global::SACOMaintenance.Blazor.Server.Shared.CheckListBox<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "TextField", __arg1);
        __builder.AddAttribute(__seq2, "ValueField", __arg2);
        __builder.AddAttribute(__seq3, "SelectedValues", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
