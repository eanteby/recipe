create or alter proc dbo.CloneRecipe(
	@RecipeId int = 0 output,
	@BaseRecipeId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @Return int = 0

	select @RecipeId = isnull(@RecipeID, 0)

	begin try
		begin tran
			insert Recipe(HeartyHearthUserId, CuisineId, RecipeName, NumCalories, DateDrafted, DateArchived, DatePublished)
			select r.HeartyHearthUserId, r.CuisineId, concat(r.RecipeName, ' -clone'), r.NumCalories, GETDATE(), null, null
			from Recipe r 
			where r.RecipeId = @BaseRecipeId

			select @RecipeId = SCOPE_IDENTITY()
			;
			with x as(
				select RecipeId = r.RecipeId 
				from Recipe r 
				where r.RecipeId = @RecipeId
			)
			insert Direction(RecipeId, StepNum, Instruction)
			select x.RecipeId, d.StepNum, d.Instruction
			from Direction d 
			join Recipe r
			on d.RecipeId = r.RecipeID 
			cross join x 
			where r.RecipeId = @BaseRecipeId

			;
			with x as(
				select RecipeId = r.RecipeId 
				from Recipe r 
				where r.RecipeId = @RecipeId
			)
			insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, IngredientSequence, MeasurementAmount)
			select x.RecipeId, ri.IngredientId, ri.MeasurementTypeId, ri.IngredientSequence, ri.MeasurementAmount
			from RecipeIngredient ri  
			join Recipe r
			on ri.RecipeId = r.RecipeID 
			cross join x 
			where r.RecipeId = @BaseRecipeId
		commit
	end try

	begin catch
		rollback;
		throw
	end catch

	return @Return
end

