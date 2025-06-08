create or alter proc dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int output,
	@CookbookId int,
	@RecipeId int,
	@RecipeSequence int,
	@Message varchar(500) = ''
)
as
begin

	declare @Return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0)

	if (@CookbookRecipeId = 0)
	begin 
	 insert CookbookRecipe(CookbookId, RecipeId, RecipeSequence)
	 values (@CookbookId, @RecipeId, @RecipeSequence)

	 select @CookbookRecipeId = SCOPE_IDENTITY()
	end

	else
	begin
		update CookbookRecipe
		set 
		CookbookId = @CookbookId, 
		RecipeID = @RecipeID, 
		RecipeSequence = @RecipeSequence
		where CookbookRecipeId = @CookbookRecipeId
	end

	return @Return

end

