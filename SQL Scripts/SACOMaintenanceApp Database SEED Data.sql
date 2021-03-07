
--Factory Table SEED data
INSERT INTO Factories (FactoryName) Values ('F1');
INSERT INTO Factories (FactoryName) Values ('F2');
INSERT INTO Factories (FactoryName) Values ('F3');

--Companies Table SEED Data
INSERT INTO Companies (CompantName) Values ('SACO');
INSERT INTO Companies (CompantName) Values ('Nekem');
INSERT INTO Companies (CompantName) Values ('FL');

--AREAS Table SEED data
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Warehouse F2', 'F2 warehouse area', 2);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Warehouse F3', 'F3 warehouse area at the end of factory 3', 3)
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Plant', 'Plant 1 and 2 areas', 1);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Press Shop', 'Pressing area', 2);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Tool Room', 'End of F2', 2);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Assembly', 'Assembly machine room , tool room, office and QC office', 2);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Offices F3', 'Includes Sales, HR, Nekem and projects offices', 3);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('FL Production', 'Production area', 3);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('GTL Production', 'Production area', 3);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('F1 Top Floor Offices', 'These offices are currently not in use', 1);

--Maint Request Type Table SEED Data
INSERT INTO MaintRequestTypes (TypeName) Values ('Plant');
INSERT INTO MaintRequestTypes (TypeName) Values ('Genenral');
INSERT INTO MaintRequestTypes (TypeName) Values ('Both');

--PPE Table SEED Data
INSERT INTO PPE (PPEName, Description, IconFileLocation, MaintRequestType) 
            Values ('Gloves', 'css/Images/glasses.jpg', 1);
INSERT INTO PPE (PPEName, Description, IconFileLocation, MaintRequestType)
            Values ('Hard Hat', 'css/Images/glasses.jpg', 1);
INSERT INTO PPE (PPEName, Description, IconFileLocation, MaintRequestType)
            Values ('Safety Boots', 'css/Images/glasses.jpg', 1);
INSERT INTO PPE (PPEName, Description, IconFileLocation, MaintRequestType)
            Values ('Respitory Mask', 'css/Images/glasses.jpg', 1);            
INSERT INTO PPE (PPEName, Description, IconFileLocation, MaintRequestType)
            Values ('Overalls', 'css/Images/glasses.jpg', 1);
INSERT INTO PPE (PPEName, Description, IconFileLocation, MaintRequestType)
            Values ('Rubber Gloves', 'css/Images/glasses.jpg', 1);

--Equipment SEED Data
INSERT INTO Equipment (Name, Description, MachineTypeId, SerialIdentifierNumber, Comments, AreaId) 
            Values ('Press 38', 1, 'PRESS-0038', 'This is press 38 and is a big un', 
            'Some comments in here', 4);
INSERT INTO Equipment (Name, Description, MachineTypeId, SerialIdentifierNumber, Comments, AreaId) 
            Values ('Press 10', 1, 'PRESS-0010', 'This is press 10 and is a small un', 
            'Some comments in here', 4);
INSERT INTO Equipment (Name, Description, MachineTypeId, SerialIdentifierNumber, Comments, AreaId) 
            Values ('ASM-001', 2, 'ASM-0001', 'This is a machine in assembly', 
            'Some comments in here', 6);
INSERT INTO Equipment (Name, Description, MachineTypeId, SerialIdentifierNumber, Comments, AreaId) 
            Values ('CNC Machine 1', 5, 'CNC-001', 'This is press 38 and is a big un', 
            'Some comments in here', 1);
INSERT INTO Equipment (Name, Description, MachineTypeId, SerialIdentifierNumber, Comments, AreaId) 
            Values ('Phossy Tank Plant 3', 7, 'PLNT-001', 'Contains acid i think.', 
            'Some comments in here', 3);

--Machine Table SEED Data
INSERT INTO MachineTypes (TypeName, Description) Values ('Press', 'Transfer press');
INSERT INTO MachineTypes (TypeName, Description) Values ('Assembly Machine', 'This is a assembly machine');
INSERT INTO MachineTypes (TypeName, Description) Values ('CNC Machine', 'This is a CNC machine');
INSERT INTO MachineTypes (TypeName, Description) Values ('Injection Mould Machine', 'This is an injection blow mould machine');
INSERT INTO MachineTypes (TypeName, Description) Values ('Blow Mould Machine', 'This is a blow mould machine');
INSERT INTO MachineTypes (TypeName, Description) Values ('Lighting', 'General lighting');
INSERT INTO MachineTypes (TypeName, Description) Values ('Plant 1', 'Everythign on plant 1');
INSERT INTO MachineTypes (TypeName, Description) Values ('Plant 2', 'Everything for plant 2');
INSERT INTO MachineTypes (TypeName, Description) Values ('Warehouse Racking', 'All racking in the warehouse');

--STATUS Table SEED data
INSERT INTO Status (StatusName) values ('New');
INSERT INTO Status (StatusName) values ('Open');
INSERT INTO Status (StatusName) values ('In Progress');
INSERT INTO Status (StatusName) values ('Completed');
INSERT INTO Status (StatusName) values ('On Hold');

--Maintenance Requestion Initation
INSERT INTO MaintRequestInitiations (DateRaised, CompanyId, FactoryId, AreaId, EquipmentId, RequestDetails, RequestTypeId, StatusId, AssignedTo)
            Values ('2020/02/01', 1, 2, 1, 1 , 'The top shaft has broken and just spins freely.', 1, 1, 1);
INSERT INTO MaintRequestInitiations (DateRaised, CompanyId, FactoryId, AreaId, EquipmentId, RequestDetails, RequestTypeId, StatusId, AssignedTo)
            Values ('2020/12/15', 1, 2, 1, 3, 'The base disc plate has a crack and is on the verge of snapping.', 1, 1, 1);
INSERT INTO MaintRequestInitiations (DateRaised, CompanyId, FactoryId, AreaId, EquipmentId, RequestDetails, RequestTypeId, StatusId, AssignedTo)
            Values ('2021/03/03', 1, 1, 1, 2, 'There is no power to the press is seems like the electrical cable has been cut.', 1, 1, 1);
INSERT INTO MaintRequestInitiations (DateRaised, CompanyId, FactoryId, AreaId, EquipmentId, RequestDetails, RequestTypeId, StatusId, AssignedTo)
            Values ('2021/02/15', 1, 1, 1, 2, 'There is no power to the press is seems like the electrical cable has been cut.', 1, 1, 1);

--Maintenance Request General

--Maintenance Request Plant

--Users (temp until authentication is in place)

