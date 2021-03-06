#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73d0ab96eb6d3a5088dae35d448deec903f547ad"
// <auto-generated/>
#pragma warning disable 1591
namespace SACOMaintenance.Blazor.Server.Pages.AreaPages
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
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
using SACOMaintenance.DataAccess.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/areas")]
    public partial class AreaEditComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div section=\"header\"><div class=\"container-fluid\"><h1>Areas</h1></div></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "section", "main-body");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-2");
            __builder.OpenComponent<Radzen.Blazor.RadzenListBox<int>>(9);
            __builder.AddAttribute(10, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 18 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                                  areaViewModel.areas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "TextProperty", "AreaName");
            __builder.AddAttribute(12, "ValueProperty", "Id");
            __builder.AddAttribute(13, "Style", "height:500px");
            __builder.AddAttribute(14, "Name", "areasListBox");
            __builder.AddAttribute(15, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 20 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                        args => OnChange(args, "ListBox")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-lg-10");
            __builder.OpenElement(19, "section");
            __builder.AddAttribute(20, "class", "area-form");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "area-form-area");
            __builder.OpenElement(23, "h3");
            __builder.AddContent(24, "Viewing: ");
            __builder.AddContent(25, 
#nullable restore
#line 26 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                      areaViewModel.AreaName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(27);
            __builder.AddAttribute(28, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 27 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                          areaViewModel.area

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group-row");
                __builder2.AddMarkupContent(34, "<label style=\"font-weight:bold\">Name</label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                                            areaViewModel.AreaName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => areaViewModel.AreaName = __value, areaViewModel.AreaName))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => areaViewModel.AreaName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group-row");
                __builder2.AddMarkupContent(43, "<label style=\"font-weight:bold\">Factory</label>\r\n                                    ");
                __Blazor.SACOMaintenance.Blazor.Server.Pages.AreaPages.AreaEditComponent.TypeInference.CreateInputSelect_0(__builder2, 44, 45, "factory", 46, "form-control", 47, true, 48, 
#nullable restore
#line 36 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                                                        areaViewModel.FactoryId

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => areaViewModel.FactoryId = __value, areaViewModel.FactoryId)), 50, () => areaViewModel.FactoryId, 51, (__builder3) => {
#nullable restore
#line 37 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                         foreach (var factory in areaViewModel.factories)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(52, "option");
                    __builder3.AddAttribute(53, "value", 
#nullable restore
#line 39 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                                            factory.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(54, 
#nullable restore
#line 39 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                                                         factory.FactoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 40 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                                ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group-row");
                __builder2.AddMarkupContent(58, "<label style=\"font-weight:bold\">Comments</label>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(59);
                __builder2.AddAttribute(60, "class", "form-control");
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                                                areaViewModel.CommentsNotes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => areaViewModel.CommentsNotes = __value, areaViewModel.CommentsNotes))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => areaViewModel.CommentsNotes));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "update-save-buttons");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "class", "btn btn-primary");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
                                                                   UpdateArea

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(70, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.AddMarkupContent(72, "<button class=\"btn btn-primary\">Add New Area</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaEditComponent.razor"
       

    [Parameter]
    public string AreaId { get; set; }

    protected override void OnInitialized()
    {
        //areaViewModel.LoadSingleArea(Convert.ToInt32(AreaId));
        //AreaModelItem = AreaDataProvider.LoadSingleArea(Convert.ToInt32(AreaId));
        //FactoryList = FactoryDataProvider.LoadAllFactories();
    }

    void OnChange(object value, string name)
    {
        //var str = value is IEnumerable<object> ? string.Join(", ", (IEnumerable<object>)value) : value;
        areaViewModel.LoadSingleArea(Convert.ToInt32(value));
        //console.Log($"{name} value changed to {str}");
    }

    private void UpdateArea(MouseEventArgs e)
    {
        areaViewModel.SaveArea(areaViewModel.area);
    }

    //private AreaModel AreaModelItem { get; set; } = new AreaModel();
    //private IEnumerable<Factory> FactoryList; // { get; set; } = new IEnumerable<Factory>();

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IAreaViewModel areaViewModel { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Pages.AreaPages.AreaEditComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "col-sm-8", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
