#pragma checksum "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5d66b437a20aee88f22af0d529432122404018f"
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
            __builder.AddAttribute(8, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                  args => @maintReqListViewModel.ExportList()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "Text", "Export All Requests");
            __builder.AddAttribute(10, "Icon", "import_export");
            __builder.AddAttribute(11, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 15 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                            ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-lg-12");
            __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.MaintRequestsListOverview.TypeInference.CreateRadzenGrid_0(__builder, 17, 18, 
#nullable restore
#line 20 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                               maintReqListViewModel.requests

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 21 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                       DataGridSelectionMode.Single

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 22 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                       true

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 23 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                        true

#line default
#line hidden
#nullable disable
            , 22, 
#nullable restore
#line 23 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                                     FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            , 23, 
#nullable restore
#line 24 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                    FilterMode.Advanced

#line default
#line hidden
#nullable disable
            , 24, 
#nullable restore
#line 24 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            , 25, 
#nullable restore
#line 25 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                     true

#line default
#line hidden
#nullable disable
            , 26, (__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(27);
                __builder2.AddAttribute(28, "Property", "Id");
                __builder2.AddAttribute(29, "Title", "Number");
                __builder2.AddAttribute(30, "Width", "100px");
                __builder2.AddAttribute(31, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiation>)((data) => (__builder3) => {
                    __builder3.AddMarkupContent(32, "\r\n                            MAINT-");
                    __builder3.AddContent(33, 
#nullable restore
#line 29 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                   data.Id

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(35);
                __builder2.AddAttribute(36, "Property", "RequestDetails");
                __builder2.AddAttribute(37, "Title", "Details");
                __builder2.AddAttribute(38, "Width", "250px");
                __builder2.AddAttribute(39, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiation>)((data) => (__builder3) => {
                    __builder3.OpenElement(40, "p");
                    __builder3.AddAttribute(41, "style", "white-space:pre-wrap");
                    __builder3.AddContent(42, 
#nullable restore
#line 34 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                              (MarkupString)data.RequestDetails

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(44);
                __builder2.AddAttribute(45, "Property", "DateRaised");
                __builder2.AddAttribute(46, "Title", "Date Raised");
                __builder2.AddAttribute(47, "Width", "100px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(49);
                __builder2.AddAttribute(50, "Property", "Equipment.Name");
                __builder2.AddAttribute(51, "Title", "Equipment Name");
                __builder2.AddAttribute(52, "Width", "100px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(54);
                __builder2.AddAttribute(55, "Property", "Status.StatusName");
                __builder2.AddAttribute(56, "Title", "Status");
                __builder2.AddAttribute(57, "Width", "80px");
                __builder2.AddAttribute(58, "FilterTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>)((context) => (__builder3) => {
                    __Blazor.SACOMaintenance.Blazor.Server.Pages.ReqInititation.MaintRequestsListOverview.TypeInference.CreateRadzenDropDown_1(__builder3, 59, 60, "Text", 61, "Value", 62, "width:100%", 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 43 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                    OnChange

#line default
#line hidden
#nullable disable
                    ), 64, 
#nullable restore
#line 44 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                   maintReqListViewModel.statusList.Select(t => new { Text = $"{t.StatusName}", Value = t.Id })

#line default
#line hidden
#nullable disable
                    , 65, 
#nullable restore
#line 41 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                          maintReqListViewModel.StatusId

#line default
#line hidden
#nullable disable
                    , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => maintReqListViewModel.StatusId = __value, maintReqListViewModel.StatusId)), 67, () => maintReqListViewModel.StatusId);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<MaintRequestInitiation>>(69);
                __builder2.AddAttribute(70, "Property", "maintReqListViewModel.Id");
                __builder2.AddAttribute(71, "Title", "Actions");
                __builder2.AddAttribute(72, "Width", "30px");
                __builder2.AddAttribute(73, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 49 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                 TextAlign.Center

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                                                                                false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "Template", (Microsoft.AspNetCore.Components.RenderFragment<MaintRequestInitiation>)((data) => (__builder3) => {
                    __builder3.OpenElement(77, "a");
                    __builder3.AddAttribute(78, "href", 
#nullable restore
#line 51 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
                                       $"maint-req/full-add/{data.Id}"

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(79, "class", "btn btn-primary table-btn");
                    __builder3.AddMarkupContent(80, "<i class=\"fa fa-pencil-square\"></i>");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            , 81, (__value) => {
#nullable restore
#line 22 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
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
#line 71 "C:\Users\cabuk\source\repos\SACOMaintenance\SACOMaintenance.Blazor.Server\Pages\ReqInititation\MaintRequestsListOverview.razor"
          

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

    

#line default
#line hidden
#nullable disable
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
