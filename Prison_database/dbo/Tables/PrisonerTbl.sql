CREATE TABLE [dbo].[PrisonerTbl]
(
	[PrisonerId] INT NOT NULL PRIMARY KEY, 
	[PrisonerFirstName] nvarchar(150) not null, 
	[PrisonerLastName] nvarchar (150) not null, 
	[Gender] nvarchar(7) not null, 
	[Fingerprint] varbinary not null, 
	[Ethnicity] nvarchar(200) not null, 
	[ChargesID] int not null, 
	[Contraband] nvarchar(max) not null, 
	[PrisonID] int not null FOREIGN KEY (PrisonID) references PrisonTbl(PrisonID) ,
	[PrisonerImage] varbinary(max) null

)
