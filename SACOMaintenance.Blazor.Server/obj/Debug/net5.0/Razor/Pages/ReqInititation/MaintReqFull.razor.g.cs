#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8ed068c3d5a4377c93f74579e2a943271c10f7a"
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
#line 13 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using System.Security.Claims;

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
#nullable restore
#line 5 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
using Microsoft.AspNetCore.SignalR.Client;

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
#nullable restore
#line 9 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
__builder.AddContent(2, maintReqInitation.maintReqId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(4);
            __builder.AddAttribute(5, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                      args => maintReqInitation.ExportRequest()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "Text", "Create Request Form Word");
            __builder.AddAttribute(7, "Icon", "import_export");
            __builder.AddAttribute(8, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 12 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(10);
            __builder.AddAttribute(11, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                      args => SaveRequestDetails()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "Text", "Save");
            __builder.AddAttribute(13, "class", "bottom-save-btn");
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "​btn btn-primary table-btn");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                     () => AssignStaff(maintReqInitation.maintReqId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "<span class=\"fa fa-plus\"></span> / <span class=\"fa fa-minus\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "container-fluid");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "row");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-lg-12");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-lg-12");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(34);
            __builder.AddAttribute(35, "Text", "Details");
            __builder.AddAttribute(36, "Style", "border-color: black");
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "row");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(42);
                __builder2.AddAttribute(43, "Style", "font-weight: bold");
                __builder2.AddAttribute(44, "Text", "Factory");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(48);
                __builder2.AddAttribute(49, "Style", "font-weight: bold");
                __builder2.AddAttribute(50, "Text", "Area");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                                    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(54);
                __builder2.AddAttribute(55, "Style", "font-weight: bold");
                __builder2.AddAttribute(56, "Text", "Equipment");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n                                ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "row");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-lg-4");
                __builder2.OpenElement(62, "span");
#nullable restore
#line 32 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
__builder2.AddContent(63, maintReqInitation.factoryName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col-lg-4");
                __builder2.OpenElement(67, "span");
#nullable restore
#line 33 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
__builder2.AddContent(68, maintReqInitation.areaName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                                    ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "col-lg-4");
                __builder2.OpenElement(72, "span");
#nullable restore
#line 34 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
__builder2.AddContent(73, maintReqInitation.equipName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                                ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "row");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-lg-12");
                __builder2.AddMarkupContent(79, "<div class=\"row\"><div class=\"col-lg-12\"><label style=\"font-weight:bold\">Details</label></div></div>\r\n                                        ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "row");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "col-lg-12");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "card text-black");
                __builder2.AddAttribute(86, "style", "width: 100%");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "card-body");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "row");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "col-lg-12");
#nullable restore
#line 49 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
__builder2.AddContent(93, (MarkupString)detailMarkUp);

#line default
#line hidden
#nullable disable
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
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "row");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(99);
            __builder.AddAttribute(100, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                          UpdateRisks

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(101, "\r\n                    ");
            __builder.OpenComponent<SACOMaintenance.Blazor.Server.Components.RequestRiskChoice>(102);
            __builder.AddAttribute(103, "Risks", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.ObjectModel.ObservableCollection<SACOMaintenance.Common.ModelDB.Risk>>(
#nullable restore
#line 66 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                                    maintReqInitation.Risks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "ItemsChosen", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SACOMaintenance.Common.ModelDB.MaintRequestInitiationRisk>>(
#nullable restore
#line 66 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                          maintReqInitation.RiskListsChosen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(105, "ItemsChosenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.List<SACOMaintenance.Common.ModelDB.MaintRequestInitiationRisk>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.List<SACOMaintenance.Common.ModelDB.MaintRequestInitiationRisk>>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => maintReqInitation.RiskListsChosen = __value, maintReqInitation.RiskListsChosen))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "row");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "col-lg-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(111);
            __builder.AddAttribute(112, "Text", "Isolations");
            __builder.AddAttribute(113, "Style", "border-color: black");
            __builder.AddAttribute(114, "AllowCollapse", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(115, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "row");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "col-lg-12 float-lg-right");
                __builder2.OpenElement(120, "ul");
#nullable restore
#line 76 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                     foreach (var item in maintReqInitation.IsolationsSelected)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(121, "li");
#nullable restore
#line 79 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
__builder2.AddContent(122, item.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 81 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                                ");
                __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.MaintReqFull.TypeInference.CreateSquareCheckBox_0(__builder2, 124, 125, 
#nullable restore
#line 83 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                       maintReqInitation.Isolations

#line default
#line hidden
#nullable disable
                , 126, 
#nullable restore
#line 84 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                    maintReqInitation.IsolationsSelected

#line default
#line hidden
#nullable disable
                , 127, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => maintReqInitation.IsolationsSelected = __value, maintReqInitation.IsolationsSelected)), 128, (Isolation) => (__builder3) => {
                    __builder3.OpenElement(129, "div");
                    __builder3.AddAttribute(130, "class", "row");
                    __builder3.OpenElement(131, "div");
                    __builder3.AddAttribute(132, "class", "col-lg-12");
                    __builder3.OpenElement(133, "img");
                    __builder3.AddAttribute(134, "src", 
#nullable restore
#line 88 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                           Isolation.ImageLocation

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(135, "alt", 
#nullable restore
#line 88 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                          Isolation.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(136, "width", "60");
                    __builder3.AddAttribute(137, "height", "60");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(138, "\r\n                                        ");
                    __builder3.OpenElement(139, "div");
                    __builder3.AddAttribute(140, "class", "row");
                    __builder3.OpenElement(141, "div");
                    __builder3.AddAttribute(142, "class", "col-lg-12");
#nullable restore
#line 93 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
__builder3.AddContent(143, Isolation.Name);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n    ");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "row");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "col-lg-12");
#nullable restore
#line 107 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
             if (maintReqInitation.maintReqAreaId == 1)  //This ID 1 refers to the plant Area so either plant 1 or 2
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                                               
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SACOMaintenance.Blazor.Server.Pages.ReqInititation.GeneralMaintReqComponent>(149);
            __builder.AddAttribute(150, "maintReq", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SACOMaintenance.Common.ModelDB.MaintRequestInitiation>(
#nullable restore
#line 113 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                   maintReqInitation.maintReqInitation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(151, "ReqReadOnly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 114 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                            false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(152, "ReqReadOnlyChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 115 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                   ReqChangeBool

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(153, (__value) => {
#nullable restore
#line 114 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                         GeneralChild = (SACOMaintenance.Blazor.Server.Pages.ReqInititation.GeneralMaintReqComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 116 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 122 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
 if (ShowPopupModal)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "modal");
            __builder.AddAttribute(156, "tabindex", "-1");
            __builder.AddAttribute(157, "style", "display:block");
            __builder.AddAttribute(158, "role", "dialog");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "modal-dialog");
            __builder.AddAttribute(161, "style", "border-color: black");
            __builder.OpenElement(162, "div");
            __builder.AddAttribute(163, "class", "modal-content");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "modal-body");
            __builder.OpenComponent<SACOMaintenance.Blazor.Server.Components.AssignUserToRequestDialog>(166);
            __builder.AddAttribute(167, "RequestId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 128 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                          maintReqInitation.maintReqId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(168, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 129 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                              OnCanceldialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 135 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
       
    [Parameter]
    public string maintReqID { get; set; }

    GeneralMaintReqComponent GeneralChild = new();

    public bool ShowPopupModal { get; set;}

    public RadzenGrid<MaintRequestInitiationRisk> risksGrid { get; set; }

    string detailMarkUp;

    string value = "";
    private bool isReadOnly = false;

    private void ReqChangeBool(bool isReadOnlyPage)
    {
        isReadOnly = isReadOnlyPage;
    }

    private async Task OnCanceldialogClose(bool accepted)
    {      
        ShowPopupModal = false;      
    }

    void AssignStaff(int maintIdSelected)
    {
        ShowPopupModal = true;
    }

    /// <summary>
    /// Saves the details of the request and the child component data as well
    /// </summary>
    private void SaveRequestDetails()
    {
        maintReqInitation.UpdateMaintReqRisks(); //save the request risks and isolations
        GeneralChild.seeppe(); //save PPE method from child

    }


    public void Testing()
    {

    }

    string riskvalue;


    protected async Task UpdateRisks()
    {
        //maintReqInitation.UpdateMaintReqRisks();
        //CallLoadData();
        //if (IsConnected) await SendMessageSingleReq();
        //await risksGrid.Reload();
        //await InvokeAsync(() => StateHasChanged());
    }

    //Task SendMessageSingleReq() => hubConnection.SendAsync("broadcastHub");

    public bool moveCol = false;

    public enum RiskLevelLetter { H, M, L }

    protected override async Task OnInitializedAsync()
    {
        maintReqInitation.GetMaintReqInitation(Convert.ToInt32(maintReqID));

        //maintReqInitation.LoadRiskLevel(Convert.ToInt32(maintReqID));

        Task.Run(async () => { await maintReqInitation.LoadFactories(); }).Wait();

        Task.Run(async () => { await maintReqInitation.LoadRisks(); }).Wait();

        Task.Run(async () => { await maintReqInitation.LoadMaintRiskData(maintReqInitation.maintReqId); }).Wait();
        Task.Run(async () => { await maintReqInitation.LoadIsolations(); }).Wait();
       // Task.Run(async () => { await maintReqInitation.LoadIsoaltionsByMaint(); }).Wait();

        detailMarkUp = maintReqInitation.maintReqDetails;

        Task.Run(async () => { await maintReqInitation.LoadPPE(); }).Wait();

        maintReqInitation.RiskListsChosen =
            maintReqInitation.RiskInfoList.ToList();

       

        ////Auto update
        //hubConnection = new HubConnectionBuilder()
        //    .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
        //    .Build();

        //hubConnection.On("ReceiveMessageSingleReq", () =>
        //{
        //    CallLoadData();

        //});

        //await hubConnection.StartAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IMaintRequestFullViewModel maintReqInitation { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.MaintReqFull
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSquareCheckBox_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Collections.Generic.List<TItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Collections.Generic.List<TItem>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg3)
        {
        __builder.OpenComponent<global::SACOMaintenance.Blazor.Server.Shared.SquareCheckBox<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "SelectedItems", __arg1);
        __builder.AddAttribute(__seq2, "SelectedItemsChanged", __arg2);
        __builder.AddAttribute(__seq3, "ItemTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
