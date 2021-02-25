using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Data
{
    public class SACOMaintenanceContext : DbContext
    {
        public DbSet<AreaModel> Areas { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<GeneralRequest> GeneralRequests { get; set; }
        public DbSet<MachineType> MachineTypes { get; set; }
        public DbSet<MaintRequestInitiation> MaintRequestInitiations { get; set; }
        public DbSet<PlantRequest> PlantRequests { get; set; }
        public DbSet<PPE> PPE { get; set; }
        public DbSet<RequestDailyRegister> RequestDailyRegisters { get; set; }
        public DbSet<Risk> Risks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Status> Statuses { get; set; }

        public SACOMaintenanceContext(DbContextOptions<SACOMaintenanceContext> options) : base (options)
        {

        }

        //TODO: remove this and inject at runtime
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(
            //    "Data Source=LAPTOP-GMOCCUAU\\SQLEXPRESSLOCADB; Initial Catalog=SACOMaintenanceApp; Trusted_Connection=True");
        }

        //Seed the basic data to use, other seeding is done in the testing
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //Companies Seed Data
        //    modelBuilder.Entity<Company>().HasData
        //    (
        //        new Company { Id = 1, CompantName = "SACO" },
        //        new Company { Id = 2, CompantName = "Nekem" },
        //        new Company { Id = 3, CompantName = "FL" }
        //    );

        //    modelBuilder.Entity<Status>().HasData
        //    (
        //        new Status { Id = 1, StatusName = "Open" },
        //        new Status { Id = 2, StatusName = "New" },
        //        new Status { Id = 3, StatusName = "Completed" },
        //        new Status { Id = 4, StatusName = "Cancelled" },
        //        new Status { Id = 5, StatusName = "On Hold" }
        //    );

        //    //Area Seed Data
        //    modelBuilder.Entity<Area>().HasData
        //    (
        //        new Area { Id = 1, AreaName = "Warehouse" },
        //        new Area { Id = 2, AreaName = "Plant" },
        //        new Area { Id = 3, AreaName = "Press Shop" },
        //        new Area { Id = 4, AreaName = "Tool Room" },
        //        new Area { Id = 5, AreaName = "Assembly" },
        //        new Area { Id = 6, AreaName = "Offices F3" },
        //        new Area { Id = 7, AreaName = "FL Production" },
        //        new Area { Id = 8, AreaName = "GTL Production"}
        //    );

        //    //PPE Seed data
        //    modelBuilder.Entity<PPE>().HasData
        //    (
        //        new PPE { Id = 1, Description = "General gloves", PPEName = "Gloves" },
        //        new PPE { Id = 2, Description = "Hard covered saftey glasses", PPEName = "Saftey Glasses" },
        //        new PPE { Id = 3, Description = "Steel toe capped", PPEName = "Saftery Boots"}
        //    );

        //    //Factory Seed Data
        //    modelBuilder.Entity<Factory>().HasData
        //    (
        //        new Factory { Id = 1, FactoryName = "F1" },
        //        new Factory { Id = 2, FactoryName = "F2" },
        //        new Factory { Id = 3, FactoryName = "F3" }
        //    );

        //    //Risk Seed Data
        //    modelBuilder.Entity<Risk>().HasData
        //    (
        //        new Risk { Id = 1, RiskName = "Risk 1"},
        //        new Risk { Id = 2, RiskName = "Risk 2" }
        //    );
        //}
    }
}
