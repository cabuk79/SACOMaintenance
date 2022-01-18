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
#line 137 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
       
    [Parameter]
    public string maintReqID { get; set; }

    GeneralMaintReqComponent GeneralChild = new();

    public bool ShowPopupModal { get; set;}

    public RadzenGrid<MaintRequestInitiationRisk> risksGrid { get; set; }

    string detailMarkUp;

    string value = "";
    private bool isReadOnly = false;

    private void ReqChangeBool(bool isReadOnlyPage)
    {
        isReadOnly = isReadOnlyPage;
    }

    private async Task OnCanceldialogClose(bool accepted)
    {      
        ShowPopupModal = false;      
    }

    void AssignStaff(int maintIdSelected)
    {
        ShowPopupModal = true;
    }

    private void SaveRequestDetails()
    {
        GeneralChild.seeppe(); //save PPE method from child
    }


    public void Testing()
    {

    }

    string riskvalue;


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

        Task.Run(async () => { await maintReqInitation.LoadFactories(); }).Wait();

        Task.Run(async () => { await maintReqInitation.LoadRisks(); }).Wait();

        Task.Run(async () => { await maintReqInitation.LoadMaintRiskData(maintReqInitation.maintReqId); }).Wait();
        Task.Run(async () => { await maintReqInitation.LoadIsolations(); }).Wait();
       // Task.Run(async () => { await maintReqInitation.LoadIsoaltionsByMaint(); }).Wait();

        detailMarkUp = maintReqInitation.maintReqDetails;

        Task.Run(async () => { await maintReqInitation.LoadPPE(); }).Wait();

        maintReqInitation.RiskListsChosen =
            maintReqInitation.RiskInfoList.ToList();

       

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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IMaintRequestFullViewModel maintReqInitation { get; set; }
    }
}
#pragma warning restore 1591
