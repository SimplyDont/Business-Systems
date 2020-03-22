CREATE PROCEDURE [dbo].[InsertAdmin]
	@firstname varchar(150),
	@lastname varchar(150),
	@gender varchar(10),
	@role varchar(150),
	@username varchar(100),
	@email varchar(150),
	@password varchar(max),
	@image varbinary(max)
AS
Begin
set nocount on;
Begin try
	insert into AdministratorTbl values(@firstname,@lastname,@gender,@role,@username,@email,Convert(varbinary(max),@password),@image)
end try
begin catch
	throw;
end catch

end
