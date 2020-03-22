CREATE PROCEDURE [dbo].[GetAllAdmins]
as
begin
set nocount on;
select * from AdministratorTbl;
end;
