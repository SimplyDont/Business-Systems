CREATE TABLE [dbo].[AdministratorTbl]
(
	[AdminID] INT identity(4321,2) NOT NULL constraint PK_AdminTbl PRIMARY KEY,
	[FirstName] nvarchar(150) not null,
	[LastName] nvarchar(150) not null,
	[Gender] nvarchar(7) constraint Check_Gender_AdminTbl check(Gender='Male' or Gender='Female'),
	[Role] nvarchar(150) not null,
	[Username] nvarchar(100) null,
	[EmailAddress] nvarchar(150) not null,
	[Password] varbinary(max) not null,
	[Image] varbinary(max) null
)
