create or alter proc dbo.CuisineDelete(
	@CuisineId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @Return int = 0


	select @CuisineId = isnull(@CuisineId, 0)

	begin try
		begin tran
			delete ri
			from RecipeIngredient ri
			join Recipe r
			on r.RecipeId = ri.RecipeId
			where r.CuisineId = @CuisineId

			delete d
			from Direction d
			join Recipe r
			on r.RecipeId = d.RecipeId
			where r.CuisineId = @CuisineId

			select * from direction

			delete Cbr
			from CookbookRecipe cbr
			join Recipe r
			on r.RecipeId = cbr.RecipeId
			where r.CuisineId = @CuisineId

			delete mcr
			from MealCourseRecipe mcr
			join Recipe r
			on r.RecipeId = mcr.RecipeId
			where r.CuisineId = @CuisineId

			delete Recipe where CuisineId = @CuisineId
			delete Cuisine where CuisineId = @CuisineId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @Return

end
