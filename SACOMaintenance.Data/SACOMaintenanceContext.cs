using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;

namespace SACOMaintenance.Data
{
    public class SACOMaintenanceContext : IdentityDbContext<User>
    {
        public DbSet<AreaModel> Areas { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<GeneralRequest> GeneralRequests { get; set; }
        public DbSet<MachineType> MachineTypes { get; set; }
        public DbSet<MaintRequestInitiation> MaintRequestInitiations { get; set; }
        public DbSet<MaintRequestInitiationRisk> MaintRequestInitiationRisk { get; set; }
        public DbSet<PlantRequest> PlantRequests { get; set; }
        public DbSet<PPE> PPE { get; set; }
        public DbSet<RequestDailyRegister> RequestDailyRegisters { get; set; }
        public DbSet<Risk> Risks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<PostCodeTown> PostCodeTowns { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartSupplier> PartSuppliers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<TechnicalDrawingsLocation> TechnicalDrawingsLocations { get; set; }
        public DbSet<Priority> Priorites { get; set; }
        public DbSet<Isolation> Isolations { get; set; }
        public DbSet<MaintReqUptateNote> MaintReqUptateNotes { get; set; }
        public DbSet<AuthorizationRequest> AuthorizationRequests { get; set; }
        public DbSet<MaintRequestUsersAssigned> MaintReqUsersAssigned { get; set; }


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
            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<MaintRequestInitiation>()
                .HasMany(r => r.Risks)
                .WithMany(b => b.MaintRequestInitiation)
                .UsingEntity<MaintRequestInitiationRisk>
                (mr => mr.HasOne<Risk>().WithMany(),
                mm => mm.HasOne<MaintRequestInitiation>().WithMany());

            modelBuilder.Entity<MaintRequestInitiation>()
                .HasMany(r => r.Users)
                .WithMany(b => b.MaintRequestInitiations)
                .UsingEntity<AuthorizationRequest>
                (mr => mr.HasOne<User>().WithMany(),
                mm => mm.HasOne<MaintRequestInitiation>().WithMany());

            modelBuilder.Entity<MaintRequestInitiation>()
                .HasMany(r => r.Users)
                .WithMany(b => b.MaintRequestInitiations)
                .UsingEntity<MaintRequestUsersAssigned>
                (mr => mr.HasOne<User>().WithMany(),
                mm => mm.HasOne<MaintRequestInitiation>().WithMany());

            //modelBuilder.Entity<IsolationMaintRequestInitiation>().HasKey(i => new { i.IsolationsId, i.MaintReqInitationListId });

            //modelBuilder.Entity<MaintRequestInitiation>()
            //    .HasMany(r => r.Isolations)
            //    .WithMany(b => b.MaintRequestInitiation)
            //    .UsingEntity<IsolationMaintRequestInitiation>
            //    (mr => mr.HasOne<Isolation>().WithMany(),
            //    mm => mm.HasOne<MaintRequestInitiation>().WithMany());

            modelBuilder.Entity<PartSupplier>()
                .Property(e => e.Price).HasPrecision(18, 4);

            //Set the defautl value of the closed column to false
            modelBuilder.Entity<MaintRequestInitiation>()
                .Property(b => b.Closed)
                .HasDefaultValue(false);

            //Console.WriteLine(modelBuilder.Model.ToDebugString(Microsoft.EntityFrameworkCore.Infrastructure.MetadataDebugStringOptions.IncludeAnnotations));
        }        
    }
}
