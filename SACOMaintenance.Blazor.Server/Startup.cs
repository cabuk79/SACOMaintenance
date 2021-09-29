using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Radzen;
using SACOMaintenance.Blazor.Server.Data;
using SACOMaintenance.Blazor.Server.Hubs;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel;
using SACOMaintenance.ViewModel.Interfaces;
using System.Linq;

namespace SACOMaintenance.Blazor.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SACOMaintenanceContext>(options=>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<Common.ModelDB.User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<SACOMaintenanceContext>().AddDefaultTokenProviders()
                .AddDefaultUI();

            services.AddScoped<IArea, AreaProvider>();
            services.AddScoped<IFactory, FactoryDataProvider>();
            services.AddScoped<ICompany, CompanyDataProvider>();
            services.AddScoped<IPPE, PPEDataProvider>();
            //services.AddScoped<IEquipment, EquipmentDataProvider>();
            services.AddScoped<IMaintRequestInitiation, MaintRequestInitiationDataProvider>();
            services.AddScoped<IGeneralRequest, GeneralRequestDataProvider>();
            services.AddScoped<IPlantRequest, PlantRequestDataProvider>();
            services.AddScoped<IMachineType, MachineTypeDataProvider>();
            services.AddScoped<IMaintRequestInitiation, MaintRequestInitiationDataProvider>();
            services.AddScoped<IRisk, RiskDataProvider>();
            services.AddScoped<IEquipment, EquipmentDataProvider>();
            services.AddScoped<IStatus, StatusDataProvider>();
            services.AddScoped<ISupplier, SupplierDataProvider>();
            services.AddScoped<IPart, PartDataProvider>();
            services.AddScoped<IOrder, OrderDataProvider>();
            services.AddScoped<IPriorities, PrioritiesDataProvider>();
            services.AddScoped<IIsolations, IsolationDataProvider>();
            services.AddScoped<IIsolationMaintRequestInitiation, IsolationMaintRequestInitiationDataProvider>();


            services.AddScoped<IMachineTypeViewModel, MachineTypeViewModel>();
            services.AddScoped<IAreaViewModel, AreaViewModel>();
            services.AddScoped<IFactoryViewModel, FactoryViewModel>();
            services.AddScoped<ICompanyViewModel, CompanyViewModel>();
            services.AddScoped<IRequestInitiationListViewModel, RequestInitiationListViewModel>();
            services.AddScoped<IMaintRequestFullViewModel, MaintRequestFullViewModel>();
            services.AddScoped<IPPEViewModel, PPEViewModel>();
            services.AddScoped<IDashboardViewModel, DashboardViewModel>();
            services.AddScoped<IPlantMaintReqViewModel, PlantMaintReqModelView>();
            services.AddScoped<IMaintReqNewViewModel, MaintReqNewViewModel>();
            services.AddScoped<IEquipmentViewModel, EquipmentViewModel>();
            services.AddScoped<IEquipmentListViewModel, EquipmentListViewModel>();
            services.AddScoped<IRequestsGraphViewModel, RequestsGraphViewModel>();
            services.AddScoped<IRequestsGraphDateViewModel, RequestsGraphDateViewModel>();
            services.AddScoped<ISupplierViewModel, SupplierViewModel>();
            services.AddScoped<IPartViewModel, PartViewModel>();
            services.AddScoped<IOrderViewModel, OrderViewModel>();
            services.AddScoped<IGeneralMaintRequestViewModel, GeneralMaintRequestViewModel>();
            services.AddScoped<IRequestsGraphViewModel, RequestsGraphViewModel>();

            services.AddSingleton<SmsService>();

            services.AddScoped<DialogService>();
            services.AddScoped<NotificationService>();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSignalR();

            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });

                    
        }

        
        

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

           

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
                endpoints.MapHub<BroadcastHub>("/broadcastHub");
                
                //app.UseSignalR(routes => routes.MapHub<Blazor.NetCore.Server.SignalRHub.SignalRHub>("/broadcastHub"));
            });
        }
    }
}
