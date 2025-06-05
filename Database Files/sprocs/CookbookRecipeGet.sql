create or alter proc dbo.CookbookRecipeGet(
@CookbookRecipeId int = 0 output,
@CookbookId int = 0,
@Message varchar(500) = '' output
)
as
begin
declare @return int = 0

select cr.CookbookRecipeId, cr.CookbookId, cr.RecipeId, cr.RecipeSequence 
from CookbookRecipe cr
where CookbookId = @CookbookId


return @return
end

select * from CookbookRecipe