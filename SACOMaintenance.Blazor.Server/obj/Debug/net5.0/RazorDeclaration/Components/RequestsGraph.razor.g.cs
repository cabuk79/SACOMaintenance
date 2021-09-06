// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SACOMaintenance.Blazor.Server.Components
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
#line 4 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsGraph.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class RequestsGraph : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsGraph.razor"
       

    public class DataItem
    {
        public int number { get; set; }
        public string statusName { get; set; }
    }

    //public DataItem[] statusData = new DataItem[2];

    public static int closedCount;
    public static int newCount;
    public static int countAssigned;
    public static int onHoldCount;
    public static int cancelledCount;

    protected override void OnInitialized()
    {
        closedCount = requestGraphViewModel.GetRequestsByStatusCount(6);
        newCount = requestGraphViewModel.GetRequestsByStatusCount(7);
        countAssigned = requestGraphViewModel.GetRequestsByStatusCount(8);
        onHoldCount = requestGraphViewModel.GetRequestsByStatusCount(11);
        cancelledCount = requestGraphViewModel.GetRequestsByStatusCount(10);
    }

    DataItem[] statusData = new DataItem[]
    {
            new DataItem
            {
                number = closedCount,
                statusName = "Closed"
            },
            new DataItem
            {
                number = newCount,
                statusName = "New"
            },
            new DataItem
            {
                number = countAssigned,
                statusName = "Assigned"
            },
            new DataItem
            {
                number = onHoldCount,
                statusName = "On Hold"
            },
            new DataItem
            {
                number = cancelledCount,
                statusName = "Cancelled"
            }
    };
    // getStatusCount();


    public void getStatusCount()
    {
        closedCount = requestGraphViewModel.GetRequestsByStatusCount(6);
        newCount = requestGraphViewModel.GetRequestsByStatusCount(7);
        countAssigned = requestGraphViewModel.GetRequestsByStatusCount(8);


        DataItem[] statusData = new DataItem[]
        {
            new DataItem
            {
                number = closedCount,
                statusName = "Closed"
            },
            new DataItem
            {
                number = newCount,
                statusName = "New"
            },
            new DataItem
            {
                number = countAssigned,
                statusName = "Assigned"
            }
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IRequestsGraphViewModel requestGraphViewModel { get; set; }
    }
}
#pragma warning restore 1591
