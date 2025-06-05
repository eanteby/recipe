create or alter proc dbo.CookbookRecipeDelete(
@CookbookRecipeId int = 0 ,
@MessageId varchar(500) = '' output
)
as
begin
declare @return int = 0

select @CookbookRecipeId = isnull(@CookbookRecipeId, 0)

delete CookbookRecipe where CookbookRecipeId = @CookbookRecipeId

return @return
end