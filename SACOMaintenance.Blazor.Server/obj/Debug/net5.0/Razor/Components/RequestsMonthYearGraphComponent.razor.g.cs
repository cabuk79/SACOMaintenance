#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36137426e5a952928067e38a04dc5c031b87b6bf"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Requests by Year and Month</h3>\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenDropDown<int>>(1);
            __builder.AddAttribute(2, "AllowClear", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Placeholder", "Select Year....");
            __builder.AddAttribute(4, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 9 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
                      years

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 10 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
                         args => OnChange(args, "DropDown")

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(7);
            __builder.AddAttribute(8, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
                      args => OnClick()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Text", "Export Chart Data");
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(11);
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.SACOMaintenance.Blazor.Server.Components.RequestsMonthYearGraphComponent.TypeInference.CreateRadzenColumnSeries_0(__builder2, 13, 14, 
#nullable restore
#line 17 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
                               testList

#line default
#line hidden
#nullable disable
                , 15, "monthName", 16, "Month", 17, "monthCount");
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenColumnOptions>(19);
                __builder2.AddAttribute(20, "Radius", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 19 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
                                 5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(22);
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(24);
                    __builder3.AddAttribute(25, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
                                  true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(27);
                    __builder3.AddAttribute(28, "Text", "Number of Status");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddComponentReferenceCapture(29, (__value) => {
#nullable restore
#line 16 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Components\RequestsMonthYearGraphComponent.razor"
                   monthYearChart = (Radzen.Blazor.RadzenChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
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
namespace __Blazor.SACOMaintenance.Blazor.Server.Components.RequestsMonthYearGraphComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenColumnSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenColumnSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "CategoryProperty", __arg1);
        __builder.AddAttribute(__seq2, "Title", __arg2);
        __builder.AddAttribute(__seq3, "ValueProperty", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
