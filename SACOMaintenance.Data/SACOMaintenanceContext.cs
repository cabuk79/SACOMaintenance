﻿using Microsoft.EntityFrameworkCore;
using SACOMaintenance.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Data
{
    public class SACOMaintenanceContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
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


        //TODO: remove this and inject at runtime
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=LAPTOP-GMOCCUAU\\SQLEXPRESSLOCADB; Initial Catalog=SACOMaintenanceApp; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factory>().HasData
            (
                new Factory { Id = 1, FactoryName = "F1" },
                new Factory { Id = 2, FactoryName = "F2" },
                new Factory { Id = 3, FactoryName = "F3" }
            );
        }
    }
}
