// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\GeneralMaintReqComponent.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\GeneralMaintReqComponent.razor"
using SACOMaintenance.DataAccess.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\GeneralMaintReqComponent.razor"
using SACOMaintenance.ViewModel.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\GeneralMaintReqComponent.razor"
using SACOMaintenance.Blazor.Server.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\GeneralMaintReqComponent.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class GeneralMaintReqComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 216 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\GeneralMaintReqComponent.razor"
       

    public bool ppeIsChecked;

    [Parameter]
    public MaintRequestInitiation maintReq { get; set; }


    [Parameter]
    public bool ReqReadOnly { get; set; }

    [Parameter]
    public EventCallback<bool> ReqReadOnlyChanged { get; set; }

    private HubConnection hubConnection;

    public string name;

    public void seeppe()
    {
        foreach (var item in maintReq.PPEEquipment)
        {
            Console.WriteLine(item.Id + "       " + item.PPEName);
        }
    }

    public void DeleteAuthroization()
    {
        GeneralViewModel.RemoveAuthStartToWorkUser();
        ReqReadOnly = false;
        ReqReadOnlyChanged.InvokeAsync(ReqReadOnly);
        if (IsConnected) SendMessage();
    }

    Task SendMessage() => hubConnection.SendAsync("SendMessage");

    private void IsReadOnlyChanged(ChangeEventArgs arg)
    {
        if (ReqReadOnly == true)
        {
            ReqReadOnly = false;
        }
        else if (ReqReadOnly == false)
        {
            ReqReadOnly = true;
        }

    }

    public string colour = "black";

    protected override void OnInitialized()
    {

        GeneralViewModel.maintId = maintReq.Id;
        GeneralViewModel.GetGeneralRequest(maintReq.Id);
        GeneralViewModel.LoadStartToworkAuth();
        GeneralViewModel.LoadCompletedUser();

        GeneralViewModel.PPEItemsSelected = GeneralViewModel.ppeList.Where(i => i.MaintRequestInitiations.Count == 1).ToList();


        hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
        .Build();

        //hubConnection.On("ReceiveMessage", () =>
        //{
        //    CallLoadData();
        //    StateHasChanged();
        //});

        hubConnection.StartAsync();




    }

    private void SignOffWorkCompleted(MouseEventArgs e)
    {
        GeneralViewModel.AddNewAuthrization("Approved", "Completed");
    }


    private void StartWorkRequest(MouseEventArgs e)
    {
        GeneralViewModel.AddNewAuthrization("Requested", "AuthorityToWork");
        GeneralViewModel.LoadStartToworkAuth();

        if (ReqReadOnly == true)
        {
            ReqReadOnly = false;
        }
        else if (ReqReadOnly == false)
        {
            ReqReadOnly = true;
        }

        ReqReadOnlyChanged.InvokeAsync(ReqReadOnly);
    }

    private void CallLoadData()
    {
        Task.Run(async () =>
        {
            GeneralViewModel.GetGeneralRequest(maintReq.Id);
            GeneralViewModel.LoadStartToworkAuth();
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGeneralMaintRequestViewModel GeneralViewModel { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGeneralRequest GeneralRequestDataProvider { get; set; }
    }
}
#pragma warning restore 1591
