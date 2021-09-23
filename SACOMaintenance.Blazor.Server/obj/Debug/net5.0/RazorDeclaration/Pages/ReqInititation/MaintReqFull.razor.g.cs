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
    [Microsoft.AspNetCore.Components.RouteAttribute("/maint-req/full-add/{MaintReqID}")]
    public partial class MaintReqFull : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 233 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintReqFull.razor"
       
    [Parameter]
    public string maintReqID { get; set; }

    string detailMarkUp;

    string value = "";


    public void Testing()
    {

    }


    protected async Task UpdateRisks()
    {
        maintReqInitation.UpdateMaintReqRisks();
    }

    public bool moveCol = false;

    public enum RiskLevelLetter { H, M, L }

    protected override void OnInitialized()
    {
        maintReqInitation.GetMaintReqInitation(Convert.ToInt32(maintReqID));

        // maintReqInitation.LoadRiskLevel(Convert.ToInt32(maintReqID));

        maintReqInitation.LoadFactories();

        maintReqInitation.LoadRisks();

        maintReqInitation.LoadMaintRiskData(maintReqInitation.maintReqId);
        maintReqInitation.LoadIsolations();
        maintReqInitation.LoadIsoaltionsByMaint();

        detailMarkUp = maintReqInitation.maintReqDetails;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IMaintRequestFullViewModel maintReqInitation { get; set; }
    }
}
#pragma warning restore 1591
