#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\Dashboard\MaintReqAssignedOpen.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73fc63615112e08b8cade334fca32d5e192dd45d"
// <auto-generated/>
#pragma warning disable 1591
namespace SACOMaintenance.Blazor.Server.Pages.Dashboard
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
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\Dashboard\MaintReqAssignedOpen.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\Dashboard\MaintReqAssignedOpen.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class MaintReqAssignedOpen : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.SACOMaintenance.Blazor.Server.Pages.Dashboard.MaintReqAssignedOpen.TypeInference.CreateRadzenGrid_0(__builder, 0, 1, 
#nullable restore
#line 6 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\Dashboard\MaintReqAssignedOpen.razor"
                   dashboardViewModel.MaintReqsAssignedOpen

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 6 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\Dashboard\MaintReqAssignedOpen.razor"
                                                                                        false

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 6 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\Dashboard\MaintReqAssignedOpen.razor"
                                                                                                                  true

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(5);
                __builder2.AddAttribute(6, "Property", "Id");
                __builder2.AddAttribute(7, "Title", "Id");
                __builder2.AddAttribute(8, "Width", "20");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(10);
                __builder2.AddAttribute(11, "Property", "RequestDetails");
                __builder2.AddAttribute(12, "Title", "Details");
                __builder2.AddAttribute(13, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiation>)((data) => (__builder3) => {
                    __builder3.OpenElement(14, "p");
                    __builder3.AddAttribute(15, "style", "white-space:pre-wrap");
                    __builder3.AddContent(16, 
#nullable restore
#line 11 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\Dashboard\MaintReqAssignedOpen.razor"
                                                 data.RequestDetails

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(18);
                __builder2.AddAttribute(19, "Property", "DateRaised");
                __builder2.AddAttribute(20, "Title", "Origin Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(22);
                __builder2.AddAttribute(23, "Property", "maintReqListViewModel.Id");
                __builder2.AddAttribute(24, "Title", "Actions");
                __builder2.AddAttribute(25, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiation>)((data) => (__builder3) => {
                    __builder3.OpenElement(26, "a");
                    __builder3.AddAttribute(27, "href", 
#nullable restore
#line 17 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\Dashboard\MaintReqAssignedOpen.razor"
                           $"maint-req/full-add/{data.Id}"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(28, "class", "btn btn-primary table-btn");
                    __builder3.AddMarkupContent(29, "<i class=\"fa fa-pencil-square\"></i>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            , 30, (__value) => {
#nullable restore
#line 6 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\Dashboard\MaintReqAssignedOpen.razor"
                                                                   reqGrid = __value;

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\Dashboard\MaintReqAssignedOpen.razor"
       

    private HubConnection hubConnection;
    public RadzenGrid<MaintRequestInitiation> reqGrid { get; set; }

    protected override async Task OnInitializedAsync()
    {
        dashboardViewModel.LoadAssignedOpenReqs();

        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
            .Build();

        hubConnection.On("ReceiveMessage", () =>
        {
            CallLoadData();
            reqGrid.Reload();
            InvokeAsync(() => StateHasChanged());
        });

        await hubConnection.StartAsync();

        dashboardViewModel.LoadAssignedOpenReqs();
    }

    private void CallLoadData()
    {
        Task.Run(async () =>
        {
            dashboardViewModel.LoadAssignedOpenReqs();
        });
    }

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IDashboardViewModel dashboardViewModel { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Pages.Dashboard.MaintReqAssignedOpen
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::System.Action<global::Radzen.Blazor.RadzenGrid<TItem>> __arg4)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Responsive", __arg1);
        __builder.AddAttribute(__seq2, "AllowColumnResize", __arg2);
        __builder.AddAttribute(__seq3, "Columns", __arg3);
        __builder.AddComponentReferenceCapture(__seq4, (__value) => { __arg4((global::Radzen.Blazor.RadzenGrid<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
