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
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartSupplier> PartSuppliers { get; set; }

        public SACOMaintenanceContext(DbContextOptions<SACOMaintenanceContext> options) : base (options)
        {

        }

        //TODO: remove this and inject at runtime
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(
            //    "Data Source=LAPTOP-GMOCCUAU\\SQLEXPRESSLOCADB; Initial Catalog=SACOMaintenanceApp; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaintRequestInitiation>()
                .HasMany(r => r.Risks)
                .WithMany(b => b.MaintRequestInitiation)
                .UsingEntity<MaintRequestInitiationRisk>
                (mr => mr.HasOne<Risk>().WithMany(),
                mm => mm.HasOne<MaintRequestInitiation>().WithMany());

            modelBuilder.Entity<PartSupplier>()
                .Property(e => e.Price).HasPrecision(18, 4);
        }        
    }
}
