CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
begin
 SELECT Id, Name, Category
 from dbo.[Product];
end