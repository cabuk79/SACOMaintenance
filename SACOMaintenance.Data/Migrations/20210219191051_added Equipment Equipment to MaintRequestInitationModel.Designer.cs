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
    [Migration("20210219191051_added Equipment Equipment to MaintRequestInitationModel")]
    partial class addedEquipmentEquipmenttoMaintRequestInitationModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

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

            modelBuilder.Entity("MaintRequestInitiationRisk", b =>
                {
                    b.Property<int>("MaintRequestInitiationId")
                        .HasColumnType("int");

                    b.Property<int>("RisksId")
                        .HasColumnType("int");

                    b.HasKey("MaintRequestInitiationId", "RisksId");

                    b.HasIndex("RisksId");

                    b.ToTable("MaintRequestInitiationRisk");
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

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AreaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentsNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FactoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Areas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AreaName = "Warehouse",
                            FactoryId = 0
                        },
                        new
                        {
                            Id = 2,
                            AreaName = "Plant",
                            FactoryId = 0
                        },
                        new
                        {
                            Id = 3,
                            AreaName = "Press Shop",
                            FactoryId = 0
                        },
                        new
                        {
                            Id = 4,
                            AreaName = "Tool Room",
                            FactoryId = 0
                        },
                        new
                        {
                            Id = 5,
                            AreaName = "Assembly",
                            FactoryId = 0
                        },
                        new
                        {
                            Id = 6,
                            AreaName = "Offices F3",
                            FactoryId = 0
                        },
                        new
                        {
                            Id = 7,
                            AreaName = "FL Production",
                            FactoryId = 0
                        },
                        new
                        {
                            Id = 8,
                            AreaName = "GTL Production",
                            FactoryId = 0
                        });
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompantName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompantName = "SACO"
                        },
                        new
                        {
                            Id = 2,
                            CompantName = "Nekem"
                        },
                        new
                        {
                            Id = 3,
                            CompantName = "FL"
                        });
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AreaId")
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

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.Factory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FactoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Factories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FactoryName = "F1"
                        },
                        new
                        {
                            Id = 2,
                            FactoryName = "F2"
                        },
                        new
                        {
                            Id = 3,
                            FactoryName = "F3"
                        });
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.GeneralRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.ToTable("GeneralRequests");
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.MachineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MachineTypes");
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.MaintRequestInitiation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRaised")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("FactoryId")
                        .HasColumnType("int");

                    b.Property<string>("RequestDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequestTypeId")
                        .HasColumnType("int");

                    b.Property<int>("RequestedById")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.ToTable("MaintRequestInitiations");
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.PPE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "General gloves",
                            PPEName = "Gloves"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Hard covered saftey glasses",
                            PPEName = "Saftey Glasses"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Steel toe capped",
                            PPEName = "Saftery Boots"
                        });
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.PlantRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.Property<int>("DrainingLinesNitricAcid")
                        .HasColumnType("int");

                    b.Property<string>("DrainingLinesOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DrainingLinesPhosphoricAcid")
                        .HasColumnType("int");

                    b.Property<int>("DrainingLinesSodiumHydroxide")
                        .HasColumnType("int");

                    b.Property<int>("DrainingLinesSulphuricAcid")
                        .HasColumnType("int");

                    b.Property<string>("IsolatedOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsolatedPhosphoricAcid")
                        .HasColumnType("int");

                    b.Property<int>("IsolatedSodiumHydroxide")
                        .HasColumnType("int");

                    b.Property<int>("IsolatedSulphuricAcid")
                        .HasColumnType("int");

                    b.Property<int>("IsolationNitricAcid")
                        .HasColumnType("int");

                    b.Property<int>("IsolationsCompressedAir")
                        .HasColumnType("int");

                    b.Property<int>("IsolationsElectrical")
                        .HasColumnType("int");

                    b.Property<int>("IsolationsGas")
                        .HasColumnType("int");

                    b.Property<int>("IsolationsMechanical")
                        .HasColumnType("int");

                    b.Property<string>("IsolationsOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsolationsSteam")
                        .HasColumnType("int");

                    b.Property<int>("IsolationsWater")
                        .HasColumnType("int");

                    b.Property<int>("MaintRequestId")
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

                    b.ToTable("PlantRequests");
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.RequestDailyRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaintReqiestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimOut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeIn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RequestDailyRegisters");
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.Risk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaintRequestType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RiskName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Risks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RiskName = "Risk 1"
                        },
                        new
                        {
                            Id = 2,
                            RiskName = "Risk 2"
                        });
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StatusName = "Open"
                        },
                        new
                        {
                            Id = 2,
                            StatusName = "New"
                        },
                        new
                        {
                            Id = 3,
                            StatusName = "Completed"
                        },
                        new
                        {
                            Id = 4,
                            StatusName = "Cancelled"
                        },
                        new
                        {
                            Id = 5,
                            StatusName = "On Hold"
                        });
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MaintRequestInitiationPPE", b =>
                {
                    b.HasOne("SACOMaintenance.BuisnessModels.MaintRequestInitiation", null)
                        .WithMany()
                        .HasForeignKey("MaintRequestInitiationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SACOMaintenance.BuisnessModels.PPE", null)
                        .WithMany()
                        .HasForeignKey("PPEEquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MaintRequestInitiationRisk", b =>
                {
                    b.HasOne("SACOMaintenance.BuisnessModels.MaintRequestInitiation", null)
                        .WithMany()
                        .HasForeignKey("MaintRequestInitiationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SACOMaintenance.BuisnessModels.Risk", null)
                        .WithMany()
                        .HasForeignKey("RisksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MaintRequestInitiationUser", b =>
                {
                    b.HasOne("SACOMaintenance.BuisnessModels.MaintRequestInitiation", null)
                        .WithMany()
                        .HasForeignKey("MaintRequestInitiationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SACOMaintenance.BuisnessModels.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SACOMaintenance.BuisnessModels.MaintRequestInitiation", b =>
                {
                    b.HasOne("SACOMaintenance.BuisnessModels.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId");

                    b.Navigation("Equipment");
                });
#pragma warning restore 612, 618
        }
    }
}
