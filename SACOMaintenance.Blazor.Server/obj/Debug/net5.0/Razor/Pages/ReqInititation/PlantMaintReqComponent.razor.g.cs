#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a9f57083141e48a613449bb91c4c7df3a3708fb"
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
    public partial class PlantMaintReqComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><em>Isolations</em></h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "cellpadding", "5");
            __builder.OpenElement(3, "tr");
            __builder.AddMarkupContent(4, "<td><label>Phosphoric Acide</label></td>\r\n        ");
            __builder.OpenElement(5, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(6);
            __builder.AddAttribute(7, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.IsolationNitricAcid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationNitricAcid = __value, plantMaintViewModel.IsolationNitricAcid))));
            __builder.AddAttribute(9, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationNitricAcid));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.AddMarkupContent(11, "<td><label>Phosporic Acid</label></td>\r\n        ");
            __builder.OpenElement(12, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(13);
            __builder.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.IsolatedPhosphoricAcid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolatedPhosphoricAcid = __value, plantMaintViewModel.IsolatedPhosphoricAcid))));
            __builder.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolatedPhosphoricAcid));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "<td><label>Sodium Hydrozide</label></td>\r\n        ");
            __builder.OpenElement(20, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(21);
            __builder.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.IsolatedSodiumHyrodzide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolatedSodiumHyrodzide = __value, plantMaintViewModel.IsolatedSodiumHyrodzide))));
            __builder.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolatedSodiumHyrodzide));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<td><label>Sulpric Acid</label></td>\r\n        ");
            __builder.OpenElement(27, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(28);
            __builder.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.IsolatedSulphuricAcid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolatedSulphuricAcid = __value, plantMaintViewModel.IsolatedSulphuricAcid))));
            __builder.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolatedSulphuricAcid));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "tr");
            __builder.AddMarkupContent(34, "<td><label>Other</label></td>\r\n        ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "colspan", "3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(37);
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                    plantMaintViewModel.IsolationsOther

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsOther = __value, plantMaintViewModel.IsolationsOther))));
            __builder.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => plantMaintViewModel.IsolationsOther));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n");
            __builder.AddMarkupContent(43, "<h3>Drained Lines</h3>\r\n\r\n");
            __builder.OpenElement(44, "table");
            __builder.AddAttribute(45, "cellpadding", "5");
            __builder.OpenElement(46, "tr");
            __builder.AddMarkupContent(47, "<td><label>Nitric Acid</label></td>\r\n        ");
            __builder.OpenElement(48, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(49);
            __builder.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.DrainingLinedNitricAcid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.DrainingLinedNitricAcid = __value, plantMaintViewModel.DrainingLinedNitricAcid))));
            __builder.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.DrainingLinedNitricAcid));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.AddMarkupContent(54, "<td><label>Phosphoric Acid</label></td>\r\n        ");
            __builder.OpenElement(55, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(56);
            __builder.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.DrainingLinedPhosphoricAcicd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.DrainingLinedPhosphoricAcicd = __value, plantMaintViewModel.DrainingLinedPhosphoricAcicd))));
            __builder.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.DrainingLinedPhosphoricAcicd));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.OpenElement(61, "tr");
            __builder.AddMarkupContent(62, "<td><label>Sodium Hydroxide</label></td>\r\n        ");
            __builder.OpenElement(63, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(64);
            __builder.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.DrainingLinedSodiumHydroxide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.DrainingLinedSodiumHydroxide = __value, plantMaintViewModel.DrainingLinedSodiumHydroxide))));
            __builder.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.DrainingLinedSodiumHydroxide));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.AddMarkupContent(69, "<td>Sulphuric Acid</td>\r\n        ");
            __builder.OpenElement(70, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(71);
            __builder.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.DrainingLinesSulphuricAcid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.DrainingLinesSulphuricAcid = __value, plantMaintViewModel.DrainingLinesSulphuricAcid))));
            __builder.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.DrainingLinesSulphuricAcid));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.OpenElement(76, "tr");
            __builder.AddMarkupContent(77, "<td><label>Other</label></td>\r\n        ");
            __builder.OpenElement(78, "td");
            __builder.AddAttribute(79, "colspan", "3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(80);
            __builder.AddAttribute(81, "class", "form-control");
            __builder.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                    plantMaintViewModel.DrainingLinesOther

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.DrainingLinesOther = __value, plantMaintViewModel.DrainingLinesOther))));
            __builder.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => plantMaintViewModel.DrainingLinesOther));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n");
            __builder.AddMarkupContent(86, "<h3>Isolations Other</h3>\r\n\r\n");
            __builder.OpenElement(87, "table");
            __builder.AddAttribute(88, "cellpadding", "5");
            __builder.OpenElement(89, "tr");
            __builder.AddMarkupContent(90, "<td><label>Compressed Air</label></td>\r\n        ");
            __builder.OpenElement(91, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(92);
            __builder.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.IsolationsCompressedAir

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsCompressedAir = __value, plantMaintViewModel.IsolationsCompressedAir))));
            __builder.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsCompressedAir));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.AddMarkupContent(97, "<td><label>Electrical</label></td>\r\n        ");
            __builder.OpenElement(98, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(99);
            __builder.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 52 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.IsolationsElectrical

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsElectrical = __value, plantMaintViewModel.IsolationsElectrical))));
            __builder.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsElectrical));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.OpenElement(104, "tr");
            __builder.AddMarkupContent(105, "<td><label>Gas</label></td>\r\n        ");
            __builder.OpenElement(106, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(107);
            __builder.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 56 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.IsolationsGas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsGas = __value, plantMaintViewModel.IsolationsGas))));
            __builder.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsGas));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n        ");
            __builder.AddMarkupContent(112, "<td>Mechanical</td>\r\n        ");
            __builder.OpenElement(113, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(114);
            __builder.AddAttribute(115, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.IsolationsMechanical

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsMechanical = __value, plantMaintViewModel.IsolationsMechanical))));
            __builder.AddAttribute(117, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsMechanical));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n    ");
            __builder.OpenElement(119, "tr");
            __builder.AddMarkupContent(120, "<td><label>Steam</label></td>\r\n        ");
            __builder.OpenElement(121, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(122);
            __builder.AddAttribute(123, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.IsolationsSteam

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsSteam = __value, plantMaintViewModel.IsolationsSteam))));
            __builder.AddAttribute(125, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsSteam));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n        ");
            __builder.AddMarkupContent(127, "<td>Water</td>\r\n        ");
            __builder.OpenElement(128, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(129);
            __builder.AddAttribute(130, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 64 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                        plantMaintViewModel.IsolationsWater

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsWater = __value, plantMaintViewModel.IsolationsWater))));
            __builder.AddAttribute(132, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsWater));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n    ");
            __builder.OpenElement(134, "tr");
            __builder.AddMarkupContent(135, "<td><label>Other</label></td>\r\n        ");
            __builder.OpenElement(136, "td");
            __builder.AddAttribute(137, "colspan", "3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(138);
            __builder.AddAttribute(139, "class", "form-control");
            __builder.AddAttribute(140, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                    plantMaintViewModel.OtherPrecations

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.OtherPrecations = __value, plantMaintViewModel.OtherPrecations))));
            __builder.AddAttribute(142, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => plantMaintViewModel.OtherPrecations));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(144, "<div class=\"form-group-row\"><label style=\"font-weight:bold\">PPE</label></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 144 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
       
    [Parameter]
    public int maintReqID { get; set; }

    [Parameter]
    public string PpeTypeName { get; set; }

    //public IEnumerable<PPE> ppeList { get; set; }

    //private PlantRequest plantReq { get; set; }

    protected override void OnInitialized()
    {
        plantMaintViewModel.LoadAll(maintReqID);
        //PppMaintTypeEnum maintTypeEnum = new PppMaintTypeEnum();

        ////plantReq = PlantReqDataProvider.GetSinalPlantRequestInfo(maintReqID);
        //ppeList = PpeReqDataProvider.LoadAllPlantPPE(PpeTypeName);

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IPlantMaintReqViewModel plantMaintViewModel { get; set; }
    }
}
#pragma warning restore 1591
