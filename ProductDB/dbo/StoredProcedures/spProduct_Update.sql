CREATE PROCEDURE [dbo].[spProduct_Update]
	@Id int,
	@Name nvarchar(30),
	@Category nvarchar(30)
AS
	begin
	update dbo.[Product]
	set Name=@Name, Category=@Category
	where Id = @Id
	end