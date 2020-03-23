CREATE PROCEDURE [dbo].[GetImageByEmail]
	@email varchar(150)

AS
begin try
	set nocount on;
	SELECT [Image] from AdministratorTbl where [EmailAddress]=@email
end try
begin catch
	throw;
end catch

