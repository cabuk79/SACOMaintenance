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
        }
        #pragma warning restore 1998
#nullable restore
#line 160 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
       
    [Parameter]
    public string maintReqID { get; set; }

    public RadzenGrid<MaintRequestInitiationRisk> risksGrid { get; set; }

    string detailMarkUp;

    string value = "";
    private bool isReadOnly = false;

    private void ReqChangeBool(bool isReadOnlyPage)
    {
        isReadOnly = isReadOnlyPage;
    }


    public void Testing()
    {

    }


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

        await maintReqInitation.LoadFactories();

        await maintReqInitation.LoadRisks();

        await maintReqInitation.LoadMaintRiskData(maintReqInitation.maintReqId);
        await maintReqInitation.LoadIsolations();
        await maintReqInitation.LoadIsoaltionsByMaint();

        detailMarkUp = maintReqInitation.maintReqDetails;

        maintReqInitation.IsolationsSelected =
            maintReqInitation.IsolationByRequest
            .Where(i => i.MaintRequestInitiations.Count == 1).ToList();

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



    //Auto update code
    //TODO: may need to remove this or modiy to suit
    //private HubConnection hubConnection;

    //private void CallLoadData()
    //{
    //    Task.Run(async () =>
    //    {
    //        await maintReqInitation.GetMaintReqInitation(Convert.ToInt32(maintReqID));
    //        await maintReqInitation.LoadMaintRiskData(Convert.ToInt32(maintReqID));
    //    });
    //}

    //public bool IsConnected =>
    //    hubConnection.State == HubConnectionState.Connected;

    //public void Dispose()
    //{
    //    _ = hubConnection.DisposeAsync();
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IMaintRequestFullViewModel maintReqInitation { get; set; }
    }
}
#pragma warning restore 1591
