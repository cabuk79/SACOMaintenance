#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ce5cf672fdd8ef6689e56aefcbbec6c9c72e2f5"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
using SACOMaintenance.Common.ModelDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
using SACOMaintenance.Blazor.Server.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
using SACOMaintenance.Blazor.Server.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
using ClosedXML.Excel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/maintrequests-list")]
    public partial class MaintRequestsListOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<div class=\"col-lg-10\"><h1>All Maintenance Requests</h1></div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg-2");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(7);
            __builder.AddAttribute(8, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                  ExportExcelFile

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Text", "Export All Requests");
            __builder.AddAttribute(10, "Icon", "import_export");
            __builder.AddAttribute(11, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 24 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                            ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(13);
            __builder.AddAttribute(14, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                  DownloadToolDrg

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "Text", "Drawing PDF");
            __builder.AddAttribute(16, "Icon", "import_export");
            __builder.AddAttribute(17, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 26 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                            ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "row");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-lg-12");
            __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.MaintRequestsListOverview.TypeInference.CreateRadzenGrid_0(__builder, 23, 24, 
#nullable restore
#line 31 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                               maintReqListViewModel.requests

#line default
#line hidden
#nullable disable
            , 25, 
#nullable restore
#line 32 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                       DataGridSelectionMode.Single

#line default
#line hidden
#nullable disable
            , 26, 
#nullable restore
#line 33 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                       true

#line default
#line hidden
#nullable disable
            , 27, 
#nullable restore
#line 34 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                        true

#line default
#line hidden
#nullable disable
            , 28, 
#nullable restore
#line 34 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                                     FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            , 29, 
#nullable restore
#line 35 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                    FilterMode.Advanced

#line default
#line hidden
#nullable disable
            , 30, 
#nullable restore
#line 35 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            , 31, 
#nullable restore
#line 36 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                     true

#line default
#line hidden
#nullable disable
            , 32, (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(33);
                __builder2.AddAttribute(34, "Property", "Id");
                __builder2.AddAttribute(35, "Title", "Number");
                __builder2.AddAttribute(36, "Width", "100px");
                __builder2.AddAttribute(37, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiation>)((data) => (__builder3) => {
                    __builder3.AddMarkupContent(38, "\r\n                            MAINT-");
#nullable restore
#line 40 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
__builder3.AddContent(39, data.Id);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(41);
                __builder2.AddAttribute(42, "Property", "RequestDetails");
                __builder2.AddAttribute(43, "Title", "Details");
                __builder2.AddAttribute(44, "Width", "250px");
                __builder2.AddAttribute(45, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiation>)((data) => (__builder3) => {
                    __builder3.OpenElement(46, "p");
                    __builder3.AddAttribute(47, "style", "white-space:pre-wrap");
#nullable restore
#line 45 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
__builder3.AddContent(48, (MarkupString)data.RequestDetails);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(50);
                __builder2.AddAttribute(51, "Property", "DateRaised");
                __builder2.AddAttribute(52, "Title", "Date Raised");
                __builder2.AddAttribute(53, "Width", "100px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(55);
                __builder2.AddAttribute(56, "Property", "Equipment.Name");
                __builder2.AddAttribute(57, "Title", "Equipment Name");
                __builder2.AddAttribute(58, "Width", "100px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(60);
                __builder2.AddAttribute(61, "Property", "Status.StatusName");
                __builder2.AddAttribute(62, "Title", "Status");
                __builder2.AddAttribute(63, "Width", "80px");
                __builder2.AddAttribute(64, "FilterTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>)((context) => (__builder3) => {
                    __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.MaintRequestsListOverview.TypeInference.CreateRadzenDropDown_1(__builder3, 65, 66, "Text", 67, "Value", 68, "width:100%", 69, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 54 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                    OnChange

#line default
#line hidden
#nullable disable
                    ), 70, 
#nullable restore
#line 55 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                   maintReqListViewModel.statusList.Select(t => new { Text = $"{t.StatusName}", Value = t.Id })

#line default
#line hidden
#nullable disable
                    , 71, 
#nullable restore
#line 52 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                          maintReqListViewModel.StatusId

#line default
#line hidden
#nullable disable
                    , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => maintReqListViewModel.StatusId = __value, maintReqListViewModel.StatusId)), 73, () => maintReqListViewModel.StatusId);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(75);
                __builder2.AddAttribute(76, "Property", "maintReqListViewModel.Id");
                __builder2.AddAttribute(77, "Title", "Actions");
                __builder2.AddAttribute(78, "Width", "30px");
                __builder2.AddAttribute(79, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 60 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                 TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 60 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                                                                false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiation>)((data) => (__builder3) => {
                    __builder3.OpenElement(83, "a");
                    __builder3.AddAttribute(84, "href", 
#nullable restore
#line 62 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                       $"maint-req/full-add/{data.Id}"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(85, "class", "btn btn-primary table-btn");
                    __builder3.AddMarkupContent(86, "<i class=\"fa fa-pencil-square\"></i>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            , 87, (__value) => {
#nullable restore
#line 33 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                              maintGrid = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
      

    public RadzenGrid<MaintRequestInitiation> maintGrid { get; set; }

    private HubConnection hubConnection;

    void OnChange()
    {

        maintReqListViewModel.LoadReqsByStatusId(maintReqListViewModel.StatusId);
        maintGrid.Reload();
        InvokeAsync(StateHasChanged);



        //= maintReqListViewModel.requests
        //.Where(e => e.StatusId == maintReqListViewModel.currentStatus.Id);


        //.Where(e => Convert.ToInt32(maintReqListViewModel.currentStatus) >= 0 ?
        //e.Status == maintReqListViewModel.currentStatus : true);
    }

    public async Task DownloadToolDrg()
    {
        await FileDownload.DownloadPDF(@"C:\Excel Export Test\test.pdf");
    }

    public async Task ExportExcelFile()
    {
        await ExcelExport.ExportListToExcel(maintReqListViewModel.requests);
    }



    protected override async Task OnInitializedAsync()
    {
        maintReqListViewModel.LoadRequests();

        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/broadcastHub"))
            .Build();

        hubConnection.On("ReceiveMessage", () =>
        {
            CallLoadData();
            InvokeAsync(() => StateHasChanged());
            maintGrid.Reload();
        });

        await hubConnection.StartAsync();

        //maintReqListViewModel.LoadRequests();
    }

    private void CallLoadData()
    {
        Task.Run(async () =>
        {
            maintReqListViewModel.LoadRequests();
        });
    }



    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public void Dispose()
    {
        _ = hubConnection.DisposeAsync();
    }



    

   









    public async Task ExportListToExcel()
    {

        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Maint Requests All");

            worksheet.Cell("A1").Value = "All Maintenance Requests";
            worksheet.Cell("A1").Style.Font.Bold = true;
            worksheet.Cell("A1").Style.Font.FontSize = 20;
            worksheet.Range("A1", "E1").Merge(true);

            worksheet.Cell("A2").Value = "Id";
            worksheet.Cell("A2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Cell("A2").Style.Font.Bold = true;

            worksheet.Cell("B2").Value = "Details";
            worksheet.Cell("B2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Cell("B2").Style.Font.Bold = true;

            worksheet.Cell("C2").Value = "Date Raised";
            worksheet.Cell("C2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Cell("C2").Style.Font.Bold = true;

            worksheet.Cell("D2").Value = "Equipment Name";
            worksheet.Cell("D2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Cell("D2").Style.Font.Bold = true;

            worksheet.Cell("E2").Value = "Status";
            worksheet.Cell("E2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Cell("E2").Style.Font.Bold = true;

            worksheet.Column(1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Column(3).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Column(4).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            worksheet.Column(5).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

            worksheet.Range("A2", "E2").SetAutoFilter();

            //loop through the collection and put the items in columns then increment to the next row
            var i = 3; //declare the row number to start

            //loop through the items in the list
            foreach (var item in maintReqListViewModel.requests)
            {
                worksheet.Cell("A" + i).Value = item.Id;
                worksheet.Cell("B" + i).Value = item.RequestDetails;
                worksheet.Cell("C" + i).Value = item.DateRaised;
                worksheet.Cell("D" + i).Value = item.Equipment.Name;
                worksheet.Cell("E" + i).Value = item.Status.StatusName;
                i++;
            }

            worksheet.Columns("A", "E").AdjustToContents();

            //Save workbook on server
            workbook.SaveAs(@"C:\Excel Export Test\All Maint Requests.xlsx");

            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                var content = stream.ToArray();

                var fileName = "Countries.xlsx";
                await JSRuntime.InvokeAsync<object>("saveAsFile", fileName, Convert.ToBase64String(content));
                // await JSRuntime.InvokeAsync<object>("BlazorDownloadFile", Convert.ToBase64String(content), fileName);

            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileDownloadService FileDownload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MaintenanceRequestsExcel ExcelExport { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SACOMaintenance.ViewModel.Interfaces.IRequestInitiationListViewModel maintReqListViewModel { get; set; }
    }
}
namespace __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.MaintRequestsListOverview
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Radzen.DataGridSelectionMode __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Radzen.FilterCaseSensitivity __arg4, int __seq5, global::Radzen.FilterMode __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::System.Boolean __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::System.Action<global::Radzen.Blazor.RadzenGrid<TItem>> __arg9)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "SelectionMode", __arg1);
        __builder.AddAttribute(__seq2, "AllowSorting", __arg2);
        __builder.AddAttribute(__seq3, "AllowFiltering", __arg3);
        __builder.AddAttribute(__seq4, "FilterCaseSensitivity", __arg4);
        __builder.AddAttribute(__seq5, "FilterMode", __arg5);
        __builder.AddAttribute(__seq6, "AllowColumnResize", __arg6);
        __builder.AddAttribute(__seq7, "AllowPaging", __arg7);
        __builder.AddAttribute(__seq8, "Columns", __arg8);
        __builder.AddComponentReferenceCapture(__seq9, (__value) => { __arg9((global::Radzen.Blazor.RadzenGrid<TItem>)__value); });
        __builder.CloseComponent();
        }
        public static void CreateRadzenDropDown_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Object> __arg3, int __seq4, global::System.Collections.IEnumerable __arg4, int __seq5, global::System.Object __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDown<TValue>>(seq);
        __builder.AddAttribute(__seq0, "TextProperty", __arg0);
        __builder.AddAttribute(__seq1, "ValueProperty", __arg1);
        __builder.AddAttribute(__seq2, "Style", __arg2);
        __builder.AddAttribute(__seq3, "Change", __arg3);
        __builder.AddAttribute(__seq4, "Data", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
