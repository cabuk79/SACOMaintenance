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
#line 13 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsYearGraphComponent.razor"
using Models.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsYearGraphComponent.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class RequestsYearGraphComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsYearGraphComponent.razor"
       
    //TODO: workout why the years are going up in halfs i.e. 2019>2019.5>2020>2020.5
    public int startYear;// = 2019; //TODO: make this a global varibale that can be set on install or by user once logged in etc.
    public int currentYear = DateTime.Now.Year;
    public List<YearMaintenanceRequestModel> YearsList = new();

    protected override void OnInitialized()
    {
        Task.Run(async () => { await requestViewModel.GetRequests(); }).Wait();

        //UpdateStartYear();

        startYear = 2019;

        //if (YearsList.Count == 0)
        //{
        var yearDiffernce = (currentYear - startYear) + 1;

        while (yearDiffernce > 0)
        {
            YearsList.Add(new YearMaintenanceRequestModel { YearName = startYear.ToString(), YearNumber = 0 });
            startYear++;
            yearDiffernce--;
        }

        foreach (var item in requestViewModel.MaintReqs)
        {
            foreach (var yearItem in YearsList)
            {
                if (item.DateRaised.Year.ToString() == yearItem.YearName.ToString())
                {
                    yearItem.YearNumber++;
                }
            }
        }
        //}
    }

    public void UpdateStartYear()
    {
        if(YearsList.Count == 0)
        {
            var yearDiffernce = currentYear - startYear;

            while (yearDiffernce >= 0)
            {
                YearsList.Add(new YearMaintenanceRequestModel { YearName = startYear.ToString(), YearNumber = 0 });
                startYear++;
                yearDiffernce--;
            }

            foreach (var item in requestViewModel.MaintReqs)
            {
                foreach (var yearItem in YearsList)
                {
                    if (item.DateRaised.Year.ToString() == yearItem.YearName.ToString())
                    {
                        yearItem.YearNumber++;
                    }
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IRequestsGraphDateViewModel requestViewModel { get; set; }
    }
}
#pragma warning restore 1591
