CREATE TABLE [dbo].[AdministratorTbl]
(
	[AdminID] INT identity(4321,54) NOT NULL constraint PK_AdminTbl PRIMARY KEY,
	[FirstName] varchar(150) not null,
	[LastName] varchar(150) not null,
	[Gender] varchar(10) constraint Check_Gender_AdminTbl check(Gender='Male' or Gender='Female') NOT NULL,
	[Role] varchar(150) not null,
	[Username] varchar(100) null constraint Unique_Username_AdminTbl unique,
	[EmailAddress] varchar(150) not null constraint Unique_Email_AdminTbl unique,
	[Password] varbinary(max) not null,
	[Image] varbinary(max) null
)
