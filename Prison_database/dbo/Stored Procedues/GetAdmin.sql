CREATE PROCEDURE [dbo].[GetAdmin]
	@email nvarchar(150),
	@password nvarchar(max)
AS
Begin
set nocount on;
Begin try
	select * from AdministratorTbl where EmailAddress=@email and convert(varchar(1000),[Password])=@password
end try
begin catch
	throw;
end catch

end
