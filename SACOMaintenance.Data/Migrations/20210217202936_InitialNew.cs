﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SACOMaintenance.Data.Migrations
{
    public partial class InitialNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentsNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompantName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MachineTypeId = table.Column<int>(type: "int", nullable: false),
                    SerialIdentifierNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Factories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintRequestId = table.Column<int>(type: "int", nullable: false),
                    AuthorityToWorkUserId = table.Column<int>(type: "int", nullable: false),
                    AuthorityToWorkDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DetailOfWorkCompleted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailOfWorkCompeltedUserId = table.Column<int>(type: "int", nullable: false),
                    DetailOfWorkCompeltedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkCompletedYesNo = table.Column<int>(type: "int", nullable: false),
                    WorkCompletedDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SignOffDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkCompletedSignOffYesNo = table.Column<int>(type: "int", nullable: false),
                    WorkCompletedSignOffUserId = table.Column<int>(type: "int", nullable: false),
                    WorkCompletedSignOffDateTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MachineTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintRequestInitiations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRaised = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    FactoryId = table.Column<int>(type: "int", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    RequestedById = table.Column<int>(type: "int", nullable: false),
                    RequestDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestTypeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintRequestInitiations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlantRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsolationNitricAcid = table.Column<int>(type: "int", nullable: false),
                    IsolatedPhosphoricAcid = table.Column<int>(type: "int", nullable: false),
                    IsolatedSodiumHydroxide = table.Column<int>(type: "int", nullable: false),
                    IsolatedSulphuricAcid = table.Column<int>(type: "int", nullable: false),
                    IsolatedOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrainingLinesNitricAcid = table.Column<int>(type: "int", nullable: false),
                    DrainingLinesPhosphoricAcid = table.Column<int>(type: "int", nullable: false),
                    DrainingLinesSodiumHydroxide = table.Column<int>(type: "int", nullable: false),
                    DrainingLinesSulphuricAcid = table.Column<int>(type: "int", nullable: false),
                    DrainingLinesOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsolationsCompressedAir = table.Column<int>(type: "int", nullable: false),
                    IsolationsElectrical = table.Column<int>(type: "int", nullable: false),
                    IsolationsGas = table.Column<int>(type: "int", nullable: false),
                    IsolationsMechanical = table.Column<int>(type: "int", nullable: false),
                    IsolationsSteam = table.Column<int>(type: "int", nullable: false),
                    IsolationsWater = table.Column<int>(type: "int", nullable: false),
                    IsolationsOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherPrecautions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorisationToWorkUserId = table.Column<int>(type: "int", nullable: false),
                    AuthorisationDatTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiptPersonDoingWorkUserId = table.Column<int>(type: "int", nullable: false),
                    ReceiptCompanyId = table.Column<int>(type: "int", nullable: false),
                    ReceiptCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiptDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClearanceDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClearanceCompanyId = table.Column<int>(type: "int", nullable: false),
                    ClearancePosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClearanceDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaintRequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PPE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PPEName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconFileLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaintRequestType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PPE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestDailyRegisters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaintReqiestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestDailyRegisters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Risks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaintRequestType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintRequestInitiationPPE",
                columns: table => new
                {
                    MaintRequestInitiationsId = table.Column<int>(type: "int", nullable: false),
                    PPEEquipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintRequestInitiationPPE", x => new { x.MaintRequestInitiationsId, x.PPEEquipmentId });
                    table.ForeignKey(
                        name: "FK_MaintRequestInitiationPPE_MaintRequestInitiations_MaintRequestInitiationsId",
                        column: x => x.MaintRequestInitiationsId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintRequestInitiationPPE_PPE_PPEEquipmentId",
                        column: x => x.PPEEquipmentId,
                        principalTable: "PPE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintRequestInitiationRisk",
                columns: table => new
                {
                    MaintRequestInitiationId = table.Column<int>(type: "int", nullable: false),
                    RisksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintRequestInitiationRisk", x => new { x.MaintRequestInitiationId, x.RisksId });
                    table.ForeignKey(
                        name: "FK_MaintRequestInitiationRisk_MaintRequestInitiations_MaintRequestInitiationId",
                        column: x => x.MaintRequestInitiationId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintRequestInitiationRisk_Risks_RisksId",
                        column: x => x.RisksId,
                        principalTable: "Risks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaintRequestInitiationUser",
                columns: table => new
                {
                    MaintRequestInitiationId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintRequestInitiationUser", x => new { x.MaintRequestInitiationId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MaintRequestInitiationUser_MaintRequestInitiations_MaintRequestInitiationId",
                        column: x => x.MaintRequestInitiationId,
                        principalTable: "MaintRequestInitiations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaintRequestInitiationUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "AreaName", "CommentsNotes", "FactoryId" },
                values: new object[,]
                {
                    { 1, "Warehouse", null, 0 },
                    { 2, "Plant", null, 0 },
                    { 3, "Press Shop", null, 0 },
                    { 4, "Tool Room", null, 0 },
                    { 5, "Assembly", null, 0 },
                    { 6, "Offices F3", null, 0 },
                    { 7, "FL Production", null, 0 },
                    { 8, "GTL Production", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CompantName" },
                values: new object[,]
                {
                    { 1, "SACO" },
                    { 2, "Nekem" },
                    { 3, "FL" }
                });

            migrationBuilder.InsertData(
                table: "Factories",
                columns: new[] { "Id", "FactoryName" },
                values: new object[,]
                {
                    { 3, "F3" },
                    { 1, "F1" },
                    { 2, "F2" }
                });

            migrationBuilder.InsertData(
                table: "PPE",
                columns: new[] { "Id", "Description", "IconFileLocation", "MaintRequestType", "PPEName" },
                values: new object[,]
                {
                    { 1, "General gloves", null, null, "Gloves" },
                    { 2, "Hard covered saftey glasses", null, null, "Saftey Glasses" },
                    { 3, "Steel toe capped", null, null, "Saftery Boots" }
                });

            migrationBuilder.InsertData(
                table: "Risks",
                columns: new[] { "Id", "Description", "MaintRequestType", "RiskName" },
                values: new object[,]
                {
                    { 1, null, null, "Risk 1" },
                    { 2, null, null, "Risk 2" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "StatusName" },
                values: new object[,]
                {
                    { 4, "Cancelled" },
                    { 1, "Open" },
                    { 2, "New" },
                    { 3, "Completed" },
                    { 5, "On Hold" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiationPPE_PPEEquipmentId",
                table: "MaintRequestInitiationPPE",
                column: "PPEEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiationRisk_RisksId",
                table: "MaintRequestInitiationRisk",
                column: "RisksId");

            migrationBuilder.CreateIndex(
                name: "IX_MaintRequestInitiationUser_UsersId",
                table: "MaintRequestInitiationUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Factories");

            migrationBuilder.DropTable(
                name: "GeneralRequests");

            migrationBuilder.DropTable(
                name: "MachineTypes");

            migrationBuilder.DropTable(
                name: "MaintRequestInitiationPPE");

            migrationBuilder.DropTable(
                name: "MaintRequestInitiationRisk");

            migrationBuilder.DropTable(
                name: "MaintRequestInitiationUser");

            migrationBuilder.DropTable(
                name: "PlantRequests");

            migrationBuilder.DropTable(
                name: "RequestDailyRegisters");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "PPE");

            migrationBuilder.DropTable(
                name: "Risks");

            migrationBuilder.DropTable(
                name: "MaintRequestInitiations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
