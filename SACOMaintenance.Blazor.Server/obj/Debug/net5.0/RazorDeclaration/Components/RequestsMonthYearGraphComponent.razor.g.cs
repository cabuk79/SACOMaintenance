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
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
using Models.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
using ExcelLibs;

#line default
#line hidden
#nullable disable
    public partial class RequestsMonthYearGraphComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
       

    //public class YearMonthModel
    //{
    //    public int monthCount { get; set; }
    //    public string monthName { get; set; }
    //}

    public void OnClick()
    {
        MaintenanceRequestsGraphsExportToExcel exportChartData = new MaintenanceRequestsGraphsExportToExcel();
        exportChartData.ExportRequestYearMonth(testList);
    }

    public List<int> years = new();

    RadzenChart monthYearChart;

    static int janCount, febCount, marchCount, aprilCount, mayCount, juneCount,
    julyCount, augCount, septCount, octCount, novCount, decCount;

    List<YearMonthModel> testList;

    void OnChange(object value, string name)
    {

        testList = new List<YearMonthModel>();

        int yearChosen = Convert.ToInt32(value);

        janCount = 0; febCount = 0; marchCount = 0; aprilCount = 0; mayCount = 0; juneCount = 0; julyCount = 0;
        augCount = 0; septCount = 0; octCount = 0; novCount = 0; decCount = 0;


        requestViewModel.GetRequests();

        foreach (var item in requestViewModel.MaintReqs)
        {
            var year = DateTime.Parse(item.DateRaised.ToString()).Year;

            if (year == yearChosen)
            {
                var month = DateTime.Parse(item.DateRaised.ToString()).Month;

                switch (month)
                {
                    case 1:
                        janCount++;
                        break;
                    case 2:
                        febCount++;
                        break;
                    case 3:
                        marchCount++;
                        break;
                    case 4:
                        aprilCount++;
                        break;
                    case 5:
                        mayCount++;
                        break;
                    case 6:
                        juneCount++;
                        break;
                    case 7:
                        julyCount++;
                        break;
                    case 8:
                        augCount++;
                        break;
                    case 9:
                        septCount++;
                        break;
                    case 10:
                        octCount++;
                        break;
                    case 11:
                        novCount++;
                        break;
                    case 12:
                        decCount++;
                        break;
                }
            }
        }

        testList.Add(new YearMonthModel { monthCount = janCount, monthName = "January" });
        testList.Add(new YearMonthModel { monthCount = febCount, monthName = "Feburary" });
        testList.Add(new YearMonthModel { monthCount = marchCount, monthName = "March" });
        testList.Add(new YearMonthModel { monthCount = aprilCount, monthName = "April" });
        testList.Add(new YearMonthModel { monthCount = mayCount, monthName = "May" });
        testList.Add(new YearMonthModel { monthCount = juneCount, monthName = "June" });
        testList.Add(new YearMonthModel { monthCount = julyCount, monthName = "July" });
        testList.Add(new YearMonthModel { monthCount = augCount, monthName = "August" });
        testList.Add(new YearMonthModel { monthCount = septCount, monthName = "September" });
        testList.Add(new YearMonthModel { monthCount = octCount, monthName = "October" });
        testList.Add(new YearMonthModel { monthCount = novCount, monthName = "November" });
        testList.Add(new YearMonthModel { monthCount = decCount, monthName = "December" });
    }



    protected override void OnInitialized()
    {
        var startYear = 2019;
        var currentYear = DateTime.Parse(Convert.ToString(DateTime.Now)).Year;
        var yearWorkingWith = startYear;

        while (yearWorkingWith <= currentYear)
        {
            years.Add(yearWorkingWith);
            yearWorkingWith++;
        }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IRequestsGraphDateViewModel requestViewModel { get; set; }
    }
}
#pragma warning restore 1591