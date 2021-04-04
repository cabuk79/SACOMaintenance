#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\EquipmentPages\EquipmentListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c509b80b108622ca333ecc5adf2f5becd3b5c1e0"
// <auto-generated/>
#pragma warning disable 1591
namespace SACOMaintenance.Blazor.Server.Pages.EquipmentPages
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
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\EquipmentPages\EquipmentListComponent.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\EquipmentPages\EquipmentListComponent.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class EquipmentListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>List of Equipment</h3>\r\n\r\n");
            __Blazor.SACOMaintenance.Blazor.Server.Pages.EquipmentPages.EquipmentListComponent.TypeInference.CreateRadzenGrid_0(__builder, 1, 2, 
#nullable restore
#line 8 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\EquipmentPages\EquipmentListComponent.razor"
                   equipmentListViewModel.EquipmentList

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Equipment>>(4);
                __builder2.AddAttribute(5, "Property", "Id");
                __builder2.AddAttribute(6, "Title", "Id");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Equipment>>(8);
                __builder2.AddAttribute(9, "Property", "Name");
                __builder2.AddAttribute(10, "Title", "Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Equipment>>(12);
                __builder2.AddAttribute(13, "Property", "Description");
                __builder2.AddAttribute(14, "Title", "Description");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Equipment>>(16);
                __builder2.AddAttribute(17, "Property", "SerialIdentifierNumber");
                __builder2.AddAttribute(18, "Title", "Serial Number");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Equipment>>(20);
                __builder2.AddAttribute(21, "Property", "Comments");
                __builder2.AddAttribute(22, "Title", "Comments");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Equipment>>(24);
                __builder2.AddAttribute(25, "Property", "Id");
                __builder2.AddAttribute(26, "Title", "Actions");
                __builder2.AddAttribute(27, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Equipment>)((data) => (__builder3) => {
                    __builder3.OpenElement(28, "a");
                    __builder3.AddAttribute(29, "href", 
#nullable restore
#line 17 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\EquipmentPages\EquipmentListComponent.razor"
                           $"equipment/{data.Id}"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(30, "class", "btn btn-primary table-btn");
                    __builder3.AddMarkupContent(31, "<i class=\"fa fa-pencil-square\"></i>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\EquipmentPages\EquipmentListComponent.razor"
      

    private HubConnection hubConnection;

    protected override async Task OnInitializedAsync()
    {

        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
            .Build();

        hubConnection.On("ReceiveMessage", () =>
        {
            CallLoadData();
            StateHasChanged();
        });

        await hubConnection.StartAsync();

        equipmentListViewModel.LoadAllEquipment();
    }

    private void CallLoadData()
    {
        Task.Run(async () =>
        {
            equipmentListViewModel.LoadAllEquipment();
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IEquipmentListViewModel equipmentListViewModel { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Pages.EquipmentPages.EquipmentListComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Columns", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591