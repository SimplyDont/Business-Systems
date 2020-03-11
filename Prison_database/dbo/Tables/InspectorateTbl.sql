CREATE TABLE [dbo].[InspectorateTbl]
(
	[WardenId] INT NOT NULL PRIMARY KEY, 
	[WardenFirstName] nvarchar(max) not null, 
	[WardenLastName] nvarchar(max) not null, 
	[Gender] nvarchar(10) not null, 
	[PrisonID] int not null FOREIGN KEY (PrisonID) references PrisonTbl(PrisonID), 
	[Roles]  nvarchar(max) not null,
)
