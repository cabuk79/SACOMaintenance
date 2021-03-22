﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SACOMaintenance.Data;

namespace SACOMaintenance.Data.Migrations
{
    [DbContext(typeof(SACOMaintenanceContext))]
    [Migration("20210320210830_Removed virtual navigation properties in MaintRequestInitiationRisk")]
    partial class RemovedvirtualnavigationpropertiesinMaintRequestInitiationRisk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MaintRequestInitiationPPE", b =>
                {
                    b.Property<int>("MaintRequestInitiationsId")
                        .HasColumnType("int");

                    b.Property<int>("PPEEquipmentId")
                        .HasColumnType("int");

                    b.HasKey("MaintRequestInitiationsId", "PPEEquipmentId");

                    b.HasIndex("PPEEquipmentId");

                    b.ToTable("MaintRequestInitiationPPE");
                });

            modelBuilder.Entity("MaintRequestInitiationUser", b =>
                {
                    b.Property<int>("MaintRequestInitiationId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("MaintRequestInitiationId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("MaintRequestInitiationUser");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.AreaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentsNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FactoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FactoryId");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompantName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MachineTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialIdentifierNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.Factory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FactoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Factories");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.GeneralRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AuthorityToWorkDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("AuthorityToWorkUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DetailOfWorkCompeltedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DetailOfWorkCompeltedUserId")
                        .HasColumnType("int");

                    b.Property<string>("DetailOfWorkCompleted")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaintRequestId")
                        .HasColumnType("int");

                    b.Property<int?>("MaintRequestInitiationId")
                        .HasColumnType("int");

                    b.Property<string>("SignOffDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCompletedDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkCompletedSignOffDateTime")
                        .HasColumnType("int");

                    b.Property<int>("WorkCompletedSignOffUserId")
                        .HasColumnType("int");

                    b.Property<int>("WorkCompletedSignOffYesNo")
                        .HasColumnType("int");

                    b.Property<int>("WorkCompletedYesNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaintRequestInitiationId");

                    b.ToTable("GeneralRequests");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.MachineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MachineTypes");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.MaintRequestInitiation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AreaId")
                        .HasColumnType("int");

                    b.Property<int>("AssignedTo")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRaised")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int?>("FactoryId")
                        .HasColumnType("int");

                    b.Property<string>("RequestDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestTypeId")
                        .HasColumnType("int");

                    b.Property<int>("RequestedById")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("FactoryId");

                    b.HasIndex("StatusId");

                    b.ToTable("MaintRequestInitiations");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.MaintRequestInitiationRisk", b =>
                {
                    b.Property<int>("MaintRequestInitiationId")
                        .HasColumnType("int");

                    b.Property<int>("RiskId")
                        .HasColumnType("int");

                    b.Property<string>("RiskLevel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaintRequestInitiationId", "RiskId");

                    b.HasIndex("RiskId");

                    b.ToTable("MaintRequestInitiationRisk");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.PPE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconFileLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaintRequestType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PPEName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PPE");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.PlantRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AuthorisationDatTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("AuthorisationToWorkUserId")
                        .HasColumnType("int");

                    b.Property<int>("ClearanceCompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ClearanceDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ClearanceDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClearancePosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DrainingLinesNitricAcid")
                        .HasColumnType("bit");

                    b.Property<string>("DrainingLinesOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DrainingLinesPhosphoricAcid")
                        .HasColumnType("bit");

                    b.Property<bool>("DrainingLinesSodiumHydroxide")
                        .HasColumnType("bit");

                    b.Property<bool>("DrainingLinesSulphuricAcid")
                        .HasColumnType("bit");

                    b.Property<string>("IsolatedOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsolatedPhosphoricAcid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsolatedSodiumHydroxide")
                        .HasColumnType("bit");

                    b.Property<bool>("IsolatedSulphuricAcid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsolationNitricAcid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsolationsCompressedAir")
                        .HasColumnType("bit");

                    b.Property<bool>("IsolationsElectrical")
                        .HasColumnType("bit");

                    b.Property<bool>("IsolationsGas")
                        .HasColumnType("bit");

                    b.Property<bool>("IsolationsMechanical")
                        .HasColumnType("bit");

                    b.Property<string>("IsolationsOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsolationsSteam")
                        .HasColumnType("bit");

                    b.Property<bool>("IsolationsWater")
                        .HasColumnType("bit");

                    b.Property<int>("MaintRequestId")
                        .HasColumnType("int");

                    b.Property<int?>("MaintRequestInitiationId")
                        .HasColumnType("int");

                    b.Property<string>("OtherPrecautions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiptCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiptCompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceiptDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReceiptPersonDoingWorkUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaintRequestInitiationId");

                    b.ToTable("PlantRequests");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.RequestDailyRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlantMaintRequestId")
                        .HasColumnType("int");

                    b.Property<int?>("PlantRequestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeIn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PlantRequestId");

                    b.ToTable("RequestDailyRegisters");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.Risk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaintRequestType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RiskName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Risks");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MaintRequestInitiationPPE", b =>
                {
                    b.HasOne("SACOMaintenance.Common.ModelDB.MaintRequestInitiation", null)
                        .WithMany()
                        .HasForeignKey("MaintRequestInitiationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SACOMaintenance.Common.ModelDB.PPE", null)
                        .WithMany()
                        .HasForeignKey("PPEEquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MaintRequestInitiationUser", b =>
                {
                    b.HasOne("SACOMaintenance.Common.ModelDB.MaintRequestInitiation", null)
                        .WithMany()
                        .HasForeignKey("MaintRequestInitiationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SACOMaintenance.Common.ModelDB.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.AreaModel", b =>
                {
                    b.HasOne("SACOMaintenance.Common.ModelDB.Factory", null)
                        .WithMany("Areas")
                        .HasForeignKey("FactoryId");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.Equipment", b =>
                {
                    b.HasOne("SACOMaintenance.Common.ModelDB.AreaModel", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId");

                    b.Navigation("Area");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.GeneralRequest", b =>
                {
                    b.HasOne("SACOMaintenance.Common.ModelDB.MaintRequestInitiation", "MaintRequestInitiation")
                        .WithMany()
                        .HasForeignKey("MaintRequestInitiationId");

                    b.Navigation("MaintRequestInitiation");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.MaintRequestInitiation", b =>
                {
                    b.HasOne("SACOMaintenance.Common.ModelDB.AreaModel", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId");

                    b.HasOne("SACOMaintenance.Common.ModelDB.Company", "Company")
                        .WithMany("MaintenanceRequestIniations")
                        .HasForeignKey("CompanyId");

                    b.HasOne("SACOMaintenance.Common.ModelDB.Equipment", "Equipment")
                        .WithMany("MaintRequestInitiations")
                        .HasForeignKey("EquipmentId");

                    b.HasOne("SACOMaintenance.Common.ModelDB.Factory", "Factory")
                        .WithMany("MaintRequestInitiations")
                        .HasForeignKey("FactoryId");

                    b.HasOne("SACOMaintenance.Common.ModelDB.Status", "Status")
                        .WithMany("MaintRequestInitiations")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Company");

                    b.Navigation("Equipment");

                    b.Navigation("Factory");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.MaintRequestInitiationRisk", b =>
                {
                    b.HasOne("SACOMaintenance.Common.ModelDB.MaintRequestInitiation", null)
                        .WithMany()
                        .HasForeignKey("MaintRequestInitiationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SACOMaintenance.Common.ModelDB.Risk", null)
                        .WithMany()
                        .HasForeignKey("RiskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.PlantRequest", b =>
                {
                    b.HasOne("SACOMaintenance.Common.ModelDB.MaintRequestInitiation", "MaintRequestInitiation")
                        .WithMany()
                        .HasForeignKey("MaintRequestInitiationId");

                    b.Navigation("MaintRequestInitiation");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.RequestDailyRegister", b =>
                {
                    b.HasOne("SACOMaintenance.Common.ModelDB.PlantRequest", "PlantRequest")
                        .WithMany()
                        .HasForeignKey("PlantRequestId");

                    b.Navigation("PlantRequest");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.Company", b =>
                {
                    b.Navigation("MaintenanceRequestIniations");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.Equipment", b =>
                {
                    b.Navigation("MaintRequestInitiations");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.Factory", b =>
                {
                    b.Navigation("Areas");

                    b.Navigation("MaintRequestInitiations");
                });

            modelBuilder.Entity("SACOMaintenance.Common.ModelDB.Status", b =>
                {
                    b.Navigation("MaintRequestInitiations");
                });
#pragma warning restore 612, 618
        }
    }
}
