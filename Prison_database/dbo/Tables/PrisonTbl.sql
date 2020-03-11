CREATE TABLE [dbo].[PrisonTbl]
(
	[PrisonID] INT NOT NULL constraint PK_PRISONTBL PRIMARY KEY,
	[PrisonName] nvarchar(max) not null,
	[CurrentCapacity] int  not null, 
	[MaxCapacity] int not null, 
	[TypeofPrison] nvarchar(200) not null

)
