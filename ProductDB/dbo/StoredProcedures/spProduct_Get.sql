CREATE PROCEDURE [dbo].[spProduct_Get]
	@Id int
AS
begin
 SELECT Id, Name, Category
 from dbo.[Product]
 where Id = @Id;
end
