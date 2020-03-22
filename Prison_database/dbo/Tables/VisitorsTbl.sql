CREATE TABLE [dbo].[VisitorsTbl]
(
	[VisitorsPassNumber] INT NOT NULL PRIMARY KEY, 
	[PrisonerID] int not null FOREIGN KEY (PrisonerID) references PrisonerTbl([PrisonerID]), 
	[VisitorsFirstName] nvarchar(max) not null, 
	[VisitorLastName] nvarchar(max) not null, 
	[Relationship] nvarchar(max) not null, 
	[DateofVisit] datetime2(7) not null, 
	[MonthlyVisit] int not null, 
	[Gender] nvarchar(7) not null, 
)
