#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "063ab79ddfd18e723ed6c9dce4040cb461cd90b1"
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
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
using Microsoft.AspNetCore.SignalR.Client;

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
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<h3>Add New Maintenance Request</h3>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container-fluid");
            __builder.OpenElement(7, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                             AddReqViewModel.MaintReq

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group-row");
                __builder2.AddMarkupContent(15, "<label style=\"font-weight:bold\">Details</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "placeholder", "Enter the details of the request");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                    AddReqViewModel.MaintReq.RequestDetails

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddReqViewModel.MaintReq.RequestDetails = __value, AddReqViewModel.MaintReq.RequestDetails))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AddReqViewModel.MaintReq.RequestDetails));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group-row");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "row");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-lg-4");
                __builder2.AddMarkupContent(29, "<label style=\"font-weight:bold\">Factory</label>\r\n                            ");
                __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.AddMaintReq.TypeInference.CreateInputSelect_0(__builder2, 30, 31, "factory", 32, "form-control", 33, 
#nullable restore
#line 45 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                       AddReqViewModel.FactoryId

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddReqViewModel.FactoryId = __value, AddReqViewModel.FactoryId)), 35, () => AddReqViewModel.FactoryId, 36, (__builder3) => {
#nullable restore
#line 46 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                 foreach (var factory in AddReqViewModel.Factories)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(37, "option");
                    __builder3.AddAttribute(38, "value", 
#nullable restore
#line 48 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                    factory.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(39, 
#nullable restore
#line 48 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                 factory.FactoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 49 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
#nullable restore
#line 55 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                         if (AddReqViewModel.Areas != null)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-lg-4");
                __builder2.AddMarkupContent(42, "<label style=\"font-weight:bold\">Area</label>\r\n                                ");
                __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.AddMaintReq.TypeInference.CreateInputSelect_1(__builder2, 43, 44, "area", 45, "form-control", 46, 
#nullable restore
#line 59 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                                         AddReqViewModel.AreaId

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddReqViewModel.AreaId = __value, AddReqViewModel.AreaId)), 48, () => AddReqViewModel.AreaId, 49, (__builder3) => {
#nullable restore
#line 60 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                     foreach (var area in AddReqViewModel.Areas)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(50, "option");
                    __builder3.AddAttribute(51, "value", 
#nullable restore
#line 62 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                        area.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(52, 
#nullable restore
#line 62 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                  area.AreaName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 63 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
#nullable restore
#line 66 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"



                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 73 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                 if (AddReqViewModel.Equipment != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group-row");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-lg-4");
                __builder2.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(57);
                __builder2.AddAttribute(58, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 78 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "Style", "width:100%;");
                __builder2.AddAttribute(60, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 79 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.StringFilterOperator>(
#nullable restore
#line 80 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                                                       StringFilterOperator.Contains

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 81 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 82 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                  AddReqViewModel.Equipment

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "TextProperty", "Name");
                __builder2.AddAttribute(65, "ValueProperty", "Id");
                __builder2.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 80 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                          AddReqViewModel.EquipmentId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddReqViewModel.EquipmentId = __value, AddReqViewModel.EquipmentId))));
                __builder2.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => AddReqViewModel.EquipmentId));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(70, "<div class=\"col-lg-4\">\r\n                            If the equipment is not there contact maintenance!\r\n                        </div>");
                __builder2.CloseElement();
#nullable restore
#line 91 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n        ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "area-button-group");
            __builder.OpenElement(74, "a");
            __builder.AddAttribute(75, "type", "submit");
            __builder.AddAttribute(76, "class", "btn btn-outline-primary");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
                                                                        UpdateBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Save");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\AddMaintReq.razor"
       
    //static event Action OnChange;

    //void Refresh() => InvokeAsync(StateHasChanged);
    //override protected void OnInitialized() => OnChange += Refresh;
    //void IDisposable.Dispose() => OnChange -= Refresh;

    private HubConnection hubConnection;

    protected override async Task OnInitializedAsync()
    {
        //book = await Http.GetFromJsonAsync<Book>("api/books/" + id);

        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
            .Build();

        await hubConnection.StartAsync();
    }

    protected async Task UpdateBook()
    {
        AddReqViewModel.AddNewRequest();
        //await Http.PutAsJsonAsync("api/books/" + id, book);
        if (IsConnected) await SendMessage();
        //NavigationManager.NavigateTo("listbooks");

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

        //console.Log($"{message.Severity} notification");
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IMaintReqNewViewModel AddReqViewModel { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.AddMaintReq
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
