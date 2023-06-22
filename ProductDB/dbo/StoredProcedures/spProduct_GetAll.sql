CREATE PROCEDURE [dbo].[spProduct_GetAll]
	@param1 int = 0,
	@param2 int
AS
begin
 SELECT Id, Name, Category
 from dbo.[Product];
end