#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3161d3d0f9b639c9f9add6d28446d56236316903"
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
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
using SACOMaintenance.DataAccess.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/area/create")]
    public partial class AreaAddComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.AddMarkupContent(2, "<h3 class=\"card-title text-info col-lg-12\">Add New Area</h3>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
                             AreaModelItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group-row");
                __builder2.AddMarkupContent(14, "<label style=\"font-weight:bold\">Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "placeholder", "Enter Area Name");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
                                                AreaModelItem.AreaName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AreaModelItem.AreaName = __value, AreaModelItem.AreaName))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AreaModelItem.AreaName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                    ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group-row");
                __builder2.AddMarkupContent(24, "<label style=\"font-weight:bold\">Factory</label>\r\n                        ");
                __Blazor.SACOMaintenance.Blazor.Server.Pages.AreaPages.AreaAddComponent.TypeInference.CreateInputSelect_0(__builder2, 25, 26, "factory", 27, "form-control", 28, true, 29, "Select a Factory", 30, 
#nullable restore
#line 19 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
                                                                                              AreaModelItem.FactoryId

#line default
#line hidden
#nullable disable
                , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AreaModelItem.FactoryId = __value, AreaModelItem.FactoryId)), 32, () => AreaModelItem.FactoryId, 33, (__builder3) => {
#nullable restore
#line 20 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
                             foreach (var factory in FactoryList)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(34, "option");
                    __builder3.AddAttribute(35, "value", 
#nullable restore
#line 22 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
                                                factory.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(36, 
#nullable restore
#line 22 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
                                                             factory.FactoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 23 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group-row");
                __builder2.AddMarkupContent(40, "<label style=\"font-weight:bold\">Comments</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(41);
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "placeholder", "Enter any comments");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
                                                    AreaModelItem.CommentsNotes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AreaModelItem.CommentsNotes = __value, AreaModelItem.CommentsNotes))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AreaModelItem.CommentsNotes));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "area-button-group");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "type", "submit");
            __builder.AddAttribute(52, "class", "btn btn-outline-primary");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
                                                                        SaveAreaToDatabase

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Save");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\AreaPages\AreaAddComponent.razor"
       

    private void SaveAreaToDatabase()
    {
        AreaDataProvider.AddEditArea(AreaModelItem);
    }

    private AreaModel AreaModelItem { get; set; } = new AreaModel();
    private string Title { get; set; } = "Create";

    protected override void OnInitialized()
    {
        FactoryList = FactoryDataProvider.LoadAllFactories();
    }

    private IEnumerable<Factory> FactoryList;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFactory FactoryDataProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IArea AreaDataProvider { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Pages.AreaPages.AreaAddComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "col-sm-8", __arg2);
        __builder.AddAttribute(__seq3, "placeholder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.AddAttribute(__seq7, "ChildContent", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591