#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79bc312d3d41fa1ff27f230dd87a14cc6ff6dac6"
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
            __builder.AddMarkupContent(0, "<h3><em>Isolations</em></h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-6");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "cellpadding", "5");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "<td><label>Phosphoric Acide</label></td>\r\n                ");
            __builder.OpenElement(9, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(10);
            __builder.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                plantMaintViewModel.IsolationNitricAcid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationNitricAcid = __value, plantMaintViewModel.IsolationNitricAcid))));
            __builder.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationNitricAcid));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.AddMarkupContent(15, "<td><label>Phosporic Acid</label></td>\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(17);
            __builder.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                plantMaintViewModel.IsolatedPhosphoricAcid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolatedPhosphoricAcid = __value, plantMaintViewModel.IsolatedPhosphoricAcid))));
            __builder.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolatedPhosphoricAcid));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "<td><label>Sodium Hydrozide</label></td>\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(25);
            __builder.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                plantMaintViewModel.IsolatedSodiumHyrodzide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolatedSodiumHyrodzide = __value, plantMaintViewModel.IsolatedSodiumHyrodzide))));
            __builder.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolatedSodiumHyrodzide));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.AddMarkupContent(30, "<td><label>Sulpric Acid</label></td>\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(32);
            __builder.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                plantMaintViewModel.IsolatedSulphuricAcid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolatedSulphuricAcid = __value, plantMaintViewModel.IsolatedSulphuricAcid))));
            __builder.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolatedSulphuricAcid));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "<td><label>Other</label></td>\r\n                ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "colspan", "3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(41);
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                            plantMaintViewModel.IsolationsOther

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsOther = __value, plantMaintViewModel.IsolationsOther))));
            __builder.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => plantMaintViewModel.IsolationsOther));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-lg-6");
            __builder.AddMarkupContent(49, "<h3>Drained Lines</h3>\r\n\r\n        ");
            __builder.OpenElement(50, "table");
            __builder.AddAttribute(51, "cellpadding", "5");
            __builder.OpenElement(52, "tr");
            __builder.AddMarkupContent(53, "<td><label>Nitric Acid</label></td>\r\n                ");
            __builder.OpenElement(54, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(55);
            __builder.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                plantMaintViewModel.DrainingLinedNitricAcid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.DrainingLinedNitricAcid = __value, plantMaintViewModel.DrainingLinedNitricAcid))));
            __builder.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.DrainingLinedNitricAcid));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.AddMarkupContent(60, "<td><label>Phosphoric Acid</label></td>\r\n                ");
            __builder.OpenElement(61, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(62);
            __builder.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                plantMaintViewModel.DrainingLinedPhosphoricAcicd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.DrainingLinedPhosphoricAcicd = __value, plantMaintViewModel.DrainingLinedPhosphoricAcicd))));
            __builder.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.DrainingLinedPhosphoricAcicd));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "tr");
            __builder.AddMarkupContent(68, "<td><label>Sodium Hydroxide</label></td>\r\n                ");
            __builder.OpenElement(69, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(70);
            __builder.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 38 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                plantMaintViewModel.DrainingLinedSodiumHydroxide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.DrainingLinedSodiumHydroxide = __value, plantMaintViewModel.DrainingLinedSodiumHydroxide))));
            __builder.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.DrainingLinedSodiumHydroxide));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.AddMarkupContent(75, "<td>Sulphuric Acid</td>\r\n                ");
            __builder.OpenElement(76, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(77);
            __builder.AddAttribute(78, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                plantMaintViewModel.DrainingLinesSulphuricAcid

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.DrainingLinesSulphuricAcid = __value, plantMaintViewModel.DrainingLinesSulphuricAcid))));
            __builder.AddAttribute(80, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.DrainingLinesSulphuricAcid));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.OpenElement(82, "tr");
            __builder.AddMarkupContent(83, "<td><label>Other</label></td>\r\n                ");
            __builder.OpenElement(84, "td");
            __builder.AddAttribute(85, "colspan", "3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(86);
            __builder.AddAttribute(87, "class", "form-control");
            __builder.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                                            plantMaintViewModel.DrainingLinesOther

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.DrainingLinesOther = __value, plantMaintViewModel.DrainingLinesOther))));
            __builder.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => plantMaintViewModel.DrainingLinesOther));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n\r\n");
            __builder.AddMarkupContent(92, "<h3>Isolations Other</h3>\r\n");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "row");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "col-lg-4");
            __builder.AddMarkupContent(97, "<label>Compressed Air</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(98);
            __builder.AddAttribute(99, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                    plantMaintViewModel.IsolationsCompressedAir

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsCompressedAir = __value, plantMaintViewModel.IsolationsCompressedAir))));
            __builder.AddAttribute(101, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsCompressedAir));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n    ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "col-lg-4");
            __builder.AddMarkupContent(105, "<label>Electrical</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(106);
            __builder.AddAttribute(107, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                    plantMaintViewModel.IsolationsElectrical

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(108, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsElectrical = __value, plantMaintViewModel.IsolationsElectrical))));
            __builder.AddAttribute(109, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsElectrical));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-lg-4");
            __builder.AddMarkupContent(113, "<label>Gas</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(114);
            __builder.AddAttribute(115, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                    plantMaintViewModel.IsolationsGas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsGas = __value, plantMaintViewModel.IsolationsGas))));
            __builder.AddAttribute(117, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsGas));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n    ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "col-lg-4");
            __builder.AddMarkupContent(121, "<label>Mechanical</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(122);
            __builder.AddAttribute(123, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 66 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                    plantMaintViewModel.IsolationsMechanical

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsMechanical = __value, plantMaintViewModel.IsolationsMechanical))));
            __builder.AddAttribute(125, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsMechanical));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n    ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "col-lg-4");
            __builder.AddMarkupContent(129, "<label>Steam</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(130);
            __builder.AddAttribute(131, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 70 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                    plantMaintViewModel.IsolationsSteam

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsSteam = __value, plantMaintViewModel.IsolationsSteam))));
            __builder.AddAttribute(133, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsSteam));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n    ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "col-lg-4");
            __builder.AddMarkupContent(137, "<label>Water</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(138);
            __builder.AddAttribute(139, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 74 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                    plantMaintViewModel.IsolationsWater

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(140, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.IsolationsWater = __value, plantMaintViewModel.IsolationsWater))));
            __builder.AddAttribute(141, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => plantMaintViewModel.IsolationsWater));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n    ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "col-lg-4");
            __builder.AddMarkupContent(145, "<label>Other</label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(146);
            __builder.AddAttribute(147, "class", "form-control");
            __builder.AddAttribute(148, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 78 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
                                    plantMaintViewModel.OtherPrecations

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(149, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => plantMaintViewModel.OtherPrecations = __value, plantMaintViewModel.OtherPrecations))));
            __builder.AddAttribute(150, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => plantMaintViewModel.OtherPrecations));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(152, "<div class=\"form-group-row\"><label style=\"font-weight:bold\">PPE</label></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 160 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\PlantMaintReqComponent.razor"
       
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
