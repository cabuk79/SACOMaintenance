#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a9a72a729511ca284b2bf989ebf63004b17912d"
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
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
using SACOMaintenance.Common.ModelDB;

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
#line 5 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
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
#line 7 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                      args => maintReqInitation.ExportRequest()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "Text", "Create Request Form Word");
            __builder.AddAttribute(7, "Icon", "import_export");
            __builder.AddAttribute(8, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 8 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                 maintReqInitation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "container-fluid");
                __builder2.AddAttribute(15, "style", "border:1px solid");
                __builder2.AddMarkupContent(16, "<div class=\"row\"><h3>Request For Work Information</h3></div>\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "row");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "container-fluid");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-lg-3");
                __builder2.AddMarkupContent(25, "<strong><label>Factory:  </label></strong>");
                __builder2.AddContent(26, 
#nullable restore
#line 22 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                   maintReqInitation.factoryName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-lg-3");
                __builder2.AddMarkupContent(30, "<strong><label>Area:   </label></strong>");
                __builder2.AddContent(31, 
#nullable restore
#line 25 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                 maintReqInitation.areaName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-lg-3");
                __builder2.AddMarkupContent(35, "<strong><label>Equipment:   </label></strong>");
                __builder2.AddContent(36, 
#nullable restore
#line 28 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                      maintReqInitation.equipName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "row");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "container-fluid");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "row");
                __builder2.AddMarkupContent(44, "<label style=\"font-weight:bold\">Details</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(45);
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                maintReqInitation.maintReqDetails

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => maintReqInitation.maintReqDetails = __value, maintReqInitation.maintReqDetails))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => maintReqInitation.maintReqDetails));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n\r\n    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "container-fluid");
                __builder2.AddAttribute(53, "style", "border:1px solid");
                __builder2.AddMarkupContent(54, "<div class=\"row\"><h3>Dynamic Risk Assessment (to be completed by person in charge of the work)</h3></div>\r\n        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "row");
#nullable restore
#line 48 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
             foreach (var item in maintReqInitation.RiskInfoList)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                 foreach (var riskITem in maintReqInitation.Risks)
                {
                    if (riskITem.Id == item.RiskId)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "col-4");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "mt-2 row");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "w-75");
                __builder2.AddContent(63, 
#nullable restore
#line 57 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                     riskITem.RiskName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "w-25");
                __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.MaintReqFull.TypeInference.CreateInputSelect_0(__builder2, 67, 68, "riskLevel", 69, 
#nullable restore
#line 60 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                             item.RiskLevel

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.RiskLevel = __value, item.RiskLevel)), 71, () => item.RiskLevel, 72, (__builder3) => {
#nullable restore
#line 61 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                         foreach (RiskLevelLetter levelItem in Enum.GetValues(typeof(RiskLevelLetter)))
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(73, "option");
                    __builder3.AddAttribute(74, "class", "riskLevelOption");
                    __builder3.AddAttribute(75, "value", 
#nullable restore
#line 63 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                   levelItem

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(76, 
#nullable restore
#line 63 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                                                              levelItem

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 64 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 69 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                 
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        \r\n    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group-row");
#nullable restore
#line 77 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
          
            if (maintReqInitation.maintReqAreaId == 31)  //This ID 31 refers to the plant Area so either plant 1 or 2
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<SACOMaintenance.Blazor.Server.Pages.ReqInititation.PlantMaintReqComponent>(80);
                __builder2.AddAttribute(81, "maintReqID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 80 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                    maintReqInitation.maintReqId

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 81 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<SACOMaintenance.Blazor.Server.Pages.ReqInititation.GeneralMaintReqComponent>(82);
                __builder2.AddAttribute(83, "maintReqID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 84 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
                                                      maintReqInitation.maintReqId

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
#nullable restore
#line 85 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
            }
        

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
       
    [Parameter] 
    public string maintReqID { get; set; }

    public enum RiskLevelLetter { H, M, L }

    protected override void OnInitialized()
    {
        maintReqInitation.GetMaintReqInitation(Convert.ToInt32(maintReqID));

        maintReqInitation.LoadRiskLevel(Convert.ToInt32(maintReqID));

        maintReqInitation.LoadFactories();
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
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
