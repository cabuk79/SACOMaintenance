using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;

[assembly: HostingStartup(typeof(SACOMaintenance.Blazor.Server.Areas.Identity.IdentityHostingStartup))]
namespace SACOMaintenance.Blazor.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}