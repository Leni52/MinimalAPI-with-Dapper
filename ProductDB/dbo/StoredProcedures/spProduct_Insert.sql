CREATE PROCEDURE [dbo].[spProduct_Insert]
	@Name nvarchar(30),
	@Category nvarchar(30)
AS
begin
insert into dbo.[Product] (Name, Category)
values(@Name, @Category)
end