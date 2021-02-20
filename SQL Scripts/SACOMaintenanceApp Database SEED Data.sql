
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
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Press Shop', 'PRessing area', 2);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Tool Room', 'End of F2', 2);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Assembly', 'Assembly machine room , tool room, office and QC office', 2);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('Offices F3', 'Includes Sales, HR, Nekem and projects offices', 3);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('FL Production', 'Production area', 3);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('GTL Production', 'Production area', 3);
INSERT INTO Areas (AreaName, CommentsNotes, FactoryId) Values ('F1 Top Floor Offices', 'These offices are currently not in use', 1);

--Maint Request Type Table SEED Data
INSERT INTO MaintRequestTypes (TypeName) Values ('Plant');
INSERT INTO MaintRequestTypes (TypeName) Values ('General');

--PPE Table SEED Data
INSERT INTO PPE (PPEName, Description, IconFileLocation, MaintRequestType) Values ('Gloves', 'Standard saftey gloves', 1);