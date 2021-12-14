IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [Discriminator] nvarchar(max) NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [Comment] nvarchar(max) NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Companies] (
    [Id] int NOT NULL IDENTITY,
    [CompantName] nvarchar(max) NULL,
    CONSTRAINT [PK_Companies] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Departments] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Comments] nvarchar(max) NULL,
    CONSTRAINT [PK_Departments] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Factories] (
    [Id] int NOT NULL IDENTITY,
    [FactoryName] nvarchar(max) NULL,
    CONSTRAINT [PK_Factories] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Isolations] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_Isolations] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [MachineTypes] (
    [Id] int NOT NULL IDENTITY,
    [TypeName] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    CONSTRAINT [PK_MachineTypes] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Parts] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Comment] nvarchar(max) NULL,
    [MinQtyInStock] int NOT NULL,
    [CurrentQty] int NOT NULL,
    [PartId] int NULL,
    CONSTRAINT [PK_Parts] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Parts_Parts_PartId] FOREIGN KEY ([PartId]) REFERENCES [Parts] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [PostCodeTowns] (
    [Id] int NOT NULL IDENTITY,
    [PostCode] nvarchar(max) NULL,
    [County] nvarchar(max) NULL,
    [District] nvarchar(max) NULL,
    [Latitide] decimal(18,2) NOT NULL,
    [Longitude] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_PostCodeTowns] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [PPE] (
    [Id] int NOT NULL IDENTITY,
    [PPEName] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [IconFileLocation] nvarchar(max) NULL,
    [MaintRequestType] nvarchar(max) NULL,
    CONSTRAINT [PK_PPE] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Priorites] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Notes] nvarchar(max) NULL,
    [Icon] nvarchar(max) NULL,
    CONSTRAINT [PK_Priorites] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Risks] (
    [Id] int NOT NULL IDENTITY,
    [RiskName] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [MaintRequestType] nvarchar(max) NULL,
    CONSTRAINT [PK_Risks] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Statuses] (
    [Id] int NOT NULL IDENTITY,
    [StatusName] nvarchar(max) NULL,
    CONSTRAINT [PK_Statuses] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Areas] (
    [Id] int NOT NULL IDENTITY,
    [AreaName] nvarchar(max) NULL,
    [CommentsNotes] nvarchar(max) NULL,
    [FactoryId] int NULL,
    CONSTRAINT [PK_Areas] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Areas_Factories_FactoryId] FOREIGN KEY ([FactoryId]) REFERENCES [Factories] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [TechnicalDrawingsLocations] (
    [Id] int NOT NULL IDENTITY,
    [PartId] int NOT NULL,
    [DrawingFileLocation] nvarchar(max) NULL,
    CONSTRAINT [PK_TechnicalDrawingsLocations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TechnicalDrawingsLocations_Parts_PartId] FOREIGN KEY ([PartId]) REFERENCES [Parts] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Suppliers] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [GeneralEmailAddress] nvarchar(max) NULL,
    [TelephoneNumber] nvarchar(max) NULL,
    [Comments] nvarchar(max) NULL,
    [AddressLineOne] nvarchar(max) NULL,
    [AddressLineTwo] nvarchar(max) NULL,
    [PostCodeId] int NOT NULL,
    CONSTRAINT [PK_Suppliers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Suppliers_PostCodeTowns_PostCodeId] FOREIGN KEY ([PostCodeId]) REFERENCES [PostCodeTowns] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Equipment] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [MachineTypeId] int NOT NULL,
    [SerialIdentifierNumber] nvarchar(max) NULL,
    [Comments] nvarchar(max) NULL,
    [AreaId] int NULL,
    CONSTRAINT [PK_Equipment] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Equipment_Areas_AreaId] FOREIGN KEY ([AreaId]) REFERENCES [Areas] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Equipment_MachineTypes_MachineTypeId] FOREIGN KEY ([MachineTypeId]) REFERENCES [MachineTypes] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Orders] (
    [Id] int NOT NULL IDENTITY,
    [Description] nvarchar(max) NULL,
    [Date] datetime2 NOT NULL,
    [SupplierId] int NOT NULL,
    [DepartmentId] int NOT NULL,
    [Comments] nvarchar(max) NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Orders_Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Orders_Suppliers_SupplierId] FOREIGN KEY ([SupplierId]) REFERENCES [Suppliers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [PartSuppliers] (
    [Id] int NOT NULL IDENTITY,
    [PartId] int NOT NULL,
    [SupplierCode] nvarchar(max) NULL,
    [Price] decimal(18,4) NOT NULL,
    [SupplierId] int NOT NULL,
    CONSTRAINT [PK_PartSuppliers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PartSuppliers_Parts_PartId] FOREIGN KEY ([PartId]) REFERENCES [Parts] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_PartSuppliers_Suppliers_SupplierId] FOREIGN KEY ([SupplierId]) REFERENCES [Suppliers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [EquipmentPart] (
    [EquipmentId] int NOT NULL,
    [PartsId] int NOT NULL,
    CONSTRAINT [PK_EquipmentPart] PRIMARY KEY ([EquipmentId], [PartsId]),
    CONSTRAINT [FK_EquipmentPart_Equipment_EquipmentId] FOREIGN KEY ([EquipmentId]) REFERENCES [Equipment] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EquipmentPart_Parts_PartsId] FOREIGN KEY ([PartsId]) REFERENCES [Parts] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [MaintRequestInitiations] (
    [Id] int NOT NULL IDENTITY,
    [DateRaised] datetime2 NOT NULL,
    [CompanyId] int NULL,
    [FactoryId] int NULL,
    [AreaId] int NULL,
    [EquipmentId] int NULL,
    [RequestedById] int NOT NULL,
    [RequestDetails] nvarchar(max) NULL,
    [PriorityId] int NULL,
    [RequestTypeId] int NOT NULL,
    [StatusId] int NOT NULL,
    [AssignedTo] int NOT NULL,
    CONSTRAINT [PK_MaintRequestInitiations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_MaintRequestInitiations_Areas_AreaId] FOREIGN KEY ([AreaId]) REFERENCES [Areas] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_MaintRequestInitiations_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_MaintRequestInitiations_Equipment_EquipmentId] FOREIGN KEY ([EquipmentId]) REFERENCES [Equipment] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_MaintRequestInitiations_Factories_FactoryId] FOREIGN KEY ([FactoryId]) REFERENCES [Factories] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_MaintRequestInitiations_Priorites_PriorityId] FOREIGN KEY ([PriorityId]) REFERENCES [Priorites] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_MaintRequestInitiations_Statuses_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [Statuses] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [OrderItems] (
    [Id] int NOT NULL IDENTITY,
    [ItemName] nvarchar(max) NULL,
    [Comments] nvarchar(max) NULL,
    [Qty] int NOT NULL,
    [Price] decimal(18,2) NOT NULL,
    [OrderId] int NOT NULL,
    [PartId] int NULL,
    CONSTRAINT [PK_OrderItems] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_OrderItems_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_OrderItems_Parts_PartId] FOREIGN KEY ([PartId]) REFERENCES [Parts] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [GeneralRequests] (
    [Id] int NOT NULL IDENTITY,
    [MaintRequestId] int NOT NULL,
    [MaintRequestInitiationId] int NULL,
    [AuthorityToWorkUserId] int NOT NULL,
    [AuthorityToWorkDateTime] datetime2 NOT NULL,
    [DetailOfWorkCompleted] nvarchar(max) NULL,
    [DetailOfWorkCompeltedUserId] int NOT NULL,
    [DetailOfWorkCompeltedDateTime] datetime2 NOT NULL,
    [WorkCompletedYesNo] int NOT NULL,
    [WorkCompletedDetails] nvarchar(max) NULL,
    [SignOffDetails] nvarchar(max) NULL,
    [WorkCompletedSignOffYesNo] int NOT NULL,
    [WorkCompletedSignOffUserId] int NOT NULL,
    [WorkCompletedSignOffDateTime] int NOT NULL,
    CONSTRAINT [PK_GeneralRequests] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_GeneralRequests_MaintRequestInitiations_MaintRequestInitiationId] FOREIGN KEY ([MaintRequestInitiationId]) REFERENCES [MaintRequestInitiations] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [IsolationMaintRequestInitiation] (
    [IsolationsId] int NOT NULL,
    [MaintRequestInitiationsId] int NOT NULL,
    CONSTRAINT [PK_IsolationMaintRequestInitiation] PRIMARY KEY ([IsolationsId], [MaintRequestInitiationsId]),
    CONSTRAINT [FK_IsolationMaintRequestInitiation_Isolations_IsolationsId] FOREIGN KEY ([IsolationsId]) REFERENCES [Isolations] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_IsolationMaintRequestInitiation_MaintRequestInitiations_MaintRequestInitiationsId] FOREIGN KEY ([MaintRequestInitiationsId]) REFERENCES [MaintRequestInitiations] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [MaintRequestInitiationPPE] (
    [MaintRequestInitiationsId] int NOT NULL,
    [PPEEquipmentId] int NOT NULL,
    CONSTRAINT [PK_MaintRequestInitiationPPE] PRIMARY KEY ([MaintRequestInitiationsId], [PPEEquipmentId]),
    CONSTRAINT [FK_MaintRequestInitiationPPE_MaintRequestInitiations_MaintRequestInitiationsId] FOREIGN KEY ([MaintRequestInitiationsId]) REFERENCES [MaintRequestInitiations] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MaintRequestInitiationPPE_PPE_PPEEquipmentId] FOREIGN KEY ([PPEEquipmentId]) REFERENCES [PPE] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [MaintRequestInitiationRisk] (
    [MaintRequestInitiationId] int NOT NULL,
    [RiskId] int NOT NULL,
    [H] bit NOT NULL,
    [M] bit NOT NULL,
    [L] bit NOT NULL,
    CONSTRAINT [PK_MaintRequestInitiationRisk] PRIMARY KEY ([MaintRequestInitiationId], [RiskId]),
    CONSTRAINT [FK_MaintRequestInitiationRisk_MaintRequestInitiations_MaintRequestInitiationId] FOREIGN KEY ([MaintRequestInitiationId]) REFERENCES [MaintRequestInitiations] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MaintRequestInitiationRisk_Risks_RiskId] FOREIGN KEY ([RiskId]) REFERENCES [Risks] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [MaintRequestInitiationUser] (
    [MaintRequestInitiationId] int NOT NULL,
    [UsersId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_MaintRequestInitiationUser] PRIMARY KEY ([MaintRequestInitiationId], [UsersId]),
    CONSTRAINT [FK_MaintRequestInitiationUser_AspNetUsers_UsersId] FOREIGN KEY ([UsersId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MaintRequestInitiationUser_MaintRequestInitiations_MaintRequestInitiationId] FOREIGN KEY ([MaintRequestInitiationId]) REFERENCES [MaintRequestInitiations] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [PlantRequests] (
    [Id] int NOT NULL IDENTITY,
    [IsolationNitricAcid] bit NOT NULL,
    [IsolatedPhosphoricAcid] bit NOT NULL,
    [IsolatedSodiumHydroxide] bit NOT NULL,
    [IsolatedSulphuricAcid] bit NOT NULL,
    [IsolatedOther] nvarchar(max) NULL,
    [DrainingLinesNitricAcid] bit NOT NULL,
    [DrainingLinesPhosphoricAcid] bit NOT NULL,
    [DrainingLinesSodiumHydroxide] bit NOT NULL,
    [DrainingLinesSulphuricAcid] bit NOT NULL,
    [DrainingLinesOther] nvarchar(max) NULL,
    [IsolationsCompressedAir] bit NOT NULL,
    [IsolationsElectrical] bit NOT NULL,
    [IsolationsGas] bit NOT NULL,
    [IsolationsMechanical] bit NOT NULL,
    [IsolationsSteam] bit NOT NULL,
    [IsolationsWater] bit NOT NULL,
    [IsolationsOther] nvarchar(max) NULL,
    [OtherPrecautions] nvarchar(max) NULL,
    [AuthorisationToWorkUserId] int NOT NULL,
    [AuthorisationDatTime] datetime2 NOT NULL,
    [ReceiptPersonDoingWorkUserId] int NOT NULL,
    [ReceiptCompanyId] int NOT NULL,
    [ReceiptCompany] nvarchar(max) NULL,
    [ReceiptDateTime] datetime2 NOT NULL,
    [ClearanceDetails] nvarchar(max) NULL,
    [ClearanceCompanyId] int NOT NULL,
    [ClearancePosition] nvarchar(max) NULL,
    [ClearanceDateTime] datetime2 NOT NULL,
    [MaintRequestId] int NOT NULL,
    [MaintRequestInitiationId] int NULL,
    CONSTRAINT [PK_PlantRequests] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PlantRequests_MaintRequestInitiations_MaintRequestInitiationId] FOREIGN KEY ([MaintRequestInitiationId]) REFERENCES [MaintRequestInitiations] ([Id]) ON DELETE NO ACTION
);
GO

CREATE TABLE [RequestDailyRegisters] (
    [Id] int NOT NULL IDENTITY,
    [Date] datetime2 NOT NULL,
    [TimeIn] datetime2 NOT NULL,
    [TimOut] datetime2 NOT NULL,
    [PlantMaintRequestId] int NOT NULL,
    [PlantRequestId] int NULL,
    CONSTRAINT [PK_RequestDailyRegisters] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_RequestDailyRegisters_PlantRequests_PlantRequestId] FOREIGN KEY ([PlantRequestId]) REFERENCES [PlantRequests] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Areas_FactoryId] ON [Areas] ([FactoryId]);
GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

CREATE INDEX [IX_Equipment_AreaId] ON [Equipment] ([AreaId]);
GO

CREATE INDEX [IX_Equipment_MachineTypeId] ON [Equipment] ([MachineTypeId]);
GO

CREATE INDEX [IX_EquipmentPart_PartsId] ON [EquipmentPart] ([PartsId]);
GO

CREATE INDEX [IX_GeneralRequests_MaintRequestInitiationId] ON [GeneralRequests] ([MaintRequestInitiationId]);
GO

CREATE INDEX [IX_IsolationMaintRequestInitiation_MaintRequestInitiationsId] ON [IsolationMaintRequestInitiation] ([MaintRequestInitiationsId]);
GO

CREATE INDEX [IX_MaintRequestInitiationPPE_PPEEquipmentId] ON [MaintRequestInitiationPPE] ([PPEEquipmentId]);
GO

CREATE INDEX [IX_MaintRequestInitiationRisk_RiskId] ON [MaintRequestInitiationRisk] ([RiskId]);
GO

CREATE INDEX [IX_MaintRequestInitiations_AreaId] ON [MaintRequestInitiations] ([AreaId]);
GO

CREATE INDEX [IX_MaintRequestInitiations_CompanyId] ON [MaintRequestInitiations] ([CompanyId]);
GO

CREATE INDEX [IX_MaintRequestInitiations_EquipmentId] ON [MaintRequestInitiations] ([EquipmentId]);
GO

CREATE INDEX [IX_MaintRequestInitiations_FactoryId] ON [MaintRequestInitiations] ([FactoryId]);
GO

CREATE INDEX [IX_MaintRequestInitiations_PriorityId] ON [MaintRequestInitiations] ([PriorityId]);
GO

CREATE INDEX [IX_MaintRequestInitiations_StatusId] ON [MaintRequestInitiations] ([StatusId]);
GO

CREATE INDEX [IX_MaintRequestInitiationUser_UsersId] ON [MaintRequestInitiationUser] ([UsersId]);
GO

CREATE INDEX [IX_OrderItems_OrderId] ON [OrderItems] ([OrderId]);
GO

CREATE INDEX [IX_OrderItems_PartId] ON [OrderItems] ([PartId]);
GO

CREATE INDEX [IX_Orders_DepartmentId] ON [Orders] ([DepartmentId]);
GO

CREATE INDEX [IX_Orders_SupplierId] ON [Orders] ([SupplierId]);
GO

CREATE INDEX [IX_Parts_PartId] ON [Parts] ([PartId]);
GO

CREATE INDEX [IX_PartSuppliers_PartId] ON [PartSuppliers] ([PartId]);
GO

CREATE INDEX [IX_PartSuppliers_SupplierId] ON [PartSuppliers] ([SupplierId]);
GO

CREATE INDEX [IX_PlantRequests_MaintRequestInitiationId] ON [PlantRequests] ([MaintRequestInitiationId]);
GO

CREATE INDEX [IX_RequestDailyRegisters_PlantRequestId] ON [RequestDailyRegisters] ([PlantRequestId]);
GO

CREATE INDEX [IX_Suppliers_PostCodeId] ON [Suppliers] ([PostCodeId]);
GO

CREATE INDEX [IX_TechnicalDrawingsLocations_PartId] ON [TechnicalDrawingsLocations] ([PartId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210924151513_Restarted the migrations', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Areas] DROP CONSTRAINT [FK_Areas_Factories_FactoryId];
GO

ALTER TABLE [Equipment] DROP CONSTRAINT [FK_Equipment_Areas_AreaId];
GO

ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [FK_MaintRequestInitiations_Areas_AreaId];
GO

ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [FK_MaintRequestInitiations_Companies_CompanyId];
GO

ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [FK_MaintRequestInitiations_Equipment_EquipmentId];
GO

ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [FK_MaintRequestInitiations_Factories_FactoryId];
GO

ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [FK_MaintRequestInitiations_Priorites_PriorityId];
GO

ALTER TABLE [OrderItems] DROP CONSTRAINT [FK_OrderItems_Parts_PartId];
GO

ALTER TABLE [Suppliers] DROP CONSTRAINT [FK_Suppliers_PostCodeTowns_PostCodeId];
GO

EXEC sp_rename N'[Companies].[CompantName]', N'CompanyName', N'COLUMN';
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Suppliers]') AND [c].[name] = N'PostCodeId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Suppliers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Suppliers] ALTER COLUMN [PostCodeId] int NULL;
GO

DROP INDEX [IX_OrderItems_PartId] ON [OrderItems];
DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[OrderItems]') AND [c].[name] = N'PartId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [OrderItems] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [OrderItems] ALTER COLUMN [PartId] int NOT NULL;
ALTER TABLE [OrderItems] ADD DEFAULT 0 FOR [PartId];
CREATE INDEX [IX_OrderItems_PartId] ON [OrderItems] ([PartId]);
GO

DROP INDEX [IX_MaintRequestInitiations_PriorityId] ON [MaintRequestInitiations];
DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MaintRequestInitiations]') AND [c].[name] = N'PriorityId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [MaintRequestInitiations] ALTER COLUMN [PriorityId] int NOT NULL;
ALTER TABLE [MaintRequestInitiations] ADD DEFAULT 0 FOR [PriorityId];
CREATE INDEX [IX_MaintRequestInitiations_PriorityId] ON [MaintRequestInitiations] ([PriorityId]);
GO

DROP INDEX [IX_MaintRequestInitiations_FactoryId] ON [MaintRequestInitiations];
DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MaintRequestInitiations]') AND [c].[name] = N'FactoryId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [MaintRequestInitiations] ALTER COLUMN [FactoryId] int NOT NULL;
ALTER TABLE [MaintRequestInitiations] ADD DEFAULT 0 FOR [FactoryId];
CREATE INDEX [IX_MaintRequestInitiations_FactoryId] ON [MaintRequestInitiations] ([FactoryId]);
GO

DROP INDEX [IX_MaintRequestInitiations_EquipmentId] ON [MaintRequestInitiations];
DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MaintRequestInitiations]') AND [c].[name] = N'EquipmentId');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [MaintRequestInitiations] ALTER COLUMN [EquipmentId] int NOT NULL;
ALTER TABLE [MaintRequestInitiations] ADD DEFAULT 0 FOR [EquipmentId];
CREATE INDEX [IX_MaintRequestInitiations_EquipmentId] ON [MaintRequestInitiations] ([EquipmentId]);
GO

DROP INDEX [IX_MaintRequestInitiations_CompanyId] ON [MaintRequestInitiations];
DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MaintRequestInitiations]') AND [c].[name] = N'CompanyId');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [MaintRequestInitiations] ALTER COLUMN [CompanyId] int NOT NULL;
ALTER TABLE [MaintRequestInitiations] ADD DEFAULT 0 FOR [CompanyId];
CREATE INDEX [IX_MaintRequestInitiations_CompanyId] ON [MaintRequestInitiations] ([CompanyId]);
GO

DROP INDEX [IX_MaintRequestInitiations_AreaId] ON [MaintRequestInitiations];
DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MaintRequestInitiations]') AND [c].[name] = N'AreaId');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [MaintRequestInitiations] ALTER COLUMN [AreaId] int NOT NULL;
ALTER TABLE [MaintRequestInitiations] ADD DEFAULT 0 FOR [AreaId];
CREATE INDEX [IX_MaintRequestInitiations_AreaId] ON [MaintRequestInitiations] ([AreaId]);
GO

DROP INDEX [IX_Equipment_AreaId] ON [Equipment];
DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'AreaId');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [AreaId] int NOT NULL;
ALTER TABLE [Equipment] ADD DEFAULT 0 FOR [AreaId];
CREATE INDEX [IX_Equipment_AreaId] ON [Equipment] ([AreaId]);
GO

DROP INDEX [IX_Areas_FactoryId] ON [Areas];
DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Areas]') AND [c].[name] = N'FactoryId');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Areas] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Areas] ALTER COLUMN [FactoryId] int NOT NULL;
ALTER TABLE [Areas] ADD DEFAULT 0 FOR [FactoryId];
CREATE INDEX [IX_Areas_FactoryId] ON [Areas] ([FactoryId]);
GO

ALTER TABLE [Areas] ADD CONSTRAINT [FK_Areas_Factories_FactoryId] FOREIGN KEY ([FactoryId]) REFERENCES [Factories] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [Equipment] ADD CONSTRAINT [FK_Equipment_Areas_AreaId] FOREIGN KEY ([AreaId]) REFERENCES [Areas] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [MaintRequestInitiations] ADD CONSTRAINT [FK_MaintRequestInitiations_Areas_AreaId] FOREIGN KEY ([AreaId]) REFERENCES [Areas] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [MaintRequestInitiations] ADD CONSTRAINT [FK_MaintRequestInitiations_Companies_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [Companies] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [MaintRequestInitiations] ADD CONSTRAINT [FK_MaintRequestInitiations_Equipment_EquipmentId] FOREIGN KEY ([EquipmentId]) REFERENCES [Equipment] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [MaintRequestInitiations] ADD CONSTRAINT [FK_MaintRequestInitiations_Factories_FactoryId] FOREIGN KEY ([FactoryId]) REFERENCES [Factories] ([Id]) ON DELETE NO ACTION;
GO

ALTER TABLE [MaintRequestInitiations] ADD CONSTRAINT [FK_MaintRequestInitiations_Priorites_PriorityId] FOREIGN KEY ([PriorityId]) REFERENCES [Priorites] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [OrderItems] ADD CONSTRAINT [FK_OrderItems_Parts_PartId] FOREIGN KEY ([PartId]) REFERENCES [Parts] ([Id]) ON DELETE CASCADE;
GO

ALTER TABLE [Suppliers] ADD CONSTRAINT [FK_Suppliers_PostCodeTowns_PostCodeId] FOREIGN KEY ([PostCodeId]) REFERENCES [PostCodeTowns] ([Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210925144042_Worked on and removed the fields that are nullable etc', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [MaintRequestInitiations] ADD [Closed] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

ALTER TABLE [AspNetUsers] ADD [AvatarLocation] nvarchar(max) NULL;
GO

CREATE TABLE [MaintReqUptateNotes] (
    [Id] int NOT NULL IDENTITY,
    [Text] nvarchar(max) NULL,
    [CreationDate] datetime2 NOT NULL,
    [UserId] nvarchar(450) NULL,
    [MaintRequestInitiationId] int NULL,
    CONSTRAINT [PK_MaintReqUptateNotes] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_MaintReqUptateNotes_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_MaintReqUptateNotes_MaintRequestInitiations_MaintRequestInitiationId] FOREIGN KEY ([MaintRequestInitiationId]) REFERENCES [MaintRequestInitiations] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_MaintReqUptateNotes_MaintRequestInitiationId] ON [MaintReqUptateNotes] ([MaintRequestInitiationId]);
GO

CREATE INDEX [IX_MaintReqUptateNotes_UserId] ON [MaintReqUptateNotes] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210927122339_Added the MaintReqUptateNotes model', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [GeneralRequests] ADD [ControlMeasuresTaken] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210928131344_Added ControlMeasuresTaken to GeenralRequest model', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'WorkCompletedYesNo');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [WorkCompletedYesNo] int NULL;
GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'WorkCompletedSignOffYesNo');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [WorkCompletedSignOffYesNo] int NULL;
GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'WorkCompletedSignOffUserId');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [WorkCompletedSignOffUserId] int NULL;
GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'WorkCompletedSignOffDateTime');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [WorkCompletedSignOffDateTime] int NULL;
GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'DetailOfWorkCompeltedUserId');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [DetailOfWorkCompeltedUserId] int NULL;
GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'AuthorityToWorkUserId');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [AuthorityToWorkUserId] int NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210928133556_Changed the GeneralRequest integer to be nullable', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'DetailOfWorkCompeltedDateTime');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [DetailOfWorkCompeltedDateTime] datetime2 NULL;
GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'AuthorityToWorkDateTime');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [AuthorityToWorkDateTime] datetime2 NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210928133702_Changed the GeneralRequest Datetimes to be nullable', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [AspNetUsers] ADD [Pin] int NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210929063452_Added encrypted column Pin in User model', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'Discriminator');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [AspNetUsers] DROP COLUMN [Discriminator];
GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'Pin');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [AspNetUsers] ALTER COLUMN [Pin] int NOT NULL;
ALTER TABLE [AspNetUsers] ADD DEFAULT 0 FOR [Pin];
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210929075302_Updating after adding Identy code information', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DROP TABLE [MaintRequestInitiationUser];
GO

CREATE TABLE [AuthorizationRequests] (
    [MaintRequestInitiationId] int NOT NULL,
    [UserId] nvarchar(450) NOT NULL,
    [AuthorizationType] nvarchar(max) NULL,
    [Satus] nvarchar(max) NULL,
    CONSTRAINT [PK_AuthorizationRequests] PRIMARY KEY ([MaintRequestInitiationId], [UserId]),
    CONSTRAINT [FK_AuthorizationRequests_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AuthorizationRequests_MaintRequestInitiations_MaintRequestInitiationId] FOREIGN KEY ([MaintRequestInitiationId]) REFERENCES [MaintRequestInitiations] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_AuthorizationRequests_UserId] ON [AuthorizationRequests] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210929201626_Added AuthrozationRequest model', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'WorkCompletedSignOffUserId');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [WorkCompletedSignOffUserId] nvarchar(max) NULL;
GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'AuthorityToWorkUserId');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [AuthorityToWorkUserId] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210930130642_Changed the Authrization IDs in the GeenralMaintenance Model to string to match the User table', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [AuthorizationRequests] ADD [LastChaseDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

ALTER TABLE [AuthorizationRequests] ADD [RequestedDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210930142733_Added RequestedDate and LastChaseDate to AhutoraziationRequest model', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [AuthorizationRequests] DROP CONSTRAINT [FK_AuthorizationRequests_AspNetUsers_UserId];
GO

ALTER TABLE [AuthorizationRequests] DROP CONSTRAINT [PK_AuthorizationRequests];
GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AuthorizationRequests]') AND [c].[name] = N'UserId');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [AuthorizationRequests] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [AuthorizationRequests] ALTER COLUMN [UserId] nvarchar(450) NULL;
GO

ALTER TABLE [AuthorizationRequests] ADD [Id] int NOT NULL IDENTITY;
GO

ALTER TABLE [AuthorizationRequests] ADD CONSTRAINT [PK_AuthorizationRequests] PRIMARY KEY ([Id]);
GO

CREATE INDEX [IX_AuthorizationRequests_MaintRequestInitiationId] ON [AuthorizationRequests] ([MaintRequestInitiationId]);
GO

ALTER TABLE [AuthorizationRequests] ADD CONSTRAINT [FK_AuthorizationRequests_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211001082508_Added a OK to the Authroization Model', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[GeneralRequests]') AND [c].[name] = N'DetailOfWorkCompeltedUserId');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [GeneralRequests] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [GeneralRequests] ALTER COLUMN [DetailOfWorkCompeltedUserId] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211003105419_Changed Compelted user Id from int to string', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Priorites] ADD [Colour] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211003183229_Added Colour property to Priority model', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [Isolations] ADD [ImageLocation] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211006132515_Added ImageLocation field to the Isolation model', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MaintRequestInitiations]') AND [c].[name] = N'RequestedById');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [MaintRequestInitiations] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [MaintRequestInitiations] DROP COLUMN [RequestedById];
GO

ALTER TABLE [MaintRequestInitiations] ADD [UserId] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211006192202_Changed RequestedById to UserId and added User navigation in MaintRequestInitation model', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [MaintReqUsersAssigned] (
    [MaintRequestInitiationId] int NOT NULL,
    [UserId] nvarchar(450) NOT NULL,
    [DateAssigned] datetime2 NOT NULL,
    CONSTRAINT [PK_MaintReqUsersAssigned] PRIMARY KEY ([MaintRequestInitiationId], [UserId]),
    CONSTRAINT [FK_MaintReqUsersAssigned_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_MaintReqUsersAssigned_MaintRequestInitiations_MaintRequestInitiationId] FOREIGN KEY ([MaintRequestInitiationId]) REFERENCES [MaintRequestInitiations] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_MaintReqUsersAssigned_UserId] ON [MaintReqUsersAssigned] ([UserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211007103402_Added the MaintRequestUsersAssigned model and information into the DbContext to assign the FK to Users and MaintReqInitiation', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MaintRequestInitiationRisk]') AND [c].[name] = N'H');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [MaintRequestInitiationRisk] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [MaintRequestInitiationRisk] DROP COLUMN [H];
GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MaintRequestInitiationRisk]') AND [c].[name] = N'L');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [MaintRequestInitiationRisk] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [MaintRequestInitiationRisk] DROP COLUMN [L];
GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[MaintRequestInitiationRisk]') AND [c].[name] = N'M');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [MaintRequestInitiationRisk] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [MaintRequestInitiationRisk] DROP COLUMN [M];
GO

ALTER TABLE [MaintRequestInitiationRisk] ADD [Level] nvarchar(max) NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211021171628_Updated MaintRequestInitationRisk model to remove the HML as bools and replaced with a string Level', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [AuthorizationRequestMaintRequestInitiation] (
    [AuthorizationRequestId] int NOT NULL,
    [MaintRequestInitiationId] int NOT NULL,
    CONSTRAINT [PK_AuthorizationRequestMaintRequestInitiation] PRIMARY KEY ([AuthorizationRequestId], [MaintRequestInitiationId]),
    CONSTRAINT [FK_AuthorizationRequestMaintRequestInitiation_AuthorizationRequests_AuthorizationRequestId] FOREIGN KEY ([AuthorizationRequestId]) REFERENCES [AuthorizationRequests] ([Id]),
    CONSTRAINT [FK_AuthorizationRequestMaintRequestInitiation_MaintRequestInitiations_MaintRequestInitiationId] FOREIGN KEY ([MaintRequestInitiationId]) REFERENCES [MaintRequestInitiations] ([Id])
);
GO

CREATE INDEX [IX_AuthorizationRequestMaintRequestInitiation_MaintRequestInitiationId] ON [AuthorizationRequestMaintRequestInitiation] ([MaintRequestInitiationId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211029171631_Added to MaintRequestInitation navigation link to Authorization Requests and vice versa in the AuthriseRequest model', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DROP TABLE [AuthorizationRequestMaintRequestInitiation];
GO

ALTER TABLE [AuthorizationRequests] ADD [MaintRequestInitiationsId] int NULL;
GO

CREATE INDEX [IX_AuthorizationRequests_MaintRequestInitiationsId] ON [AuthorizationRequests] ([MaintRequestInitiationsId]);
GO

ALTER TABLE [AuthorizationRequests] ADD CONSTRAINT [FK_AuthorizationRequests_MaintRequestInitiations_MaintRequestInitiationsId] FOREIGN KEY ([MaintRequestInitiationsId]) REFERENCES [MaintRequestInitiations] ([Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211029173154_Changed the navigation property in the AuthroizationRequest model from List to virtual MaintRequestInitation', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [AuthorizationRequests] DROP CONSTRAINT [FK_AuthorizationRequests_MaintRequestInitiations_MaintRequestInitiationsId];
GO

DROP INDEX [IX_AuthorizationRequests_MaintRequestInitiationsId] ON [AuthorizationRequests];
GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AuthorizationRequests]') AND [c].[name] = N'MaintRequestInitiationsId');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [AuthorizationRequests] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [AuthorizationRequests] DROP COLUMN [MaintRequestInitiationsId];
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211029175222_Removed maint req to auth requests navigations', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [AuthorizationRequests] ADD [CommentRejection] nvarchar(max) NULL;
GO

ALTER TABLE [AuthorizationRequests] ADD [ConfirmationDate] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211101205029_Added to the Authorisation model ConfrimationDate and CommentReason', N'5.0.9');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

ALTER TABLE [OrderItems] DROP CONSTRAINT [FK_OrderItems_Parts_PartId];
GO

DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[OrderItems]') AND [c].[name] = N'PartId');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [OrderItems] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [OrderItems] ALTER COLUMN [PartId] int NULL;
GO

ALTER TABLE [OrderItems] ADD CONSTRAINT [FK_OrderItems_Parts_PartId] FOREIGN KEY ([PartId]) REFERENCES [Parts] ([Id]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211116204135_Made the PartId in the orderItem model nullable', N'5.0.9');
GO

COMMIT;
GO

